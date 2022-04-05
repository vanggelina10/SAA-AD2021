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
    public partial class Formadmin : Form
    {
        public Formadmin()
        {
            InitializeComponent();
        }
        public MySqlConnection conn;
       public string sqlQuery = "";
        public static string id_admin = "";
        private void openDBConn()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //MessageBox.Show("Sukses Terkoneksi ke Database!");
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Formadmin_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin dash = new FormLogin();
            dash.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            openDBConn();

            string username = tboxusername.Text;
            string password = tboxpassword.Text;
            DataTable dtlogin = new DataTable();
            sqlQuery = "SELECT * FROM `pihak_warehouse` WHERE `PWAREHOUSE_USERNAME`=@user AND `PWAREHOUSE_PASSWORD`=@pass";
             MySqlCommand  sqlCommand = new MySqlCommand(sqlQuery, conn);
            sqlCommand.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            sqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dtlogin);
            //menyimpan id
     
            //Mengecek user ada apa tidak
            if (dtlogin.Rows.Count > 0)
            {
             
                DataTable Pengguna = new DataTable();
                
                sqlQuery = " SELECT `PWAREHOUSE_NIK`, `PWAREHOUSE_USERNAME` FROM pihak_warehouse WHERE `PWAREHOUSE_USERNAME`='" + tboxusername.Text+"' ";
                sqlCommand = new MySqlCommand(sqlQuery,conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Pengguna);
                id_admin = Pengguna.Rows[0]["PWAREHOUSE_NIK"].ToString();

                MessageBox.Show("Your Login is Succeed!", "Welcome Admin Kuyrental", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FormadminDashboard fMenu = new FormadminDashboard();
                this.Hide();
                fMenu.init(this);
                fMenu.ShowDialog();


            }
            //cek password dan username
            else
            {
                if (tboxusername.Text == "" && tboxpassword.Text == "")
                {
                    MessageBox.Show("Enter Your  Username and Password to Login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tboxusername.Text == "")
                {
                    MessageBox.Show("Enter Your Username to Login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tboxpassword.Text == "")
                {
                    MessageBox.Show("Enter Your Password to Login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Wrong Your Username or Password to Login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
