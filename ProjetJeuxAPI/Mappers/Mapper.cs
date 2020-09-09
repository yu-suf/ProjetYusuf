using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A = ProjetJeuxAPI.Models;
using C = Jeux.DAL.Client.Models;

namespace ProjetJeuxAPI.Mappers
{
    public static class Mapper
    {
        public static A.Utilisateur ToAPIUtilisateur(this C.Utilisateur user)
        {
            if (user == null) return null;

            return new A.Utilisateur()
            {
                Id = user.Id,
                NomUtilisateur = user.NomUtilisateur,
                Nom = user.Nom,
                Email = user.Email,
                Prenom = user.Prenom,
                Password = user.Password
            };
        }

        public static C.Utilisateur ToClientUtilisateur(this A.Utilisateur user)
        {
            if (user == null) return null;

            return new C.Utilisateur()
            {
                Id = user.Id,
                NomUtilisateur = user.NomUtilisateur,
                Nom = user.Nom,
                Email = user.Email,
                Prenom = user.Prenom,
                Password = user.Password
            };
        }
    }
}