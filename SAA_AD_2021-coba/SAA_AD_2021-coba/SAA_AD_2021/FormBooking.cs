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
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";
        int a=0, b=0, c=0, d=0;
        string coba1 = "";
        string coba2 = "";
        string coba3 = "";
        public static string startdate = "";
        public static string catergoty = "";
        public static string time = "";
        public static string total = "";
        public static string phone = "";
        public static string id_category = "";


        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (tboxtime.Text == "" )
            {
                MessageBox.Show("Please Select the Rental Time You Want!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Formchekout1 check = new Formchekout1();
                check.ShowDialog();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formpembelian check = new Formpembelian();
            check.ShowDialog();
        }

      

        private void FormBooking_Load(object sender, EventArgs e)
        {
            cboxweek.SelectedIndex = -1;
            cboxmonth.SelectedIndex = -1;
            cboxyear.SelectedIndex=-1;


            if (Formpembelian.category1 == "T0000")
            {
                DataTable beli1 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select * from kategori_sewa where PSEWA_NO='" + Formpembelian.category1 + "' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli1);
                tboxcategory.Text = beli1.Rows[0]["psewa_name"].ToString();
                nama_no();
                catergoty = tboxcategory.Text;
                id_category = "T0000";


            }
            else if (Formpembelian.category2 == "N0000")
            {
                DataTable beli1 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select * from kategori_sewa where PSEWA_NO='" + Formpembelian.category2 + "' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli1);
                tboxcategory.Text = beli1.Rows[0]["psewa_name"].ToString();
                nama_no();
                catergoty = tboxcategory.Text;
                id_category = "N0000";
            }
            else if (Formpembelian.category3 == "L0000")
            {
                DataTable beli1 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select * from kategori_sewa where PSEWA_NO='" + Formpembelian.category3 + "' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli1);
                tboxcategory.Text = beli1.Rows[0]["psewa_name"].ToString();
                nama_no();
                catergoty = tboxcategory.Text;
                id_category = "L0000";
            }
            else
            {
                DataTable beli1 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select * from kategori_sewa where PSEWA_NO='" + Formpembelian.category4 + "' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli1);
                tboxcategory.Text = beli1.Rows[0]["psewa_name"].ToString();
                nama_no();
                catergoty = tboxcategory.Text;
                id_category = "X0000";
            }
                startdate = DTPstartdate.Value.ToString("yyyy-MM-dd");
            
        }

      
        private void nama_no()
        {
                DataTable beli2 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select * from pengguna where USER_ID='" + FormLogin.id_user + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli2);
                tboxfullname.Text = beli2.Rows[0]["user_fullname"].ToString();
                tboxnumber.Text = beli2.Rows[0]["user_phoneno"].ToString();
            phone = tboxnumber.Text;
            
        }

        private void DTPstartdate_ValueChanged(object sender, EventArgs e)
        {
            startdate = DTPstartdate.Value.ToString("yyyy-MM-dd");
        }

        private void tboxtime_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            cboxweek.SelectedIndex = -1;
            cboxmonth.SelectedIndex = -1;
            cboxyear.SelectedIndex = -1;
            tboxtime.Text = "";
            tboxtotal.Text = "";
        }

        private void cboxday_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboxweek.Text != "")
            {
                coba1 = cboxweek.Text + " Minggu";
                a = Convert.ToInt32(cboxweek.Text);
                if (tboxcategory.Text == "Tiny Warehouse")
                {
                    a = a * 1500000;
                }
                else if (tboxcategory.Text == "Normal Warehouse")
                {
                    a = a * 2500000;
                }
                else if (tboxcategory.Text == "Large Warehouse")
                {
                    a = a * 3000000;
                }
                else
                {
                    a = a * 4500000;
                }
                d = a + b + c;
                tboxtotal.Text = d.ToString();
                tboxtime.Text = coba3 + coba2  + coba1;
                total = tboxtotal.Text;
                time = tboxtime.Text;
            }
            else 
            {
                coba1 = cboxweek.Text + "";
                a = 0;
                d = a + b + c;
                tboxtotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = tboxtotal.Text;
                time = tboxtime.Text;
            }
        }
        private void cboxmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxmonth.Text != "")
            {
                coba2 = cboxmonth.Text + " Bulan";
                b = Convert.ToInt32(cboxmonth.Text);
                if (tboxcategory.Text == "Tiny Warehouse")
                {
                    b = b * 5000000;
                }
                else if (tboxcategory.Text == "Normal Warehouse")
                {
                    b = b * 8000000;
                }
                else if (tboxcategory.Text == "Large Warehouse")
                {
                    b = b * 10000000;
                }
                else
                {
                    b = b * 15000000;
                }
                d = a + b + c;
                tboxtotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = tboxtotal.Text;
                time = tboxtime.Text;
            }
            else 
            {
                coba2 = cboxmonth.Text + "";
                b= 0;
                d = a + b + c;
                tboxtotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = tboxtotal.Text;
                time = tboxtime.Text;
            }
        }
        private void cboxyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxyear.Text != "")
            {
                coba3 = cboxyear.Text + " Tahun";
                c = Convert.ToInt32(cboxyear.Text);
                if (tboxcategory.Text == "Tiny Warehouse")
                {
                    c = c * 70000000;
                }
                else if (tboxcategory.Text == "Normal Warehouse")
                {
                    c = c * 90000000;
                }
                else if (tboxcategory.Text == "Large Warehouse")
                {
                    c = c * 110000000;
                }
                else
                {
                    c = c * 150000000;
                }
                d = a + b + c;
                tboxtotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = tboxtotal.Text;
                time = tboxtime.Text;
            }
            else
            {
                coba3 = cboxyear.Text + "";
                c = 0;
                d = a + b + c;
                tboxtotal.Text = d.ToString();
                tboxtime.Text = coba3 + " " + coba2 + " " + coba1;
                total = tboxtotal.Text;
                time = tboxtime.Text;
            }
        }
        
    }
}
