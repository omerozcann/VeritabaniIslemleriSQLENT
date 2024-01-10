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

namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        HesaplarEntities he = new HesaplarEntities();
        int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Server=localhost\\sqlexpress;Database=Hesaplar;Trusted_Connection=True;";
                conn.Open();
                String sql = "insert into kullanici(kullaniciadi,eposta,parola,rol) values('" + kullanicitxt.Text + "','" + epostatxt.Text + "','" + parolatxt.Text + "','" + rolcmb.Text + "')";
                SqlCommand scom = new SqlCommand();
                scom.Connection = conn;
                scom.CommandText = sql;
                scom.ExecuteNonQuery();
                MessageBox.Show("Kaydedildi");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }         
        }

        private void kaydetEbtn_Click(object sender, EventArgs e)
        {
            kullanici kullanici = new kullanici();
            kullanici.kullaniciadi = kullanicitxt.Text;
            kullanici.eposta = epostatxt.Text;
            kullanici.parola = parolatxt.Text;
            kullanici.rol = rolcmb.Text;
            he.kullanici.Add(kullanici);       
            he.SaveChanges();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=localhost\\sqlexpress;Database=Hesaplar;Trusted_Connection=True;";
            conn.Open();
            DataTable dt=new DataTable();
            String sql = "select * from kullanici";
            SqlDataAdapter sda=new SqlDataAdapter(sql, conn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void listeleEbtn_Click(object sender, EventArgs e)
        {
            var sonuclar = he.kullanici.ToList();
            dataGridView1.DataSource = sonuclar;
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=localhost\\sqlexpress;Database=Hesaplar;Trusted_Connection=True;";
            conn.Open();
            String sql = "delete from kullanici where kullaniciadi='"+kullanicitxt.Text+"' or eposta='"+epostatxt.Text+"'";
            SqlCommand scom = new SqlCommand();
            scom.Connection = conn;
            scom.CommandText = sql;
            int sonuc=scom.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt Silindi");
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı");
            }
        }

        private void silebtn_Click(object sender, EventArgs e)
        {
            var kayit = he.kullanici.Where(a => a.kullaniciadi == kullanicitxt.Text || a.eposta == epostatxt.Text).FirstOrDefault();
            he.kullanici.Remove(kayit);
            he.SaveChanges();
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=localhost\\sqlexpress;Database=Hesaplar;Trusted_Connection=True;";
            conn.Open();
            String sql = "update kullanici set kullaniciadi='"+kullanicitxt.Text+"',eposta='"+epostatxt.Text+"',parola='"+parolatxt.Text+"',rol='"+rolcmb.Text+"' where id="+id;
            SqlCommand scom = new SqlCommand();
            scom.Connection = conn;
            scom.CommandText = sql;
            scom.ExecuteNonQuery();
            MessageBox.Show("Güncellendi");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
            kullanicitxt.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
            epostatxt.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString();
            parolatxt.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
            rolcmb.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value.ToString();

        }

        private void guncelleebtn_Click(object sender, EventArgs e)
        {
            var kayit = he.kullanici.Where(a => a.id==id).FirstOrDefault();
            kayit.kullaniciadi = kullanicitxt.Text;
            kayit.eposta=epostatxt.Text;
            kayit.parola = parolatxt.Text;
            kayit.rol=rolcmb.Text;  
            he.Entry(kayit).State=System.Data.Entity.EntityState.Modified;
            he.SaveChanges();
        }
    }
}
