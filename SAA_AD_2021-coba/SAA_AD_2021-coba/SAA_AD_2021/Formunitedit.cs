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
    public partial class Formunitedit : Form
    {
        public Formunitedit()
        {
            InitializeComponent();
        }
      
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        Formadmin fLogin;
        public void init(Formunit f)
        {
            fLogin = f.fLogin;
        }
        public static bool update=true;

        private void Formunitedit_Load(object sender, EventArgs e)
        {

            btnupdate.Enabled = false;
            lblunitno.Text = Formunit.unit_number;
            DataTable dtPlayer = new DataTable();
         
            sqlQuery = "select user_fullname as `Renter Name`,psewa_name as `Warehouse Name`, unit_no as `Unit No`,TSEWA_TIME as `Duration`, t.tsewa_startdate as `Start Rent`,if(unit_status=1,'Rented','Available') as `Status` from  kategori_sewa k, pengguna p,unit u left join transaksi_sewa t on u.unit_no=t.TSEWA_UNITNO where p.USER_ID=t.USER_ID and k.psewa_no=u.PSEWA_NO and UNIT_STATUS=1 and unit_no='"+lblunitno.Text+"' order by `Status` desc";
            sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);

            lblname.Text = dtPlayer.Rows[0]["Renter Name"].ToString();
            lblcategory.Text = dtPlayer.Rows[0]["Warehouse Name"].ToString();
            lblduration.Text = dtPlayer.Rows[0]["Duration"].ToString();
            lblstartrent.Text = dtPlayer.Rows[0]["Start Rent"].ToString().Substring(0, 10); ;

        }

        private void rbtnrented_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnavailable_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnavailable.Checked==true)
            {
                btnupdate.Enabled = true;
            }
            else
            {
                btnupdate.Enabled = false;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
           Formunit check = new Formunit();
            check.ShowDialog();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            sqlQuery = "update unit set UNIT_STATUS = 0 where UNIT_NO = '"+lblunitno.Text+"'";
            sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Payment Update Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            update= false;
            this.Close();

        }
    }
}
