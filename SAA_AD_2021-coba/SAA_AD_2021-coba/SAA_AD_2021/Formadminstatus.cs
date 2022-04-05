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
    public partial class Formadminstatus : Form
    {
        public Formadminstatus()
        {
            InitializeComponent();
        }
     
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        Formadmin fLogin;
        public void init(Formadmintfhistoy f)
        {
            fLogin = f.fLogin;
        }
        public string a = "";
        DataTable dtPlayer = new DataTable();
        bool b ;
        public static bool update2 = true;

        private void Formadminstatus_Load(object sender, EventArgs e)
        {
            try
            {
                btnupdate.Enabled = false;
                lblno.Text = Formadmintfhistoy.invoice_noadmin;
              
              
                sqlQuery = "select TSEWA_NO as `No. Transaction`,TSEWA_DATENOW as `Transaction Date`,TSEWA_STARTDATE as `Start Rent`, psewa_name as `Category`,TSEWA_TIME as `Time Period`,TSEWA_PRICE as `Price`,TSEWA_UNITNO as `Unit Number`,if(TSEWA_STATUS=1,'Paid','Unpaid') as `Payment Status` from transaksi_sewa t, kategori_sewa k where t.PSEWA_NO=k.PSEWA_NO and TSEWA_NO='" + lblno.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayer);
              
                lblno.Text = dtPlayer.Rows[0]["No. Transaction"].ToString();
                lblcategory.Text = dtPlayer.Rows[0]["Category"].ToString();
                lbltimeperiod.Text = dtPlayer.Rows[0]["Time Period"].ToString();
                lbltotal.Text = dtPlayer.Rows[0]["Price"].ToString();
                lblunitno.Text = dtPlayer.Rows[0]["Unit Number"].ToString();

                lbltransdate.Text = dtPlayer.Rows[0]["Transaction Date"].ToString().Substring(0,10);
                lblrentstart.Text = dtPlayer.Rows[0]["Start Rent"].ToString().Substring(0, 10); ;
                if(dtPlayer.Rows[0]["Payment Status"].ToString()=="Paid")
                {
                    b = true;
                    rbtnpaid.Checked = true;
                }
                else
                {
                    rbtnunpaid.Checked = true;
                    b = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void rbtnpaid_CheckedChanged(object sender, EventArgs e)
        {
            if (b==true )
            {
                b = false;
                btnupdate.Enabled = true;
            }
            else
            {
                btnupdate.Enabled =false;
                b = true;
            }
           
        }
        private void rbtnunpaid_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(rbtnpaid.Checked==true)
            {
                sqlQuery = "UPDATE `transaksi_sewa` SET `TSEWA_STATUS` = '1' WHERE `transaksi_sewa`.`TSEWA_NO` = '"+lblno.Text+"'";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
              
                sqlCommand.ExecuteNonQuery();
                       
                MessageBox.Show("Payment Update Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                update2 = false;
                this.Close();
               
            }
            else
            {
                sqlQuery = "UPDATE `transaksi_sewa` SET `TSEWA_STATUS` = '0' WHERE `transaksi_sewa`.`TSEWA_NO` = '" + lblno.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
             
                sqlCommand.ExecuteNonQuery();
               
                
                MessageBox.Show("Payment Update Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                update2 = false;
                this.Close();
        
            }
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
