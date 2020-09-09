using Newtonsoft.Json;
using ProjetJeuxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;

namespace ProjetJeuxMVC.Infrastructures.Services
{
    public class AuthService : BaseService
    {


        public Utilisateur Login(Utilisateur user)
        {
            HttpResponseMessage response = _httpClient.GetAsync("auth/login/").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de reception de données ...");
            }

            return response.Content.ReadAsAsync<Utilisateur>().Result;
        }

        public int Register(Utilisateur user)
        {
            string jsonContent = JsonConvert.SerializeObject(user, Formatting.Indented);
            StringContent stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            
            HttpResponseMessage response = _httpClient.PostAsync("auth/inscription/", stringContent).Result;
            
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de l'envois de données ...");
            }

            return (int)response.Content.ReadAsAsync(typeof(int)).Result;
        }
    }
}