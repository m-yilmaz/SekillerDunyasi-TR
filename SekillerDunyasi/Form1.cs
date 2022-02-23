using Newtonsoft.Json;
using SekillerDunyasi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekillerDunyasi
{
    public partial class Form1 : Form
    {
        BindingList<Sekil> sekiller;
        bool durum = true;
        public Form1()
        {
            InitializeComponent();
            try
            {
                string json = File.ReadAllText("veri.json");
                sekiller = JsonConvert.DeserializeObject<BindingList<Sekil>>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });
                lstSekiller.DataSource = sekiller;
            }
            catch (Exception)
            {
                sekiller = new BindingList<Sekil>();
                lstSekiller.DataSource = sekiller;
            }
            sekiller.ListChanged += Sekiller_ListChanged;
            cboTur.SelectedIndex = 0;
            nudGen.Value = 200;
            nudYuk.Value = 100;
            btnGuncelle.Enabled = false;
        }

        private void Sekiller_ListChanged(object sender, ListChangedEventArgs e)
        {
            pnlCizim.Refresh();
        }

        private void pboRenk_Click(object sender, EventArgs e)
        {
            cdiRenk.ShowDialog();
            pboRenk.BackColor = cdiRenk.Color;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sekil yeni;
            if (cboTur.SelectedIndex == 0)
                yeni = new Dikdortgen();
            else
                yeni = new Elips();
            yeni.X = (int)nudX.Value;
            yeni.Y = (int)nudY.Value;
            yeni.Genislik = (int)nudGen.Value;
            yeni.Yukseklik = (int)nudYuk.Value;
            yeni.Renk = pboRenk.BackColor;
            btnGuncelle.Enabled = false;
            sekiller.Add(yeni);
        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            foreach (Sekil sekil in sekiller)
            {
                sekil.Ciz(e.Graphics);
            }
        }

        private void lstSekiller_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstSekiller.SelectedIndex != -1)
            {
                sekiller.Remove(lstSekiller.SelectedItem as Sekil);
            }
        }

        private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sekiller.Clear();
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            Sekil temp;
            int seciliIndex = lstSekiller.SelectedIndex;
            if (seciliIndex > 0)
            {
                temp = sekiller[seciliIndex];
                sekiller[seciliIndex] = sekiller[seciliIndex - 1];
                sekiller[seciliIndex - 1] = temp;
                lstSekiller.SelectedIndex = seciliIndex - 1;
            }

        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            Sekil temp;
            int seciliIndex = lstSekiller.SelectedIndex;
            if (seciliIndex < sekiller.Count - 1 && seciliIndex > -1)
            {
                temp = sekiller[seciliIndex];
                sekiller[seciliIndex] = sekiller[seciliIndex + 1];
                sekiller[seciliIndex + 1] = temp;
                lstSekiller.SelectedIndex = seciliIndex + 1;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var jset = JsonConvert.SerializeObject(sekiller, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText("veri.json", jset);
        }


        private void pnlCizim_MouseClick(object sender, MouseEventArgs e)
        {
            nudX.Value = e.Location.X;
            nudY.Value = e.Location.Y;
        }

        private void lstSekiller_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            Sekil seciliSekil = (Sekil)lstSekiller.SelectedItem;
            if (durum)
            {
                nudX.Value = seciliSekil.X;
                nudY.Value = seciliSekil.Y;
                nudGen.Value = seciliSekil.Genislik;
                nudYuk.Value = seciliSekil.Yukseklik;
                pboRenk.BackColor = seciliSekil.Renk;
                btnGuncelle.Enabled = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            Sekil seciliSekil = (Sekil)lstSekiller.SelectedItem;
            seciliSekil.X = (int)nudX.Value;
            seciliSekil.Y = (int)nudY.Value;
            seciliSekil.Renk = pboRenk.BackColor;
            seciliSekil.Genislik = (int)nudGen.Value;
            seciliSekil.Yukseklik = (int)nudYuk.Value;
            //seciliSekil.Tur = cboTur.SelectedItem; // Tur abstract olduğu için sonrasında değişemedim.
            sekiller[sid] = seciliSekil;
        }

        private void lstSekiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = false;
        }

        private void JPEGYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdJpeg.Filter = "JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png";
            sfdJpeg.ShowDialog();
            string path = sfdJpeg.FileName;
            try
            {
                using (var bmp = new Bitmap(pnlCizim.Width, pnlCizim.Height))
                {
                    pnlCizim.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(path);
                }
                MessageBox.Show("Kayıt Başarılı!");
            }
            catch
            {
                MessageBox.Show("Hata, JPEG olarak kaydedilemedi.");
            }
        }

        private void nasılÇalışırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şekli güncellemek için ilgili şekle listeden çift tıklayınız.\r\nŞekil bilgileri, ilgili alanlar ile doldurulacaktır ve güncelle butonu aktif hale gelecektir.\r\nYeni değerleri girdikten sonra güncelleme yapabilirsiniz.\r\n\r\nŞekile çift tıkladığınızda panel üzerinden fare ile tıklayarak ilgili noktayı seçip güncelle dediğinizde şekli işaretli yere taşıyabilirsiniz.");
        }
    }
}
