using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon.Modul_Satis
{
    public partial class NakitSatis : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesaj = new Fonksiyonlar.Mesajlar();
        int SecimID = -1;

        public NakitSatis()
        {
            InitializeComponent();
        }

        private void NakitSatis_Load(object sender, EventArgs e)
        {
            
        }
    }
}
