using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndppp
{
    class OrganikKutusu : AtikKutusu
    {
        public int BosaltmaPuani
        {
            get
            {
                return 0;
            }
        }
        public int DoluHacim
        {
            get;
            set;
        }
        public int DolulukOrani
        {
            get
            {
                return (DoluHacim * 100) / Kapasite;
            }
        }
        public int Kapasite
        {
            get
            {
                return 700;
            }
        }
        public override bool Ekle(Atik atik)
        {
            if (DolulukOrani <= 75)
            {

                return true;
            }
            else
                return false;
        }
        public override bool Bosalt()
        {
            if (DolulukOrani > 75)
            {
                return true;
            }
            else
                return false;
        }
    }
}
