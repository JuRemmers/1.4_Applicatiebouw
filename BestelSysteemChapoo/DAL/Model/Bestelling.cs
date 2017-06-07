using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    class Bestelling
    {
        // door Donna
        public int ID { get; private set; }
        private Status status;
        private Tafel tafel;
        private Medewerker medewerker;
        private DateTime datumTijd;
        
        public enum Status { Opgenomen, Onderhande, Gereed, Uitgeserveerd}

    }
}
