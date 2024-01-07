using Okulapp.BLL;
using okulAppModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace haftadokuz
{
    public partial class frmOgnKayit : Form
    {
            OgrenciBL obl = OgrenciBL.Instance;

        public int OgrenciId { get; set; }
        public frmOgnKayit()
        {
            InitializeComponent();

        }
      
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {

                bool sonuc = obl.ogrenciekle(new Ogrenci { Ad = txtad.Text.Trim(), Soyad = txtsoyad.Text.Trim(), Numara = txtno.Text.Trim() });
                MessageBox.Show(sonuc ? "ekleme başarılı" : "ekleme başarısız");
                txtad.Text = "";
                txtsoyad.Text = "";
                txtno.Text = "";
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha önce girilmiş!");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!");
                        break;
                }
            }
            catch (Exception)
            {
                throw;
                MessageBox.Show("Bir Hata Oluştu");
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmOgrBul(this);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(obl.OgrenciSil(OgrenciId) ? "Silme Başarılı" : "Silme Başarısız!!!!");
                txtad.Text = "";
                txtsoyad.Text = "";
                txtno.Text = "";
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(obl.OgrenciGuncelle(new Ogrenci
                {
                    Ad = txtad.Text.Trim(),
                    Soyad = txtsoyad.Text.Trim(),
                    Numara = txtno.Text.Trim(),
                    OgrenciId = OgrenciId
                }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
                txtad.Text = "";
                txtsoyad.Text = "";
                txtno.Text = "";
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}