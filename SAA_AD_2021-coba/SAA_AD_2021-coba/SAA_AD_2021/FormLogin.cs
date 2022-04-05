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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";
        public static string id_user = "";


        private void btnlogin_Click(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(connectString);
            string username = tboxusername.Text;
            string password = tboxpassword.Text;
            DataTable dtlogin = new DataTable();
            sqlQuery = "SELECT * FROM `pengguna` WHERE `user_name`=@user AND `user_password`=@pass";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            sqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.SelectCommand = sqlCommand;           
            sqlAdapter.Fill(dtlogin);
            //menyimpan id
   
            //Mengecek user ada apa tidak
            if (dtlogin.Rows.Count>0)
            {
                DataTable Pengguna = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select USER_ID,USER_NAME from pengguna where USER_NAME='" + tboxusername.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Pengguna);
                id_user = Pengguna.Rows[0]["USER_ID"].ToString();
               
                MessageBox.Show("Your Login is Succeed!", "Welcome to Kuyrental", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
               FormDashboard dash = new FormDashboard();
                dash.ShowDialog();
               
              
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
                    MessageBox.Show("Enter Your Username to Login!","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
            
        }

        private void lblsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister signup = new FormRegister();
            signup.ShowDialog();
        }

        private void llabeladmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Formadmin signup = new Formadmin();
            signup.ShowDialog();
        }
    }
}
