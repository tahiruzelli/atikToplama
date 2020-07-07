using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndppp
{
    public partial class Form1 : Form
    {
        CamKutusu camKutusu = new CamKutusu();
        KagitKutusu kagitKutusu = new KagitKutusu();
        MetalKutusu metalKutusu = new MetalKutusu();
        OrganikKutusu organikKutusu = new OrganikKutusu();
        Domates domates = new Domates();
        Salatalik salatalik = new Salatalik();
        Gazete gazete = new Gazete();
        Dergi dergi = new Dergi();
        Sise sise = new Sise();
        Bardak bardak = new Bardak();
        Kola kola = new Kola();
        Salca salca = new Salca();
        Atik atik = new Atik();
        private int organikPuan, camPuan, metalPuan, kagitPuan, bosaltmaPuani;
        private int sure=60;
        private int puanHesaplama()
        {
            return organikPuan + camPuan + metalPuan + kagitPuan + bosaltmaPuani;
        }
        private void butonlariAcKapa(bool durum)
        {
            //Ekleme butonlarimizi gerekli duruma getiriyoruz.
            organik_BTN.Enabled = durum;
            kagit_BTN.Enabled = durum;
            metal_BTN.Enabled = durum;
            cam_BTN.Enabled = durum;
            //Bosaltma butonlarimizi gerekli duruma getiriyoruz.
            organikBosalt_BTN.Enabled = durum;
            kagitBosalt_BTN.Enabled = durum;
            metalBosalt_BTN.Enabled = durum;
            camBosalt_BTN.Enabled = durum;
        }

        public Form1()
        {
            InitializeComponent();
            cam_PB.Maximum = camKutusu.Kapasite;
            kagit_PB.Maximum = kagitKutusu.Kapasite;
            metal_PB.Maximum = metalKutusu.Kapasite;
            organik_PB.Maximum = organikKutusu.Kapasite;
            picBox.Image = atik.RasgeleImage();
            timer.Interval = 1000;
            timer.Start();
            sure_LBL.Text = sure.ToString();
        }

       

        private void kagit_BTN_Click(object sender, EventArgs e)
        {
            if (kagitKutusu.Ekle(atik) == true && atik.sayi == 2)
            {
                kagit_LB.Items.Add(dergi.Ad + "(" + dergi.Hacim + ")");
                kagitKutusu.DoluHacim += dergi.Hacim;
                kagitPuan += dergi.Hacim;
                kagit_PB.Value = kagitKutusu.DoluHacim;
                picBox.Image = atik.RasgeleImage();
                puan_LBL.Text = puanHesaplama().ToString();

            }
            else if (kagitKutusu.Ekle(atik) == true && atik.sayi == 3)
            {
                kagit_LB.Items.Add(gazete.Ad + "(" + gazete.Hacim + ")");
                kagitKutusu.DoluHacim += gazete.Hacim;
                kagitPuan += gazete.Hacim;
                kagit_PB.Value = kagitKutusu.DoluHacim;
                picBox.Image = atik.RasgeleImage();
                puan_LBL.Text = puanHesaplama().ToString();
            }
        }

        private void cam_BTN_Click(object sender, EventArgs e)
        {
            if (camKutusu.Ekle(atik) == true && atik.sayi == 4)
            {
                cam_LB.Items.Add(sise.Ad + "(" + sise.Hacim + ")");
                camKutusu.DoluHacim += sise.Hacim;
                camPuan += sise.Hacim;
                cam_PB.Value = camKutusu.DoluHacim;
                picBox.Image = atik.RasgeleImage();
                puan_LBL.Text = puanHesaplama().ToString();

            }
            else if (camKutusu.Ekle(atik) == true && atik.sayi == 5)
            {
                cam_LB.Items.Add(bardak.Ad + "(" + bardak.Hacim + ")");
                camKutusu.DoluHacim += bardak.Hacim;
                camPuan += bardak.Hacim;
                cam_PB.Value = camKutusu.DoluHacim;
                picBox.Image = atik.RasgeleImage();
                puan_LBL.Text = puanHesaplama().ToString();

            }
        }

        private void metal_BTN_Click(object sender, EventArgs e)
        {
            if (metalKutusu.Ekle(atik) == true && atik.sayi == 6)
            {
                metal_LB.Items.Add(salca.Ad + "(" + salca.Hacim + ")");
                metalKutusu.DoluHacim += salca.Hacim;
                metalPuan += salca.Hacim;
                metal_PB.Value = metalKutusu.DoluHacim;
                picBox.Image = atik.RasgeleImage();
                puan_LBL.Text = puanHesaplama().ToString();

            }
            else if (metalKutusu.Ekle(atik) == true && atik.sayi == 7)
            {
                metal_LB.Items.Add(kola.Ad + "(" + kola.Hacim + ")");
                metalKutusu.DoluHacim += kola.Hacim;
                metalPuan += kola.Hacim;
                metal_PB.Value = metalKutusu.DoluHacim;
                picBox.Image = atik.RasgeleImage();
                puan_LBL.Text = puanHesaplama().ToString();

            }
        }

        private void organik_BTN_Click(object sender, EventArgs e)
        {
            if (organikKutusu.Ekle(atik) == true && atik.sayi == 0)
            {
                organik_LB.Items.Add(domates.Ad + "(" + domates.Hacim + ")");
                organikKutusu.DoluHacim += domates.Hacim;
                organikPuan += domates.Hacim;
                organik_PB.Value = organikKutusu.DoluHacim;
                picBox.Image = atik.RasgeleImage();
                puan_LBL.Text = puanHesaplama().ToString();
            }
            else if (organikKutusu.Ekle(atik) == true && atik.sayi == 1)
            {
                organik_LB.Items.Add(salatalik.Ad + "(" + salatalik.Hacim + ")");
                organikKutusu.DoluHacim += salatalik.Hacim;
                organikPuan += salatalik.Hacim;
                organik_PB.Value = organikKutusu.DoluHacim;
                picBox.Image = atik.RasgeleImage();
                puan_LBL.Text = puanHesaplama().ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            sure--;
            sure_LBL.Text = sure.ToString();
            if (sure <= 0)
            {
                timer.Stop();
                butonlariAcKapa(false);              
            }
        }

        private void yeniOyun_BTN_Click(object sender, EventArgs e)
        {
            timer.Start();
            butonlariAcKapa(true);
            sure = 60;
            sure_LBL.Text = "60";
            //Puanlarimizi sifirliyoruz.
            organikPuan = 0;
            camPuan = 0;
            kagitPuan = 0;
            metalPuan = 0;
            bosaltmaPuani = 0;
            puan_LBL.Text = puanHesaplama().ToString();
            //ProgressBarlari ve listboxlari temizliyoruz.
            organik_LB.Items.Clear();
            kagit_LB.Items.Clear();
            cam_LB.Items.Clear();
            metal_LB.Items.Clear();
            organik_PB.Value = 0;
            kagit_PB.Value = 0;
            cam_PB.Value = 0;
            metal_PB.Value = 0;            
        }

        private void cikis_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kagitBosalt_BTN_Click(object sender, EventArgs e)
        {
            if (kagitKutusu.Bosalt() == true)
            {
                kagit_LB.Items.Clear();
                bosaltmaPuani += kagitKutusu.BosaltmaPuani;
                kagitKutusu.DoluHacim = 0;
                sure += 3;
                sure_LBL.Text = sure.ToString();
                puan_LBL.Text = puanHesaplama().ToString();
                kagit_PB.Value = kagitKutusu.DoluHacim;
            }
            
        }

        private void camBosalt_BTN_Click(object sender, EventArgs e)
        {
            if (camKutusu.Bosalt() == true)
            {
                cam_LB.Items.Clear();
                bosaltmaPuani += camKutusu.BosaltmaPuani;
                camKutusu.DoluHacim = 0;
                sure += 3;
                sure_LBL.Text = sure.ToString();
                puan_LBL.Text = puanHesaplama().ToString();
                cam_PB.Value = camKutusu.DoluHacim;
            }

        }

        private void metalBosalt_BTN_Click(object sender, EventArgs e)
        {
            if (metalKutusu.Bosalt() == true)
            {
                metal_LB.Items.Clear();
                bosaltmaPuani += metalKutusu.BosaltmaPuani;
                metalKutusu.DoluHacim = 0;
                sure += 3;
                sure_LBL.Text = sure.ToString();
                puan_LBL.Text = puanHesaplama().ToString();
                metal_PB.Value = metalKutusu.DoluHacim;
            }

        }

        private void button1_Click(object sender, EventArgs e)//organikBosalt_BTN
        {
            if (organikKutusu.Bosalt() == true)
            {
                organik_LB.Items.Clear();
                bosaltmaPuani += organikKutusu.BosaltmaPuani;
                organikKutusu.DoluHacim = 0;
                sure += 3;
                sure_LBL.Text = sure.ToString();
                puan_LBL.Text = puanHesaplama().ToString();
                organik_PB.Value = organikKutusu.DoluHacim;
            }

        }
    }
}
