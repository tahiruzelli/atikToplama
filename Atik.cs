using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace ndppp
{
    class Atik:IAtik
    {
        public int sayi { get; set; }
        public string Ad { get; }
        public Image RasgeleImage()
        {
            Image im = Image.FromFile("domates.jpg");
            
            
            Random rastgele = new Random();
            string[] adresler = { "domates.jpg", "salatalik.jpg", "dergi.jpg", "gazete.jpg", "sise.jpg", "bardak.jpg", "salca.jpg", "kola.jpg" };
            sayi = rastgele.Next(8);
            if (sayi == 0)
                im = Image.FromFile("domates.jpg");
            if (sayi == 1)
                im = Image.FromFile("salatalik.jpg");
            if (sayi == 2)
                im = Image.FromFile("dergi.jpg");
            if (sayi == 3)
                im = Image.FromFile("gazete.jpg");
            if (sayi == 4)
                im = Image.FromFile("sise.jpg");
            if (sayi == 5)
                im = Image.FromFile("bardak.jpg");
            if (sayi == 6)
                im = Image.FromFile("salca.jpg");
            if (sayi == 7)
                im = Image.FromFile("kola.jpg");
            return im;

        }
        public int Hacim { get; }
        public System.Drawing.Image Image
        {
            get
            {
                return RasgeleImage();
            }
        }
        
    }
}
