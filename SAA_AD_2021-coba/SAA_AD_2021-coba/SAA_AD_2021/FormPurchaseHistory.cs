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
    public partial class FormPurchaseHistory : Form
    {
        public FormPurchaseHistory()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI4;";
        public static string noinvoice = "";
        private void FormPurchaseHistory_Load(object sender, EventArgs e)
        {

            DataTable dtPlayer = new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlQuery = "select TSEWA_NO as `Transaction Number`,TSEWA_VA as `Virtual Account`,TSEWA_CATEGORY as `Kategory`,TSEWA_TIME as `Time Period`,TSEWA_PRICE as `Price`,TSEWA_UNITNO as `Unit Number`,if(TSEWA_STATUS=1,'Paid','Unpaid') as `Payment Status` from transaksi_sewa where USER_ID='"+FormLogin.id_user+"'and TSEWA_DELETE=0";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            dgvtampilan.DataSource = dtPlayer;

            DataTable delete = new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlQuery = "select TSEWA_NO as `Transaction Number`,TSEWA_VA as `Virtual Account`,TSEWA_CATEGORY as `Category`,TSEWA_TIME as `TIme Period`,TSEWA_PRICE as `Price`,TSEWA_UNITNO as `Unit Number`,if(TSEWA_STATUS=1,'Paid','Unpaid') as `Payment Status` from transaksi_sewa where USER_ID='" + FormLogin.id_user+"'and TSEWA_DELETE=1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(delete);
            dgvdelete.DataSource = delete;
        }

        private void dgvtampilan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            noinvoice= dgvtampilan.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
            FormPurchasestatus f2 = new FormPurchasestatus();
            f2.ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard f2 = new FormDashboard();
            f2.ShowDialog();
        }
    }
}
