using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jeux.DAL.Global.Models;

namespace Jeux.DAL.Global.Repositories
{
    public interface IUtilisateurRepository<TId, TEntity> : IRepository<TId, TEntity>
    {
        TEntity Check(LoginInfo entity);
    }
}
