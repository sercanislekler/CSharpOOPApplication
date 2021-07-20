using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Otomasyon.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili kayıt kalıcı olarak güncellenecektir.\n Güncelleme işlemini onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult Sil(bool Silme)
        {
            return MessageBox.Show("Seçili olan kayıt kalıcı olarak silinecektir.\n Devam etmek istiyor musunuz? ", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult KullaniciVar(bool SilmeIslem)
        {
            return MessageBox.Show("Bu carinin aktif bir kasa hesabı olduğundan dolayı silinemez. \n İşleme devam etmek istiyorsanız öncelikle kasa hesabını kapatın.","İşleme Devam Edilemez.",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public void Guncelle(bool Guncelleme)
        {
            MessageBox.Show("Kayıt Güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
