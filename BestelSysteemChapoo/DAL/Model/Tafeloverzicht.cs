using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Tafeloverzicht
    {
        // public List<BestelItem> bestelling;
        public int btwLaag;
        public int btwHoog;
        public int totaalPrijs;
        public int fooi;
        public DateTime datumTijd;
        public string medewerker;
        public string opmerking;
        public bool betaald;

        public Tafeloverzicht()
        {
            
        }
    }
}
