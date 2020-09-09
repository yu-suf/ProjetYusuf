using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux.DAL.Global.Repositories
{
    public interface IUtilisateurRepository<TId, TEntity> : IRepository<TId, TEntity>
    {
        TEntity Check(TEntity entity);
    }
}
