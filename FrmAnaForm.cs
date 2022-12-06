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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtname.Text = "";
            txtlastname.Text = "";
            cmbcity.Text = "";
            mskmoney.Text = "";
            txtjob.Text = "";
            txtsicil.Text = "";
        }
        static string baglanti = "Data Source=DESKTOP-I22QC0P\\SQLEXPRESS;Initial Catalog=Personel_veri_tabani;Integrated Security=True\r\n";
        SqlConnection connect = new SqlConnection(baglanti)

;        private void button6_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr= new Frmİstatistik();
            fr.Show();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personel_veri_tabaniDataSet1.tbl_personel' table. You can move, or remove it, as needed.
            //this.tbl_personelTableAdapter.Fill(this.personel_veri_tabaniDataSet1.tbl_personel);
            // TODO: This line of code loads data into the 'personel_veri_tabaniDataSet.tbl_personel' table. You can move, or remove it, as needed.
            // form yüklenirken açılır...this.tbl_personelTableAdapter.Fill(this.personel_veri_tabaniDataSet.tbl_personel);

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.personel_veri_tabaniDataSet1.tbl_personel);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_personel (name,lastname,city,money,job) values (@adi,@soyadi,@sehir,@maas,@meslek)",connect);
            komut.Parameters.AddWithValue("@adi", txtname.Text);
            komut.Parameters.AddWithValue("@soyadi", txtlastname.Text);
            komut.Parameters.AddWithValue("@sehir", cmbcity.Text);
            komut.Parameters.AddWithValue("@maas", mskmoney.Text);
            komut.Parameters.AddWithValue("@meslek", txtjob.Text);
            komut.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kayıt Yapıldı");
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtsicil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtlastname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbcity.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskmoney.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtjob.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand delete=new SqlCommand("delete from tbl_personel where personel_id=@p1",connect);
            delete.Parameters.AddWithValue("@p1", txtsicil.Text);
            delete.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kayıt Silindi","Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand update = new SqlCommand("update tbl_personel set name=@adi,lastname=@soyadi,city=@sehir,money=@maas,job=@meslek where personel_id=@sicil", connect);
            update.Parameters.AddWithValue("@adi", txtname.Text);
            update.Parameters.AddWithValue("@soyadi", txtlastname.Text);
            update.Parameters.AddWithValue("@sehir", cmbcity.Text);
            update.Parameters.AddWithValue("@maas", mskmoney.Text);
            update.Parameters.AddWithValue("@meslek", txtjob.Text);
            update.Parameters.AddWithValue("@sicil", txtsicil.Text);         
            update.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Personel Bilgileri Güncellendi");
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frgrafik = new FrmGrafikler();
            frgrafik.Show();
        }
    }
}
