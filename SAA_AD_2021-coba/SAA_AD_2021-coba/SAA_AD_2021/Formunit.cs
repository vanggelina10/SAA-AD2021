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
    public partial class Formunit : Form
    {
        public Formunit()
        {
            InitializeComponent();
        }
       
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public static string unit_number = "";
       public Formadmin fLogin;
        public void init(FormadminDashboard f)
        {
            fLogin = f.fLogin;
        }

        private void Formunit_Load(object sender, EventArgs e)
        {

            DataTable dtPlayer = new DataTable();
            
            sqlQuery = "select user_fullname as `Renter Name`,psewa_name as `Warehouse Name`, unit_no as `Unit No`,TSEWA_TIME as `Duration`, t.tsewa_startdate as `Start Rent`,if(unit_status=1,'Rented','Available') as `Status` from  kategori_sewa k, pengguna p,unit u left join transaksi_sewa t on u.unit_no=t.TSEWA_UNITNO where p.USER_ID=t.USER_ID and k.psewa_no=u.PSEWA_NO and UNIT_STATUS=1 order by `Status` desc";
            sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            dgvunit.DataSource = dtPlayer;
            lblrows.Text = Convert.ToString(dtPlayer.Rows.Count) + " row(s)";


        }
        private void dgvunit_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            unit_number = dgvunit.Rows[e.RowIndex].Cells[2].Value.ToString();
            //this.Hide();
            Formunitedit f2 = new Formunitedit();
            f2.init(this);
            f2.ShowDialog();
            if (Formunitedit.update == false)
            {
                DataTable dtPlayer2 = new DataTable();
               
                sqlQuery = "select user_fullname as `Renter Name`,psewa_name as `Warehouse Name`, unit_no as `Unit No`,TSEWA_TIME as `Duration`, t.tsewa_startdate as `Start Rent`,if(unit_status=1,'Rented','Available') as `Status` from  kategori_sewa k, pengguna p,unit u left join transaksi_sewa t on u.unit_no=t.TSEWA_UNITNO where p.USER_ID=t.USER_ID and k.psewa_no=u.PSEWA_NO and UNIT_STATUS=1 order by `Status` desc";
                sqlCommand = new MySqlCommand(sqlQuery, fLogin.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayer2);
                dgvunit.DataSource = dtPlayer2;
                lblrows.Text = Convert.ToString(dtPlayer2.Rows.Count) + " row(s)";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            /*this.Hide();
            FormadminDashboard f2 = new FormadminDashboard();
            f2.ShowDialog();*/
        }

        private void dgvunit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
