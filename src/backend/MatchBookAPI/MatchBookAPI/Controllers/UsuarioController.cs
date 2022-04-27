using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using MatchBookAPI.Models;
using MatchBookAPI.Seachers;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util;
using System.Threading;
using Facebook;
using Microsoft.AspNetCore.Authentication.OAuth;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Owin.Security.Facebook;
using Microsoft.AspNetCore.Server.HttpSys;

namespace MatchBookAPI.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IConfiguration _configuration;


        public UsuarioController(IConfiguration configuration)
        {
                _configuration = configuration;
        }

        [Route("api/v1/criar-usuario")]
        [HttpPost]
        public JsonResult CriarUsuario(Usuario usuarioModel)
        {
            string query = @"
                insert into Usuario (id,nome,documento,permissao,email,senha,celular) 
                values (@id,@nome,@documento,@permissao,@email,@senha,@celular) 
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DbConnection");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();

                usuarioModel.senha = BCrypt.Net.BCrypt.HashPassword(usuarioModel.senha);
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    Guid uuid = Guid.NewGuid();

                    myCommand.Parameters.AddWithValue("@id", uuid.ToString());
                    myCommand.Parameters.AddWithValue("@nome", usuarioModel.nome);
                    myCommand.Parameters.AddWithValue("@documento", usuarioModel.documento);
                    myCommand.Parameters.AddWithValue("@permissao", usuarioModel.permissao);
                    myCommand.Parameters.AddWithValue("@email", usuarioModel.email);
                    myCommand.Parameters.AddWithValue("@senha", usuarioModel.senha);
                    myCommand.Parameters.AddWithValue("@celular", usuarioModel.celular);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            JsonResult finded = new JsonResult(table);
            finded.StatusCode = 202;

            return new JsonResult("Usuario Criado com sucesso!");
        }

        [Route("api/v1/autentica/google")]
        [HttpPost]
        public JsonResult AutenticaGoogle()
        {
            string clientId = "819977362083-6jpt705g7083t9ds1vjeotokts3nh2ni.apps.googleusercontent.com";
            string clientSecret = "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";

            string[] scopes = { "https://www.googleapis.com/auth/gmail.readonly", "https://www.googleapis.com/auth/youtube" };

            var credentials = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets { ClientId = clientId, ClientSecret = clientSecret, },
                scopes, "user", CancellationToken.None).Result;

            if (credentials.Token.IsExpired(SystemClock.Default))
                credentials.RefreshTokenAsync(CancellationToken.None).Wait();

            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credentials
            }); ;

            var profile = service.Users.GetProfile(clientId).Execute();
            Console.WriteLine(profile.MessagesTotal);


            return new JsonResult("Usuario Criado com sucesso!");
        }

        [Route("api/v1/autentica/facebook")]
        [HttpPost]
        public async Task<JsonResult> AutenticaFacebookAsync()
        {

            string _appAccessToken = "";

            string appId = "1100301847502772";
            string appSecret = "570bdc45947dea1a686b83cb367dcd7d";

            /*
            var fb = new FacebookClient();
            dynamic result = fb.Post("oauth/access_token", new
            {
                client_id = "444977858884680",
                client_secret = "0e82b0d234a172df378b10929a65fef1",
                redirect_uri = RedirectUri.AbsoluteUri,
                code = code
            });

            var accessToken = result.access_token;

            // Store the access token in the session
            Session["AccessToken"] = accessToken;

            // update the facebook client with the access token so 
            // we can make requests on behalf of the user
            fb.AccessToken = accessToken;

            // Get the user's information
            dynamic me = fb.Get("me?fields=first_name,last_name,id,email");
            string email = me.email;

            // Set the auth cookie
            FormsAuthentication.SetAuthCookie(email, false);
            */

            return new JsonResult("Usuario Criado com sucesso!");
        }


        [Route("api/v1/valida-token")]
        public JsonResult ValidarToken(TokenAutenticacao tokenEnviado)
        {

            byte[] tokenByteArray = Convert.FromBase64String(tokenEnviado.token);
            DateTime horarioVidaToken = DateTime.FromBinary(BitConverter.ToInt64(tokenByteArray, 0));
            if (horarioVidaToken < DateTime.UtcNow.AddMinutes(2))
            {
                return new JsonResult(new TokenValidacao(tokenEnviado.token, true, DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), "VALIDO"));
            }
            else
            {
                // Token Expirado
                return new JsonResult(new TokenValidacao(tokenEnviado.token, false, DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), "INVALIDO"));
            }
        }





        [Route("api/v1/autentica-usuario")]
        [HttpPost]
        public JsonResult verificarLogin(LoginSeacher searcher)
        {
            string query = "SELECT usr.nome, usr.senha FROM public.usuario usr ";

            query += " WHERE usr.nome = '" + searcher.nome + "'";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DbConnection");
            NpgsqlDataReader myReader;

            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();

                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }


            LoginSeacher findedLogin = new LoginSeacher();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                findedLogin.nome = table.Rows[i]["nome"].ToString();
                findedLogin.senha = table.Rows[i]["senha"].ToString();
            }



             if (findedLogin.nome == null)
            {
                return new JsonResult("Usuario ou Senha incorreto!");
            }

            if (BCrypt.Net.BCrypt.Verify(searcher.senha, findedLogin.senha))
            {

                byte[] tempo = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                byte[] chave = Guid.NewGuid().ToByteArray();
                string token = Convert.ToBase64String(tempo.Concat(chave).ToArray());

                TokenAutenticacao tokenAutenticacao = new TokenAutenticacao(token, DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture));

                return new JsonResult(tokenAutenticacao);
            }
            else
            {
                return new JsonResult("Usuario ou Senha incorreto!");
            }



            return new JsonResult(table);

        }



    }
}
