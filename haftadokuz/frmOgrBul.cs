using Okulapp.BLL;
using okulAppModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haftadokuz
{
    public partial class frmOgrBul : Form
    {
        frmOgnKayit frm;
        OgrenciBL obl = OgrenciBL.Instance;

        public frmOgrBul(frmOgnKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci ogr = obl.OgrenciBul(txtNumara.Text.Trim());


                if (ogr != null)
                {

                    frm.txtad.Text = ogr.Ad;
                    frm.txtsoyad.Text = ogr.Soyad;
                    frm.txtno.Text = ogr.Numara;
                    frm.OgrenciId = ogr.OgrenciId;
                    frm.btnsil.Enabled = true;
                    frm.btnguncelle.Enabled = true;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı!!!");
                    frm.btnsil.Enabled = false;
                    frm.btnguncelle.Enabled = false;
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı Hatası!" + ex.Message);

            }

            catch (Exception)
            {

                throw;
            }

        }
    }
}
