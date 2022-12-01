using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Pays
    {
        [Key]
        public String CodePays { get; set; }
        public String Nom { get; set; }
        public String Monnaie { get; set; }
       
        public virtual IList<Joueur> joueurs { get; set; }
    }
}
