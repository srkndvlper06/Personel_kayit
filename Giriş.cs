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


namespace Personel_kayit
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        static string baglanti = "Data Source=DESKTOP-I22QC0P\\SQLEXPRESS;Initial Catalog=Personel_veri_tabani;Integrated Security=True\r\n";
        SqlConnection connect = new SqlConnection(baglanti);

        private void btngirisyap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btngirisyap_Click_1(object sender, EventArgs e)
        {          

        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut1 = new SqlCommand("select *from Tbl_yönetici where kullaniciAd=@user and sifre=@key", connect);
            komut1.Parameters.AddWithValue("@user", txtkullanıcı.Text);
            komut1.Parameters.AddWithValue("@key", txtsifre.Text);
            SqlDataReader dataReader = komut1.ExecuteReader();
            if (dataReader.Read())
            {
                FrmAnaForm frmAnaForm = new FrmAnaForm();
                frmAnaForm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Hatalı...!");
            }
            connect.Close();
        }
    }
}
