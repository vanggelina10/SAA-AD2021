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
    public partial class Formdeleteuser : Form
    {
        public Formdeleteuser()
        {
            InitializeComponent();
        }
       
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        Formadmin fLogin;
        public void init(FormadminDashboard f)
        {
            fLogin = f.fLogin;
        }
        public static bool update3 = true;
        bool b;

        private void Formdeleteuser_Load(object sender, EventArgs e)
        {
            
            try
            {
                btnsubmit.Enabled = false;
                lbluse_id.Text = FormadminDashboard.user_id2;
                DataTable dtPlayer = new DataTable();
              
                sqlQuery = "  SELECT `p`.`USER_ID` AS `ID User`, `p`.`USER_FULLNAME` AS `Nama`, CONCAT( COUNT(`t`.`USER_ID`),' Kali') AS `Jumlah Transaksi`, IF((`p`.`USER_DELETE` = 0), 'Activated','Blocked') AS `User Status` FROM (`pengguna` `p` LEFT JOIN `transaksi_sewa` `t` ON ((`p`.`USER_ID` = `t`.`USER_ID`))) where p.user_id = '"+lbluse_id.Text+"' GROUP BY `p`.`USER_ID` ORDER BY `Jumlah Transaksi` DESC , `Nama`";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayer);

                lblname.Text = dtPlayer.Rows[0]["Nama"].ToString();
                lbltransaction.Text = dtPlayer.Rows[0]["Jumlah Transaksi"].ToString();
               
                if (dtPlayer.Rows[0]["User Status"].ToString() == "Activated")
                {
                    b = true;
                    rbtnactiv.Checked = true;
                }
                else
                {
                    rbtnblock.Checked = true;
                    b = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rbtnactiv_CheckedChanged(object sender, EventArgs e)
        {
            if (b == true)
            {
                b = false;
                btnsubmit.Enabled = true;
            }
            else
            {
                btnsubmit.Enabled = false;
                b = true;
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (rbtnblock.Checked == true)
            {
                sqlQuery = "UPDATE `pengguna` SET `USER_DELETE` = '1' WHERE `pengguna`.`USER_ID` = '"+lbluse_id.Text+"'";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                update3 = false;
                this.Close();

            }
            else
            {
                sqlQuery = "UPDATE `pengguna` SET `USER_DELETE` = '0' WHERE `pengguna`.`USER_ID` = '" + lbluse_id.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                update3 = false;
                this.Close();

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
