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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        static string baglanti = "Data Source=DESKTOP-I22QC0P\\SQLEXPRESS;Initial Catalog=Personel_veri_tabani;Integrated Security=True\r\n";
        SqlConnection connect = new SqlConnection(baglanti);
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komutg1 = new SqlCommand("select city,count (*) from tbl_personel group by city", connect);
            SqlDataReader dr1= komutg1.ExecuteReader();
            while(dr1.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            connect.Close();
            connect.Open();
            SqlCommand komutg2 = new SqlCommand("select job,avg(money)from tbl_personel group by job",connect);
            SqlDataReader dr2= komutg2.ExecuteReader();
            while(dr2.Read())
            {
                chart2.Series["Meslek-Maaş"].Points.AddXY(dr2[0], dr2[1]);
            }
            connect.Close();
        }
    }
}
