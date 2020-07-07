using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndppp
{
    interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; set; }
        int DolulukOrani { get; }
    }
}
