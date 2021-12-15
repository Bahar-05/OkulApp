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

namespace OkulApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=true;");

            cn.Open();
            SqlCommand cmd = new SqlCommand($"Insert into Ogrenciler (Ad,Soyad,Numara,SinifId) values('{txtAd.Text}','{txtSoyad.Text}',{txtNumara.Text},{txtSinif.Text})", cn);
            

            int sonuc = cmd.ExecuteNonQuery();
            MessageBox.Show(sonuc > 0 ? "İşlem Başarılı " : "Başarısız");
            cn.Close();
        }
    }
}
