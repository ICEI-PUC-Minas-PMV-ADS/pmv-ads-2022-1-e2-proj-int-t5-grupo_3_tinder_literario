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
using MatchBookAPI.Utils;

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
            CadastroStatus cadastroStatus = null;
            int statusCode = 0;

            try
            {
                string query = @"
                insert into Usuario (id,nome,documento,email,senha,celular) 
                values (@id,@nome,@documento,@email,@senha,@celular) 
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
                        myCommand.Parameters.AddWithValue("@email", usuarioModel.email);
                        myCommand.Parameters.AddWithValue("@senha", usuarioModel.senha);
                        myCommand.Parameters.AddWithValue("@celular", usuarioModel.celular);

                        myReader = myCommand.ExecuteReader();
                        table.Load(myReader);

                        myReader.Close();
                        myCon.Close();

                    }
                }

                cadastroStatus = new CadastroStatus("Cadastro feito com sucesso!", DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), true);
                statusCode = 202;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cadastroStatus = new CadastroStatus("Erro na hora de criar cadastro!", DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), false);
                statusCode = 500;
            }

            JsonResult response = new JsonResult(cadastroStatus);
            response.StatusCode = statusCode;

            return response;
        }

        [Route("api/v1/atualiza-usuario")]
        [HttpPatch]
        public JsonResult AtualizarUsuario(UsuarioEdit usuarioModel)
        {
            CadastroStatus cadastroStatus = null;
            int statusCode = 0;

            try
            {
                string query = @"
                UPDATE Usuario SET senha = @senha
                WHERE id = @id
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

                        myCommand.Parameters.AddWithValue("@id", usuarioModel.id);
                        myCommand.Parameters.AddWithValue("@senha", usuarioModel.senha);

                        myReader = myCommand.ExecuteReader();
                        table.Load(myReader);

                        myReader.Close();
                        myCon.Close();

                    }
                }

                cadastroStatus = new CadastroStatus("Atualização feita com sucesso!", DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), true);
                statusCode = 202;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cadastroStatus = new CadastroStatus("Erro na hora de realizar atualização!", DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), false);
                statusCode = 500;
            }

            JsonResult response = new JsonResult(cadastroStatus);
            response.StatusCode = statusCode;

            return response;
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



        [Route("api/v1/verifica-email")]
        [HttpGet]
        public JsonResult VerificarEmail([FromQuery(Name = "email")] string email)
        {
            if (email is null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            string query = "SELECT usr.email, usr.id FROM public.usuario usr ";

            query += " WHERE usr.email = '" + email + "'";

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


            VerificaEmail findedLogin = new VerificaEmail();

            findedLogin.id = "";
            findedLogin.email = "";
            findedLogin.existente = false;


            for (int i = 0; i < table.Rows.Count; i++)
            {
                findedLogin.id = table.Rows[i]["id"].ToString();
                findedLogin.email = table.Rows[i]["email"].ToString(); 
                findedLogin.existente = true;
            }
            return new JsonResult(findedLogin);
        }



        [Route("api/v1/autentica-usuario")]
        [HttpPost]
        public JsonResult verificarLogin(LoginSeacher searcher)
        {
            string query = "SELECT usr.id, usr.email, usr.senha FROM public.usuario usr ";

            query += " WHERE usr.email = '" + searcher.email + "'";

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
                findedLogin.id = table.Rows[i]["id"].ToString();
                findedLogin.email = table.Rows[i]["email"].ToString();
                findedLogin.senha = table.Rows[i]["senha"].ToString();
            }



             if (findedLogin.email == null)
            {
                TokenAutenticacao tokenAutenticacao = new TokenAutenticacao("", DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), false, "");
                return new JsonResult(tokenAutenticacao);
            }

            if (BCrypt.Net.BCrypt.Verify(searcher.senha, findedLogin.senha))
            {

                byte[] tempo = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                byte[] chave = Guid.NewGuid().ToByteArray();
                string token = Convert.ToBase64String(tempo.Concat(chave).ToArray());

                TokenAutenticacao tokenAutenticacao = new TokenAutenticacao(token, DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), true, findedLogin.id);

                return new JsonResult(tokenAutenticacao);
            }
            else
            {
                TokenAutenticacao tokenAutenticacao = new TokenAutenticacao("", DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), false, "");

                return new JsonResult(tokenAutenticacao);
            }



            return new JsonResult(table);

        }



    }
}
