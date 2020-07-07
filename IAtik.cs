using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndppp
{
    interface IAtik
    {
        int sayi { get; set; }
        string Ad { get; }
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }
}
