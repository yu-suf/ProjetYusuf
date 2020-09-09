using Jeux.DAL.Global.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jeux.DAL.Global.Repositories;
using C = Jeux.DAL.Client.Models;
using G = Jeux.DAL.Global.Models;
using Jeux.DAL.Client.Mappers;

namespace Jeux.DAL.Client.Services
{
    public class UtilisateurService : IUtilisateurRepository<int, C.Utilisateur>
    {
        private IUtilisateurRepository<int, G.Utilisateur> _repo;
        public UtilisateurService()
        {
            _repo = new UtilisateurRepository();
        }
        public C.Utilisateur Check(C.Utilisateur entity)
        {

            return _repo.Check(entity.ToUtilisateurGLOBAL()).ToUtilisateurCLIENT();
        }
        
        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public IEnumerable<C.Utilisateur> Get()
        {
            return _repo.Get().Select(u => u.ToUtilisateurCLIENT());
        }

        public C.Utilisateur Get(int id)
        {
            return _repo.Get(id).ToUtilisateurCLIENT();
        }

        public int Insert(C.Utilisateur entity)
        {
            return _repo.Insert(entity.ToUtilisateurGLOBAL());
        }

        public bool Update(int id, C.Utilisateur entity)
        {
            return _repo.Update(id, entity.ToUtilisateurGLOBAL());
        }
    }
}
