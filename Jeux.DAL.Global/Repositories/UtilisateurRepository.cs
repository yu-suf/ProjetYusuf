using Jeux.DAL.Global.Mappers;
using Jeux.DAL.Global.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.ADO;

namespace Jeux.DAL.Global.Repositories
{
    public class UtilisateurRepository : BasicRepository, IUtilisateurRepository<int, Utilisateur>
    {
        public Utilisateur Check(LoginInfo entity)
        {
            string sqlQueryLogin = "Exec dbo.CheckUser @NomUtilisateur, @Passwd";
            Command command = new Command(sqlQueryLogin);
            command.AddParameter("Passwd", entity.Password);
            command.AddParameter("NomUtilisateur", entity.NomUtilisateur);
            return _connection.ExecuteReader(command, (reader) => reader.ToUtilisateurGLOBAL()).SingleOrDefault();
        }

        public bool Delete(int id)
        {
            Command command = new Command("DELETE FROM [Utilisateur] WHERE id = @id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) > 0;
        }

        public IEnumerable<Utilisateur> Get()
        {
            Command command = new Command("SELECT Id, NomUtilisateur, Nom, Prenom, Email, FormuleId, AdresseId FROM [Utilisateur]");
            return _connection.ExecuteReader(command, (reader) => reader.ToUtilisateurGLOBAL());
        }

        public Utilisateur Get(int id)
        {
            Command command = new Command("SELECT Id, NomUtilisateur, Nom, Prenom, Email, FormuleId, AdresseId FROM [Utilisateur] WHERE Id = @id");
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, (reader) => reader.ToUtilisateurGLOBAL()).Single();
        }

        public int Insert(Utilisateur entity)
        {
            //string sqlQueryLogin = "RegisterUser";
            Command command = new Command("RegisterUser", true);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Email", entity.Email);
            command.AddParameter("Passwd", entity.Passwd);
            command.AddParameter("NomUtilisateur", entity.NomUtilisateur);
            //command.AddParameter("FormueleId", entity.FormuleId);
            //command.AddParameter("AdresseId", entity.AdresseId);
            return _connection.ExecuteNonQuery(command);
        }

        public bool Update(int id, Utilisateur entity)
        {
            Command command = new Command("UPDATE [Utilisateur] SET NomUtilisateur =@NomUtilisateur, Nom = @Nom, Prenom = @Prenom, Email = @Email, FormuleId = @FormuleId, AdresseId = @AdresseId WHERE Id = @id");
            command.AddParameter("id", entity.Id);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Email", entity.Email);
            command.AddParameter("NomUtilisateur", entity.NomUtilisateur);
            //command.AddParameter("AdresseId", entity.AdresseId);
            //command.AddParameter("FormuleId", entity.FormuleId);
            return _connection.ExecuteNonQuery(command) > 0;
        }
    }
}
