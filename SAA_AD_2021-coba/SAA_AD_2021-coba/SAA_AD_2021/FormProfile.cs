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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";
        DataTable beli1 = new DataTable();
        
        private void FormProfile_Load(object sender, EventArgs e)
        {
            btncancel.Visible = false;
            btnsaveatas.Visible = false;
            btnsavebawah.Visible = false;

            sqlConnect = new MySqlConnection(connectString);
            sqlQuery = "select USER_FULLNAME,USER_PASSWORD, user_name, USER_EMAIL, USER_PHONENO from pengguna where user_id='" + FormLogin.id_user+"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(beli1);
            tboxfullname.Text = beli1.Rows[0]["USER_FULLNAME"].ToString();
            tboxusername.Text = beli1.Rows[0]["user_name"].ToString();
            tboxemail.Text = beli1.Rows[0]["USER_EMAIL"].ToString();
            tboxphoneno.Text = beli1.Rows[0]["USER_PHONENO"].ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            btnchange.Enabled = false;
            btnback.Visible = false;
            btnedit.Visible = false;
            btncancel.Visible = true;
            btnsaveatas.Visible = true;
            tboxfullname.ReadOnly = false;
            tboxusername.ReadOnly = false;
            tboxemail.ReadOnly = false;
            tboxphoneno.ReadOnly = false;
            

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard d = new FormDashboard();
            d.ShowDialog();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (checkusername() == true)
            {
                MessageBox.Show("This Username is already exist, use another username!", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "UPDATE `pengguna` SET `USER_FULLNAME` = '" + tboxfullname.Text + "', `USER_NAME` = '" + tboxusername.Text + "', `USER_EMAIL` = '" + tboxemail.Text + "', `USER_PHONENO` = '" + tboxphoneno.Text + "' WHERE `pengguna`.`USER_ID` = '" + FormLogin.id_user + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Your profile has Been Updated Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btncancel.Visible = false;
                btnsaveatas.Visible = false;
                btnback.Visible = true;
                btnedit.Visible = true;
                btnchange.Enabled = true;
                tboxusername.ReadOnly = true;
                tboxemail.ReadOnly = true;
                tboxphoneno.ReadOnly = true;
                tboxphoneno.ReadOnly = true;
                this.Hide();
                FormProfile d = new FormProfile();
                d.ShowDialog();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {


            sqlConnect = new MySqlConnection(connectString);
            sqlQuery = "select USER_FULLNAME, user_name, USER_EMAIL, USER_PHONENO from pengguna where user_id='" + FormLogin.id_user + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(beli1);
            tboxfullname.Text = beli1.Rows[0]["USER_FULLNAME"].ToString();
            tboxusername.Text = beli1.Rows[0]["user_name"].ToString();
            tboxemail.Text = beli1.Rows[0]["USER_EMAIL"].ToString();
            tboxphoneno.Text = beli1.Rows[0]["USER_PHONENO"].ToString();
            btncancel.Visible = false;
            btnsaveatas.Visible = false;
            btnback.Visible = true;
            btnedit.Visible = true;
            btnchange.Enabled = true;
            btnsavebawah.Visible = false;
            btnedit.Enabled = true;
            tboxpassword.Enabled = false;
            tboxnew.Enabled = false;
            tboxfullname.ReadOnly = true;
            tboxusername.ReadOnly = true;
            tboxemail.ReadOnly = true;
            tboxphoneno.ReadOnly = true;
            tboxpassword.Text = "";
            tboxnew.Text = "";

        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            tboxpassword.Text = "";
            tboxnew.Text = "";
            btnedit.Enabled = false;
            btnsavebawah.Visible = true;
            tboxpassword.Enabled = true;
            tboxnew.Enabled = true;
            btncancel.Visible = true;
        }

        private void tboxfullname_TextChanged(object sender, EventArgs e)
        {
            if (tboxfullname.Text!= beli1.Rows[0]["USER_FULLNAME"].ToString()||tboxusername.Text!= beli1.Rows[0]["user_name"].ToString()||tboxemail.Text != beli1.Rows[0]["USER_EMAIL"].ToString()||tboxphoneno.Text != beli1.Rows[0]["USER_PHONENO"].ToString())
            {
                btnsaveatas.Enabled = true;
            }
            else
            {
                btnsaveatas.Enabled = false;
            }
        }

        private void tboxusername_TextChanged(object sender, EventArgs e)
        {
            if (tboxfullname.Text != beli1.Rows[0]["USER_FULLNAME"].ToString() || tboxusername.Text != beli1.Rows[0]["user_name"].ToString() || tboxemail.Text != beli1.Rows[0]["USER_EMAIL"].ToString() || tboxphoneno.Text != beli1.Rows[0]["USER_PHONENO"].ToString())
            {
                btnsaveatas.Enabled = true;
            }
            else
            {
                btnsaveatas.Enabled = false;
            }
        }

        private void tboxemail_TextChanged(object sender, EventArgs e)
        {
            if (tboxfullname.Text != beli1.Rows[0]["USER_FULLNAME"].ToString() || tboxusername.Text != beli1.Rows[0]["user_name"].ToString() || tboxemail.Text != beli1.Rows[0]["USER_EMAIL"].ToString() || tboxphoneno.Text != beli1.Rows[0]["USER_PHONENO"].ToString())
            {
                btnsaveatas.Enabled = true;
            }
            else
            {
                btnsaveatas.Enabled = false;
            }
        }

        private void tboxphoneno_TextChanged(object sender, EventArgs e)
        {
            if (tboxfullname.Text != beli1.Rows[0]["USER_FULLNAME"].ToString() || tboxusername.Text != beli1.Rows[0]["user_name"].ToString() || tboxemail.Text != beli1.Rows[0]["USER_EMAIL"].ToString() || tboxphoneno.Text != beli1.Rows[0]["USER_PHONENO"].ToString())
            {
                btnsaveatas.Enabled = true;
            }
            else
            {
                btnsaveatas.Enabled = false;
            }
        }

        private void tboxpassword_TextChanged(object sender, EventArgs e)
        {
  
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
        private void btnsavebawah_Click(object sender, EventArgs e)
        {
            if (tboxpassword.Text != beli1.Rows[0]["USER_PASSWORD"].ToString())
            {
               
                MessageBox.Show("Password Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tboxpassword.Text==""||tboxnew.Text=="")
            {
                MessageBox.Show("Enter Your Current Password or New Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "UPDATE `pengguna` SET `USER_PASSWORD` = '"+tboxnew.Text+"' WHERE `pengguna`.`USER_ID` = '"+FormLogin.id_user+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Your profile has Been Updated Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnedit.Enabled = true;
                btncancel.Visible = false;
                btnsaveatas.Visible = false;
                btnback.Visible = true;
                btnedit.Visible = true;
                btnchange.Enabled = true;
                btnsavebawah.Visible = false;
                tboxpassword.Enabled = false;
                tboxnew.Enabled = false;
                this.Hide();
                FormProfile d = new FormProfile();
                d.ShowDialog();

            }
         
       
        }
    }
}
