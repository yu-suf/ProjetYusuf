using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux.DAL.Global.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string NomUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int FormuleId { get; set; }
        public int AdresseId { get; set; }
    }
}
