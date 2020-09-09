using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Jeux.DAL.Global.Models;
using C = Jeux.DAL.Client.Models;

namespace Jeux.DAL.Client.Mappers
{
    public static class Mapper
    {
        public static G.Utilisateur ToUtilisateurGLOBAL(this C.Utilisateur entity)
        {
            if (entity == null )  return null;
            return new G.Utilisateur
            {
                Id = entity.Id,
                NomUtilisateur = entity.NomUtilisateur,
                Email = entity.Email,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Password = entity.Password
            };
        }
        public static C.Utilisateur ToUtilisateurCLIENT (this G.Utilisateur entity)
        {
            if (entity == null) return null;
            return new C.Utilisateur(entity);
        }
    }
}
