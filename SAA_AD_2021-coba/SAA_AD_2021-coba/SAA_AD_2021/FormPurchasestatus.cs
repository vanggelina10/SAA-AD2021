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
    public partial class FormPurchasestatus : Form
    {
        public FormPurchasestatus()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";
        private void FormPurchasestatus_Load(object sender, EventArgs e)
        {
            try
            {
                lblno.Text =FormPurchaseHistory.noinvoice;

                DataTable dtPlayer = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select TSEWA_NO,TSEWA_CATEGORY,TSEWA_TIME,TSEWA_PRICE,TSEWA_UNITNO,if(TSEWA_STATUS=1,'Paid','Unpaid') as `Payment Status` from transaksi_sewa where tsewa_no='"+lblno.Text+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayer);
                
                lblcategory.Text = dtPlayer.Rows[0]["TSEWA_CATEGORY"].ToString();
                lbltimeperiod.Text = dtPlayer.Rows[0]["TSEWA_TIME"].ToString();
                lbltotal.Text = dtPlayer.Rows[0]["TSEWA_PRICE"].ToString();
                lblunitno.Text = dtPlayer.Rows[0]["TSEWA_UNITNO"].ToString();
                lblpaymentstatus.Text = dtPlayer.Rows[0]["Payment Status"].ToString();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncalcel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Cancel Your Transaction?", "Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sqlQuery = "update transaksi_sewa set `TSEWA_DELETE`=1 where TSEWA_NO='" + lblno.Text+"'  ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();


                sqlQuery = "UPDATE `detail_transsewa` SET `TSEWA_PSEWA_DELETE` = '1' WHERE `detail_transsewa`.`TSEWA_NO` = '" + lblno.Text + "'  ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Your Transaction Has Been Cuccessfully Canceled!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                FormPurchaseHistory d = new FormPurchaseHistory();
                d.ShowDialog();

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchaseHistory d = new FormPurchaseHistory();
            d.ShowDialog();
        }
    }
}
