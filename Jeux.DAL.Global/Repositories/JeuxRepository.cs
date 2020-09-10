using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jeux.DAL.Global.Models;
using ToolBox.ADO;
using Jeux.DAL.Global.Mappers;

namespace Jeux.DAL.Global.Repositories
{
    public class JeuxRepository : BasicRepository, IRepository<int, AffichageDeListeJeux>
    {
        public bool Delete(int id)
        {
            Command command = new Command("DELETE FROM [Jeux] WHERE id = @id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) > 0;
        }
        
        public IEnumerable<AffichageDeListeJeux> Get()
        {
            Command command = new Command("SELECT Id, Nom, Description, Image, DateDeSortie FROM [Jeux]");
            return _connection.ExecuteReader(command, (reader) => reader.ToAffichageDeListeJeuxGlobal());

        }
        
        public AffichageDeListeJeux Get(int id)
        {
            Command command = new Command("SELECT Id, Nom, Description, Image, DateDeSortie FROM [Jeux] WHERE Id = @id");
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToAffichageDeListeJeuxGlobal()).Single();
        }
        
        public int Insert(AffichageDeListeJeux entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, AffichageDeListeJeux entity)
        {
            throw new NotImplementedException();
        }
    }
}
