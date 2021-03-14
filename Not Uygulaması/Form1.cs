using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Uygulaması
{
    public partial class Form1 : Form
    {
        public int not1;
        public int not2;
        public int ort;

        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            not1 = Convert.ToInt32(tbox1not.Text);
            not2 = Convert.ToInt32(tbox2not.Text);
            ort = ((not1 + not2) / 2);
            
            listboxad.Items.Add("Adınız : " + tboxad.Text);
            listboxsoyad.Items.Add("Soyadınız : " + tboxsoyad.Text);
            listboxnot1.Items.Add("1. Notunuz : " + not1);
            listboxnot2.Items.Add("2. Notunuz : " + not2);
            ortalama.Items.Add("Ortalamanız : " + ort);
            
            if (ort >= 50)
            {
                sonuc.Items.Add("Geçtiniz.");
            }
            else
            {
                sonuc.Items.Add("Kaldınız.");
            }

            
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            tboxad.Clear();
            tboxsoyad.Clear();
            tbox1not.Clear();
            tbox2not.Clear();

            listboxad.Items.Clear();
            listboxsoyad.Items.Clear();
            listboxnot1.Items.Clear();
            listboxnot2.Items.Clear();
            ortalama.Items.Clear();
            sonuc.Items.Clear();
        }
    }
}
