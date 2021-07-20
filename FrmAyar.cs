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
    public partial class FrmAyar : Form
    {
        public FrmAyar()
        {
            InitializeComponent();
        }

        private void FrmAyar_Load(object sender, EventArgs e)
        {
            labelControl6.Text = Otomasyon.Properties.Settings.Default.cs1 +
                Otomasyon.Properties.Settings.Default.cs_Sunucu + Otomasyon.Properties.Settings.Default.cs2 +
                Otomasyon.Properties.Settings.Default.cs_Database + Otomasyon.Properties.Settings.Default.cs3 +
               Otomasyon.Properties.Settings.Default.cs_UserID +
                Otomasyon.Properties.Settings.Default.cs4 + Otomasyon.Properties.Settings.Default.cs_Password;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            txtDatabase.Enabled = !txtDatabase.Enabled;
            txtPassword.Enabled = !txtPassword.Enabled;
            txtSunucu.Enabled = !txtSunucu.Enabled;
            txtUserId.Enabled = !txtUserId.Enabled;
            btnYeniKaydet.Enabled = !btnYeniKaydet.Enabled;
        }

        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.cs_Sunucu = txtSunucu.Text.Trim() + ";";
            Properties.Settings.Default.cs_Database = txtDatabase.Text.Trim() + ";";
            Properties.Settings.Default.cs_UserID = txtUserId.Text.Trim() + ";";
            Properties.Settings.Default.cs_Password= txtPassword.Text.Trim() + ";";
            Properties.Settings.Default.Database = txtDatabase.Text.Trim();
            Properties.Settings.Default.Save();
            //Application.Restart();
            this.Close();
        }
    }
}
