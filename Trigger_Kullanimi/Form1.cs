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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DersListele();
        }
    }
}