using Jeux.DAL.Client.Services;
using ProjetJeuxAPI.Mappers;
using ProjetJeuxAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetJeuxAPI.Controllers
{
    public class AuthController : ApiController
    {
        private readonly UtilisateurService _utilisateurService;
        public AuthController()
        {
            _utilisateurService = new UtilisateurService();
        }

        [HttpPost]
        public Utilisateur Login(Utilisateur utilisateur)
        {
            return _utilisateurService.Check(utilisateur.ToClientUtilisateur()).ToAPIUtilisateur();
        }

        [HttpPost]
        public int Inscription(Utilisateur utilisateur)
        {
            return (int)_utilisateurService.Insert(utilisateur.ToClientUtilisateur());
        }

        // GET: api/Auth
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Auth/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Auth
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Auth/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Auth/5
        public void Delete(int id)
        {
        }
    }
}
