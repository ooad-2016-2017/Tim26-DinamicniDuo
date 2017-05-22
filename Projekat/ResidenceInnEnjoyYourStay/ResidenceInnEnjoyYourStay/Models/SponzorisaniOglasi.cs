using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD1.ResidenceInnBaza.Models
{
    public class SponzorisaniOglasi : BazniOglasi
    {
        private int cijenaSponzorstva;
        private int rokTrajanja;
        private String nacinSponzorisanja;
        private DateTime pocetakSponzorisanja;

        public int CijenaSponzorstva
        {
            get
            {
                return cijenaSponzorstva;
            }
            set
            {
                if (value != cijenaSponzorstva)
                {
                    cijenaSponzorstva = value;
                }
            }
        }
        public int RokTrajanja
        {
            get
            {
                return rokTrajanja;
            }
            set
            {
                if (value != rokTrajanja)
                {
                    rokTrajanja = value;
                }
            }
        }
        public String NacinSponzorisanja
        {
            get
            {
                return nacinSponzorisanja;
            }
            set
            {
                if (value != nacinSponzorisanja)
                {
                    nacinSponzorisanja = value;
                }
            }
        }
        public DateTime PocetakSponzorisanja
        {
            get
            {
                return pocetakSponzorisanja;
            }
            set
            {
                if (value != pocetakSponzorisanja)
                {
                    pocetakSponzorisanja = value;
                }
            }
        }

    }
}
