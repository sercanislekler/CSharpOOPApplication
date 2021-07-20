using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm frm = new AnaForm();
            frm.Show();
        }

        private void btnBaglantiAyarlari_Click(object sender, EventArgs e)
        {
            FrmAyar frm = new FrmAyar();
            frm.ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
