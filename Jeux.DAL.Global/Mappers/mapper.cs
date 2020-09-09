using Jeux.DAL.Global.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux.DAL.Global.Mappers
{
    public static class Mapper
    {
        public static Utilisateur ToUtilisateurGLOBAL(this IDataRecord reader)
        {
            if (reader == null) return null;
            return new Utilisateur
            {
                Id = (int)reader[nameof(Utilisateur.Id)],
                NomUtilisateur = (string)reader[nameof(Utilisateur.NomUtilisateur)],
                Nom = (string)reader[nameof(Utilisateur.Nom)],
                Prenom = (string)reader[nameof(Utilisateur.Prenom)],
                Email = (string)reader[nameof(Utilisateur.Email)],
                Password = (string)reader[nameof(Utilisateur.Password)]
                //FormuleId = (int) reader [nameof (Utilisateur.FormuleId)],
                //AdresseId =(int) reader [nameof (Utilisateur.AdresseId)]
            };
        }
    }
}
