using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Jeux.DAL.Global.Models;

namespace Jeux.DAL.Client.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string NomUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        
        public Utilisateur(G.Utilisateur entity)
        {
            Id = entity.Id;
            NomUtilisateur = entity.NomUtilisateur;
            Nom = entity.Nom;
            Prenom = entity.Prenom;
            Email = entity.Email;
            Password = entity.Password;
        }

        public Utilisateur(string nomUtilisateur, string nom, string prenom, string email, string password)
        {
            
            NomUtilisateur = nomUtilisateur;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
        }

        public Utilisateur(int id, string nomUtilisateur, string nom, string prenom, string email, string password)
        {
            Id = id;
            NomUtilisateur = nomUtilisateur;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
        }

        public Utilisateur(Utilisateur entity)
        {
        }
    }
}
