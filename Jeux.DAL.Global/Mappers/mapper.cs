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
                Email = (string)reader[nameof(Utilisateur.Email)]
                //Passwd = (string)reader[nameof(Utilisateur.Passwd)] PAS REQUIS
                //FormuleId = (int) reader [nameof (Utilisateur.FormuleId)],
                //AdresseId =(int) reader [nameof (Utilisateur.AdresseId)]
            };

        }
        public static LoginInfo ToLoginInfoGLOBAL (this IDataRecord reader)
        {
            if (reader == null) return null;
            return new LoginInfo
            {
                NomUtilisateur = (string)reader[nameof(LoginInfo.NomUtilisateur)],
                Password = (string)reader[nameof(LoginInfo.Password)]
            };
        }

        public static AffichageDeListeJeux ToAffichageDeListeJeuxGlobal (this IDataRecord reader)
        {
            if (reader == null) return null;
            return new AffichageDeListeJeux
            {
                Id = (int)reader[nameof(AffichageDeListeJeux.Id)],
                Nom = (string)reader[nameof(AffichageDeListeJeux.Nom)],
                Description = (string)reader[nameof(AffichageDeListeJeux.Description)],
                Image = (string)reader[nameof(AffichageDeListeJeux.Image)],
                DateDeSortie = (DateTime)reader[nameof(AffichageDeListeJeux.DateDeSortie)]
            }; 
        }
    }
}
