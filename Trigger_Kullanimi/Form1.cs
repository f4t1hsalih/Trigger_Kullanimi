using System.Data;
using System.Data.SqlClient;

namespace Trigger_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbTrigger;Integrated Security=True");

        private void DersListele()
        {
            con.Open();
            string komut = "select * from tbl_books";
            SqlCommand cmd = new SqlCommand(komut, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Temizle()
        {
            txtid.Clear();
            txtAd.Clear();
            txtYazar.Clear();
            txtSayfa.Clear();
            txtYayinevi.Clear();
            txtTur.Clear();
        }

        private void Sayac()
        {
            con.Open();
            string komut = "select * from tbl_counter";
            SqlCommand cmd = new SqlCommand(komut, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblToplamAdet.Text = dr[0].ToString();
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DersListele();
            Sayac();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            string komut = "insert into tbl_books (name,author,page,publisher,category) values (@p1,@p2,@p3,@p4,@p5)";
            SqlCommand cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtYazar.Text);
            cmd.Parameters.AddWithValue("@p3", txtSayfa.Text);
            cmd.Parameters.AddWithValue("@p4", txtYayinevi.Text);
            cmd.Parameters.AddWithValue("@p5", txtTur.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayýt Baþarýyla Yapýldý");
            Temizle();
            Sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYayinevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}