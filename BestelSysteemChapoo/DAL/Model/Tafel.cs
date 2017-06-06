using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Tafel
    {
        public int ID { get; private set; }
        public string Bezet { get; private set; }

        public Tafel(int ID, string Bezet)
        {
            this.ID = ID;
            this.Bezet = Bezet
        }

        public override string ToString()
        {
            string tafel = ID + Bezet;
            return tafel;
        }
    }
}
