using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_kayit
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        static string baglanti = "Data Source=DESKTOP-I22QC0P\\SQLEXPRESS;Initial Catalog=Personel_veri_tabani;Integrated Security=True\r\n";
        SqlConnection connect = new SqlConnection(baglanti);
        private void Form2_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut= new SqlCommand("select count(*) from tbl_personel",connect);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                lbltoplampersonel.Text = dr[0].ToString();                
            }
            connect.Close();

            connect.Open();
            SqlCommand komut1 = new SqlCommand("select count (DISTINCT (city)) from tbl_personel",connect);
            SqlDataReader dr1=komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblsehir.Text = dr1[0].ToString();
            }
            connect.Close();

            connect.Open();
            SqlCommand komut2 = new SqlCommand("select sum(money) from tbl_personel", connect);
            SqlDataReader dr2=komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbltoplammaas.Text = dr2[0].ToString();
            }
            connect.Close();

            connect.Open();
            SqlCommand komut3 = new SqlCommand("select avg(money) from tbl_personel", connect);
            SqlDataReader dr3=komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblortalamamaas.Text = dr3[0].ToString();
            }
            connect.Close();
          
;        }
    }
}
