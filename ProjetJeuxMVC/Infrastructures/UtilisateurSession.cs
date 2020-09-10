using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jeux.DAL.Global.Models;
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

        public static void Abandon()
        {
            HttpContext.Current.Session.Abandon();
        }
    }
}