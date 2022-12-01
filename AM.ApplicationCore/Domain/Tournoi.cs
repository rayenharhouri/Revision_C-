using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Tournoi
    {
        [Key]
        public int NoTour { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        [Range(0,1)]
        public double Coef { get; set; }
        public double Dotation { get; set; }
        public virtual IList<Jouer> Jouers{ get; set; }

    }
}
