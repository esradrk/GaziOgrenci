using okulAppModel;
using Okulapp.BLL;
using Okulapp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using okulAppModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace haftadokuz
{
    public partial class FrmOgretmenkayit : Form
    {
        public FrmOgretmenkayit()
        {
            InitializeComponent();

        }
    
        private void ogrkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl2 = new OgretmenBL();
                bool sonuc = obl2.Ogretmenekle(new Ogretmen { Ad = txtograd.Text.Trim(), Soyad = txtogrsoyad.Text.Trim(), TC = txtogrtc.Text.Trim() });
                MessageBox.Show(sonuc ? "ekleme başarılı" : "ekleme başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
               {
                   case 2627:
                        MessageBox.Show("Bu numara daha önce girilmiş!");
                        break;
                  default:
                        MessageBox.Show($"SQL Hatası Numarası: {ex.Number}");
                     break;
              }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu!!");
                throw;
            }
        }

       
    }

}
