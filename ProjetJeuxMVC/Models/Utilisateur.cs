using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetJeuxMVC.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string NomUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Utilisateur()
        {

        }
        //public Utilisateur(C.Utilisateur entity)
        //{
        //    Id = entity.Id;
        //    NomUtilisateur = entity.NomUtilisateur;
        //    Nom = entity.Nom;
        //    Prenom = entity.Prenom;
        //    Email = entity.Email;
        //    Password = entity.Password;
        //}

        public void Deconstructeur(out int id, out string nomUtilisateur, out string nom, out string prenom, out string email, out string password)
        {
            id = Id;
            nomUtilisateur = NomUtilisateur;
            nom = Nom;
            prenom = Prenom;
            email = Email;
            password = Password;
        }
    }
}