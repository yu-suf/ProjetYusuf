using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetJeuxMVC.Models;

namespace ProjetJeuxMVC.Infrastructures
{
    public static class UtilisateurSession
    {
        public static Utilisateur utilisateur
        {
            get { return (Utilisateur)HttpContext.Current.Session["Utilisateur"]; }
            set { HttpContext.Current.Session["Utilisateur"] = value; }
        }
    }
}