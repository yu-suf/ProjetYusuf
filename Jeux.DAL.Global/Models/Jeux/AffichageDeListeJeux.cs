using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux.DAL.Global.Models
{
    public class AffichageDeListeJeux
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public DateTime DateDeSortie { get; set; }
        public string Image { get; set; }
    }
}
