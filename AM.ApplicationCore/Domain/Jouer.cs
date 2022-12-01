using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Jouer
    {
        [Range(0, int.MaxValue)]
        public int Score { get; set; }
        public int JoeurFK { get; set; }
        public int TournoiFK { get; set; }

        public virtual Joueur Joueur { get; set; }
        public virtual Tournoi Tournoi { get; set; }

    }
}
