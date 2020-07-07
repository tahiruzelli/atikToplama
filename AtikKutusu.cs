using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndppp
{
    class AtikKutusu:IAtikKutusu
    {
        public virtual bool Bosalt()
        {
            return true;
        }
        public virtual bool Ekle(Atik atik)
        {
            return true;
        }
        public int BosaltmaPuani { get; }
        public int DoluHacim { get; set; }
        public int DolulukOrani { get; }
        public int Kapasite { get; set; }
    }
}
