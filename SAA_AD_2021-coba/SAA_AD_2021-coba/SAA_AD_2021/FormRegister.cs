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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";

        private void btnregister_Click(object sender, EventArgs e)

        {

            if (tboxfullname.Text == "")
            {
                MessageBox.Show("Please Fill The Fullname First", "Error!");
            }
            else
            {
                string auto = "";

                sqlConnect = new MySqlConnection(connectString);

                auto += tboxfullname.Text.Substring(0, 1).ToUpper();

                sqlQuery = "select * from pengguna where user_fullname like'" + auto + "%'";
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




                if (tboxconfirm.Text == "" || tboxemail.Text == "" || tboxfullname.Text == "" || tboxpassword.Text == "" || tboxphoneno.Text == "" || tboxusername.Text == "")
                {
                    MessageBox.Show("some Textbox are not filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else if (tboxpassword.Text == tboxconfirm.Text)
                {

                    if (checkusername() && checkemail())
                    {
                        MessageBox.Show("This gmail & Username are already exist, use another Email & Username!", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (checkemail())
                    {
                        MessageBox.Show("This Email is already exist, use another Email!", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (checkusername())
                    {
                        MessageBox.Show("This Username is already exist, use another username!", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (tboxpassword.Text != "" || tboxusername.Text != "" || checkusername() || checkemail())
                    {
                        sqlQuery = "insert into pengguna values ('" + auto + "','" + tboxfullname.Text + "','" + tboxusername.Text + "','" + tboxemail.Text + "','" + tboxphoneno.Text.ToString() + "','" + tboxpassword.Text.ToString() + "',0)";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlConnect.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnect.Close();
                        MessageBox.Show("Account Created!", "Succed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FormLogin signup = new FormLogin();
                        signup.ShowDialog();
                    }

                }

                else
                {
                    MessageBox.Show("Password are Not Right!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public Boolean checkusername()
        {
            sqlConnect = new MySqlConnection(connectString);
            string username = tboxusername.Text;      
            DataTable dtlogin = new DataTable();
            sqlQuery = "SELECT * FROM `pengguna` WHERE `user_name`=@user";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.SelectCommand = sqlCommand;

            sqlAdapter.Fill(dtlogin);
            //Mengecek username ada apa tidak di database
            if (dtlogin.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
      public Boolean checkemail()
        {
            sqlConnect = new MySqlConnection(connectString);
            string gmail =tboxemail.Text;
            DataTable dtmail = new DataTable();
            sqlQuery = "SELECT * FROM `pengguna` WHERE `user_email`=@mail";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add("@mail", MySqlDbType.VarChar).Value = gmail;
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.SelectCommand = sqlCommand;

            sqlAdapter.Fill(dtmail);
            //Mengecek username ada apa tidak di database
            if (dtmail.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin dash = new FormLogin();
            dash.ShowDialog();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
