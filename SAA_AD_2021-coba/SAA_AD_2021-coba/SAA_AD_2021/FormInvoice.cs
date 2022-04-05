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
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            DataTable beli2 = new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlQuery = "select * from pengguna where USER_ID='" + FormLogin.id_user + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(beli2);
            lblname.Text = beli2.Rows[0]["user_fullname"].ToString();
            lbltotal.Text = FormBooking.total;
            lbltotal2.Text = FormBooking.total;
            lblstartdate.Text = FormBooking.startdate;
            string d = lblstartdate.Text;
            lblcategory.Text = FormBooking.catergoty;
            lbltime.Text = FormBooking.time;
            labelhour.Text = DateTime.Now.ToShortTimeString();
            lbldatenow.Text = DateTime.Now.ToString("yyyy-MM-dd");
            string a = lbldatenow.Text;
            string b = beli2.Rows[0]["user_id"].ToString();
            string auto = "";
            sqlConnect = new MySqlConnection(connectString);
            sqlQuery = "select * from transaksi_sewa";
            DataTable dtnamapengguna = new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtnamapengguna);
            int jumlahpengguna = dtnamapengguna.Rows.Count + 1;
            if (jumlahpengguna >= 10)
            {
                auto += "00";
                auto += jumlahpengguna.ToString();
            }
            else if (jumlahpengguna >= 100)
            {
                auto += "0";
                auto += jumlahpengguna.ToString();
            }
            else if (jumlahpengguna >= 1000)
            {
                auto += jumlahpengguna.ToString();
            }

            else
            {
                auto += "000";
                auto += jumlahpengguna.ToString();
            }
            string tanggal="";
            tanggal += a;
            tanggal += b;
            tanggal += auto;


            labelno.Text = tanggal;
            string phone = "";
            string c = FormBooking.phone;

            phone += auto;
            phone += c;
            labelva.Text = phone;
            string status = "Unpaid";
            labelstatus.Text = status;

            sqlQuery = "insert into transaksi_sewa values ('"+labelno.Text+ "', '3525083012010002', '"+FormLogin.id_user+"','"+Formchekout1.psewa_no+"' , '"+FormBooking.total+"','"+labelva.Text+"' ,'"+lbltime.Text+"', '"+Formchekout1.unit_no+"', '"+d+"', '"+a+"', '"+labelhour.Text.ToString()+"', '0', '0')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

         


        }
     
        private void btnhowtopay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPaymentMethod b = new FormPaymentMethod();
            b.ShowDialog();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Leave this Invoice?", "Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormDashboard b = new FormDashboard();
                b.ShowDialog();
            }
        }

     
    }
}
