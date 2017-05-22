using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD1.ResidenceInnBaza.Models
{
    public class RezervisaniOglasi : BazniOglasi
    {
        private DateTime datumPrijave;
        private DateTime datumOdjave;

        public DateTime DatumPrijave
        {
            get
            {
                return datumPrijave;
            }
            set
            {
                if (value != datumPrijave)
                {
                    datumPrijave = value;
                }
            }
        }
        public DateTime DatumOdjave
        {
            get
            {
                return datumOdjave;
            }
            set
            {
                if (value != datumOdjave)
                {
                    datumOdjave = value;
                }
            }
        }
    }
}
