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
    public partial class Formchekout1 : Form
    {
        public Formchekout1()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";
        public static string unit_no = "";
        public static string psewa_no = "";
        int count = 1;
        private void btncheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBooking d = new FormBooking();
            d.ShowDialog();
        }

        private void Formchekout1_Load(object sender, EventArgs e)
        {
            DataTable beli2 = new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlQuery = "select * from pengguna where USER_ID='" + FormLogin.id_user + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(beli2);
            Tboxfullname.Text = beli2.Rows[0]["user_fullname"].ToString();
            tboxphone.Text = beli2.Rows[0]["user_phoneno"].ToString();
            tboxtotalprice.Text = FormBooking.total;
            tboxtime.Text = FormBooking.time;
            tboxstart.Text = FormBooking.startdate;
            tboxcategory.Text = FormBooking.catergoty;
            if (tboxcategory.Text == "Tiny Warehouse")
            {
                DataTable beli1 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "SELECT u.unit_no as `unit`, k.psewa_no as `no` FROM `unit` u, `kategori_sewa` k WHERE u.psewa_no=k.psewa_no  and unit_status=0 and unit_no like 'T%' order by 1 limit 1";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli1);
                if (beli1.Rows.Count != 0)
                {
                    tboxunit.Text = beli1.Rows[0]["unit"].ToString();
                    psewa_no = beli1.Rows[0]["no"].ToString();
                }
                else
                {
                    MessageBox.Show("Please choose another warehouse!", "Warehouse Full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    Formpembelian d = new Formpembelian();
                    d.ShowDialog();
                }

            }
            else if (tboxcategory.Text == "Normal Warehouse")
            {
                DataTable beli1 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "SELECT u.unit_no as `unit`, k.psewa_no as `no` FROM `unit` u, `kategori_sewa` k WHERE u.psewa_no=k.psewa_no  and unit_status=0 and unit_no like 'N%' order by 1 limit 1";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli1);
                if (beli1.Rows.Count != 0)
                {
                    tboxunit.Text = beli1.Rows[0]["unit"].ToString();
                     psewa_no = beli1.Rows[0]["no"].ToString();
                }
                /*  else
                  {
                      MessageBox.Show("Please choose another warehouse!", "Warehouse Full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      this.Hide();
                      Formpembelian d = new Formpembelian();
                      d.ShowDialog();
                  }*/

            }
            else if (tboxcategory.Text == "Large Warehouse")
            {
                DataTable beli1 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "SELECT u.unit_no as `unit`, k.psewa_no as `no` FROM `unit` u, `kategori_sewa` k WHERE u.psewa_no=k.psewa_no  and unit_status=0 and unit_no like 'L%' order by 1 limit 1";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli1);
                if (beli1.Rows.Count != 0)
                {
                    tboxunit.Text = beli1.Rows[0]["unit"].ToString();
                    psewa_no = beli1.Rows[0]["no"].ToString();

                }
              /*  else
                {
                    MessageBox.Show("Please choose another warehouse!", "Warehouse Full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    Formpembelian d = new Formpembelian();
                    d.ShowDialog();
                }*/

            }
            else
            {
                DataTable beli1 = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "SELECT u.unit_no as `unit`, k.psewa_no as `no` FROM `unit` u, `kategori_sewa` k WHERE u.psewa_no=k.psewa_no  and unit_status=0 and unit_no like 'X%' order by 1 limit 1";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(beli1);
                if(beli1.Rows.Count!=0)
                {
                    tboxunit.Text = beli1.Rows[0]["unit"].ToString();
                    psewa_no = beli1.Rows[0]["no"].ToString();
                }
          /*      else
                {
                    MessageBox.Show("Please choose another warehouse!", "Warehouse Full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    Formpembelian d = new Formpembelian();
                    d.ShowDialog();
                }*/
             

            }

        }

        private void btncheckout_Click_1(object sender, EventArgs e)
        {

                DialogResult result = MessageBox.Show("Are You Sure to Checkout?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "update unit set unit_status=1 where unit_no='" + tboxunit.Text + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    unit_no = tboxunit.Text;
                    this.Hide();
                    FormInvoice d = new FormInvoice();
                    d.ShowDialog();
                }
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBooking d = new FormBooking();
            d.ShowDialog();
        }
    }
}
