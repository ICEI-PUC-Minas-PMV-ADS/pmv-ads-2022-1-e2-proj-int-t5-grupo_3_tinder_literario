
using MatchBookAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MatchBookAPI.Services
{
    public class LivroService
    {
        private readonly LivroRepository livroRepository;

        public LivroService(LivroRepository repository)
        {
            livroRepository = repository;
        }


        public JsonResult findAll()
        {
            return new JsonResult(livroRepository.findAll());
        }


    }
}
