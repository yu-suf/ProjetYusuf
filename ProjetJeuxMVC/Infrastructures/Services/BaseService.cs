using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ProjetJeuxMVC.Infrastructures.Services
{
    public class BaseService
    {
        protected HttpClient _httpClient;

        public BaseService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:65362/api/");
        }
    }
}