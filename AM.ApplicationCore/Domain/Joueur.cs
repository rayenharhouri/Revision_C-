using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Joueur
    {
        public int JoueurId { get; set; }
        public string PaysFk { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        public string Genre { get; set; }
        public String Prenom { get; set; }
        public String Photo { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual IList<Jouer> Jouers { get; set; }



    }
}
