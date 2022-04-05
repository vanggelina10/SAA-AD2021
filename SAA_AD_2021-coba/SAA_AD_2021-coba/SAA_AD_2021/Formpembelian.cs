using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SAA_AD_2021
{
    public partial class Formpembelian : Form
    {
        public Formpembelian()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";
        public static string category1 = "";
        public static string category2 = "";
        public static string category3 = "";
        public static string category4 = "";
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Formpembelian_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable beli1 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select * from kategori_sewa where PSEWA_NO='T0000' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli1);
                lblcategory1.Text = beli1.Rows[0]["PSEWA_NAME"].ToString();
                lblharga1.Text = beli1.Rows[0]["PSEWA_PRICEMONTH"].ToString() + " /Month";
                lblluas1.Text = beli1.Rows[0]["PSEWA_LARGE"].ToString();
                category1 = beli1.Rows[0]["PSEWA_NO"].ToString();

                DataTable beli2 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select * from kategori_sewa where PSEWA_NO='N0000' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli2);
                lblcategory2.Text = beli2.Rows[0]["PSEWA_NAME"].ToString();
                lblharga2.Text = beli2.Rows[0]["PSEWA_PRICEMONTH"].ToString() + " /Month";
                lblluas2.Text = beli2.Rows[0]["PSEWA_LARGE"].ToString();
                category2 = beli2.Rows[0]["PSEWA_NO"].ToString();

                DataTable beli3 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select * from kategori_sewa where PSEWA_NO='L0000' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli3);
                lblcategory3.Text = beli3.Rows[0]["PSEWA_NAME"].ToString();
                lblharga3.Text = beli3.Rows[0]["PSEWA_PRICEMONTH"].ToString() + " /Month";
                lblluas3.Text = beli3.Rows[0]["PSEWA_LARGE"].ToString();
                category3 = beli3.Rows[0]["PSEWA_NO"].ToString();

                DataTable beli4 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select * from kategori_sewa where PSEWA_NO='X0000' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli4);
                lblcategory4.Text = beli4.Rows[0]["PSEWA_NAME"].ToString();
                lblharga4.Text = beli4.Rows[0]["PSEWA_PRICEMONTH"].ToString() + " /Month";
                lblluas4.Text = beli4.Rows[0]["PSEWA_LARGE"].ToString();
                category4 = beli4.Rows[0]["PSEWA_NO"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   
        }

        private void pnltampilan3_Click(object sender, EventArgs e)
        {
            category2 = "";
            category1 = "";
            category4 = "";
            this.Hide();
            FormBooking dash = new FormBooking();
            dash.ShowDialog(); ;
        }

        private void pnltampilan1_Click(object sender, EventArgs e)
        {
            category2 = "";
            category3 = "";
            category4 = "";
            this.Hide();
            FormBooking dash = new FormBooking();
            dash.ShowDialog();
        }

        private void pnltampilan2_Click(object sender, EventArgs e)
        {

            category1 = "";
            category3 = "";
            category4 = "";
            this.Hide();
            FormBooking dash = new FormBooking();
            dash.ShowDialog();
        }

        private void pnltampilan4_Click(object sender, EventArgs e)
        {
            category2 = "";
            category3 = "";
            category1 = "";
            this.Hide();
            FormBooking dash = new FormBooking();
            dash.ShowDialog();
        }

        private void pboxprofile_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard dash = new FormDashboard();
            dash.ShowDialog();
        }
    }
}
