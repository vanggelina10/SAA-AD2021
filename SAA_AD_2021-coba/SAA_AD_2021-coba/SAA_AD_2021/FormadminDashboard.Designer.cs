
namespace SAA_AD_2021
{
    partial class FormadminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormadminDashboard));
            this.btntransferhitory = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnunit = new System.Windows.Forms.Button();
            this.gbPenjualan = new System.Windows.Forms.GroupBox();
            this.cbuser_id = new System.Windows.Forms.ComboBox();
            this.gbLaporan = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvreport = new System.Windows.Forms.DataGridView();
            this.cbJenisLaporan = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.tboxtime = new System.Windows.Forms.TextBox();
            this.tboxunit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.cboxyear = new System.Windows.Forms.ComboBox();
            this.cboxmonth = new System.Windows.Forms.ComboBox();
            this.cboxweek = new System.Windows.Forms.ComboBox();
            this.lblHargaSatuan = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.txtIDINV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbunit = new System.Windows.Forms.GroupBox();
            this.Dgvadd = new System.Windows.Forms.DataGridView();
            this.Btnadd2 = new System.Windows.Forms.Button();
            this.tboxunitadd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxcategori = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnaddd = new System.Windows.Forms.Button();
            this.gbPenjualan.SuspendLayout();
            this.gbLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).BeginInit();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.gbunit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvadd)).BeginInit();
            this.SuspendLayout();
            // 
            // btntransferhitory
            // 
            this.btntransferhitory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntransferhitory.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btntransferhitory.Location = new System.Drawing.Point(22, 12);
            this.btntransferhitory.Name = "btntransferhitory";
            this.btntransferhitory.Size = new System.Drawing.Size(182, 49);
            this.btntransferhitory.TabIndex = 1;
            this.btntransferhitory.Text = "Purchase History";
            this.btntransferhitory.UseVisualStyleBackColor = true;
            this.btntransferhitory.Click += new System.EventHandler(this.btntransferhitory_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogout.Location = new System.Drawing.Point(903, 21);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(88, 40);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnunit
            // 
            this.btnunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnunit.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnunit.Location = new System.Drawing.Point(581, 12);
            this.btnunit.Name = "btnunit";
            this.btnunit.Size = new System.Drawing.Size(144, 49);
            this.btnunit.TabIndex = 5;
            this.btnunit.Text = "Unit";
            this.btnunit.UseVisualStyleBackColor = true;
            this.btnunit.Click += new System.EventHandler(this.btnunit_Click);
            // 
            // gbPenjualan
            // 
            this.gbPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.gbPenjualan.Controls.Add(this.cbuser_id);
            this.gbPenjualan.Controls.Add(this.btnSave);
            this.gbPenjualan.Controls.Add(this.label16);
            this.gbPenjualan.Controls.Add(this.lblTotal);
            this.gbPenjualan.Controls.Add(this.gbDetail);
            this.gbPenjualan.Controls.Add(this.txtIDINV);
            this.gbPenjualan.Controls.Add(this.label11);
            this.gbPenjualan.Controls.Add(this.label6);
            this.gbPenjualan.Location = new System.Drawing.Point(95, 537);
            this.gbPenjualan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbPenjualan.Name = "gbPenjualan";
            this.gbPenjualan.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbPenjualan.Size = new System.Drawing.Size(973, 597);
            this.gbPenjualan.TabIndex = 10;
            this.gbPenjualan.TabStop = false;
            this.gbPenjualan.Text = "Sales";
            this.gbPenjualan.Visible = false;
            // 
            // cbuser_id
            // 
            this.cbuser_id.DisplayMember = "USERNAME";
            this.cbuser_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbuser_id.FormattingEnabled = true;
            this.cbuser_id.Location = new System.Drawing.Point(162, 86);
            this.cbuser_id.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbuser_id.Name = "cbuser_id";
            this.cbuser_id.Size = new System.Drawing.Size(307, 28);
            this.cbuser_id.TabIndex = 32;
            this.cbuser_id.ValueMember = "USERNAME";
            this.cbuser_id.SelectedIndexChanged += new System.EventHandler(this.cbuser_id_SelectedIndexChanged);
            // 
            // gbLaporan
            // 
            this.gbLaporan.BackColor = System.Drawing.Color.Transparent;
            this.gbLaporan.Controls.Add(this.btnsearch);
            this.gbLaporan.Controls.Add(this.textBox2);
            this.gbLaporan.Controls.Add(this.label2);
            this.gbLaporan.Controls.Add(this.btnfind);
            this.gbLaporan.Controls.Add(this.textBox1);
            this.gbLaporan.Controls.Add(this.label1);
            this.gbLaporan.Controls.Add(this.dgvreport);
            this.gbLaporan.Controls.Add(this.cbJenisLaporan);
            this.gbLaporan.Controls.Add(this.label18);
            this.gbLaporan.Location = new System.Drawing.Point(36, 21);
            this.gbLaporan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbLaporan.Name = "gbLaporan";
            this.gbLaporan.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbLaporan.Size = new System.Drawing.Size(792, 622);
            this.gbLaporan.TabIndex = 13;
            this.gbLaporan.TabStop = false;
            this.gbLaporan.Text = "Report";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(424, 105);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(76, 29);
            this.btnsearch.TabIndex = 35;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "";
            this.textBox2.AccessibleName = "";
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(230, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 26);
            this.textBox2.TabIndex = 34;
            this.textBox2.Tag = "";
            this.textBox2.Text = "ID User...";
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Detail User Transactions";
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(424, 58);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(76, 29);
            this.btnfind.TabIndex = 31;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(230, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 32;
            this.textBox1.Tag = "";
            this.textBox1.Text = "ID Warehouse...";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Find Warehouse";
            // 
            // dgvreport
            // 
            this.dgvreport.AllowUserToAddRows = false;
            this.dgvreport.AllowUserToDeleteRows = false;
            this.dgvreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreport.Location = new System.Drawing.Point(15, 195);
            this.dgvreport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvreport.Name = "dgvreport";
            this.dgvreport.ReadOnly = true;
            this.dgvreport.RowHeadersWidth = 51;
            this.dgvreport.RowTemplate.Height = 29;
            this.dgvreport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvreport.Size = new System.Drawing.Size(755, 378);
            this.dgvreport.TabIndex = 28;
            this.dgvreport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvreport_CellClick);
            // 
            // cbJenisLaporan
            // 
            this.cbJenisLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisLaporan.FormattingEnabled = true;
            this.cbJenisLaporan.Items.AddRange(new object[] {
            "Amount of warehouses",
            "Amount of warehouses rented",
            "Amount of user transactions"});
            this.cbJenisLaporan.Location = new System.Drawing.Point(70, 158);
            this.cbJenisLaporan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbJenisLaporan.Name = "cbJenisLaporan";
            this.cbJenisLaporan.Size = new System.Drawing.Size(290, 28);
            this.cbJenisLaporan.TabIndex = 27;
            this.cbJenisLaporan.SelectedIndexChanged += new System.EventHandler(this.cbJenisLaporan_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 20);
            this.label18.TabIndex = 26;
            this.label18.Text = "Type :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(692, 678);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 58);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(646, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 38);
            this.label16.TabIndex = 30;
            this.label16.Text = "TOTAL = Rp.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(663, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(33, 38);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "0";
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.tboxtime);
            this.gbDetail.Controls.Add(this.tboxunit);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.btnreset);
            this.gbDetail.Controls.Add(this.cboxyear);
            this.gbDetail.Controls.Add(this.cboxmonth);
            this.gbDetail.Controls.Add(this.cboxweek);
            this.gbDetail.Controls.Add(this.lblHargaSatuan);
            this.gbDetail.Controls.Add(this.lbl1);
            this.gbDetail.Controls.Add(this.btnClear);
            this.gbDetail.Controls.Add(this.btnAdd);
            this.gbDetail.Controls.Add(this.label15);
            this.gbDetail.Controls.Add(this.label13);
            this.gbDetail.Controls.Add(this.cbcategory);
            this.gbDetail.Controls.Add(this.label14);
            this.gbDetail.Controls.Add(this.dgvDetail);
            this.gbDetail.Location = new System.Drawing.Point(12, 122);
            this.gbDetail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbDetail.Size = new System.Drawing.Size(852, 548);
            this.gbDetail.TabIndex = 23;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "OBAT YANG DIBELI";
            // 
            // tboxtime
            // 
            this.tboxtime.Location = new System.Drawing.Point(118, 202);
            this.tboxtime.Name = "tboxtime";
            this.tboxtime.ReadOnly = true;
            this.tboxtime.Size = new System.Drawing.Size(264, 26);
            this.tboxtime.TabIndex = 41;
            // 
            // tboxunit
            // 
            this.tboxunit.Location = new System.Drawing.Point(118, 83);
            this.tboxunit.Name = "tboxunit";
            this.tboxunit.ReadOnly = true;
            this.tboxunit.Size = new System.Drawing.Size(100, 26);
            this.tboxunit.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Week";
            // 
            // btnreset
            // 
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Location = new System.Drawing.Point(502, 129);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(81, 32);
            this.btnreset.TabIndex = 36;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // cboxyear
            // 
            this.cboxyear.FormattingEnabled = true;
            this.cboxyear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboxyear.Location = new System.Drawing.Point(398, 132);
            this.cboxyear.Name = "cboxyear";
            this.cboxyear.Size = new System.Drawing.Size(76, 28);
            this.cboxyear.TabIndex = 35;
            this.cboxyear.SelectedIndexChanged += new System.EventHandler(this.cboxyear_SelectedIndexChanged_1);
            // 
            // cboxmonth
            // 
            this.cboxmonth.FormattingEnabled = true;
            this.cboxmonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cboxmonth.Location = new System.Drawing.Point(274, 132);
            this.cboxmonth.Name = "cboxmonth";
            this.cboxmonth.Size = new System.Drawing.Size(66, 28);
            this.cboxmonth.TabIndex = 34;
            this.cboxmonth.SelectedIndexChanged += new System.EventHandler(this.cboxmonth_SelectedIndexChanged_1);
            // 
            // cboxweek
            // 
            this.cboxweek.FormattingEnabled = true;
            this.cboxweek.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboxweek.Location = new System.Drawing.Point(153, 132);
            this.cboxweek.Name = "cboxweek";
            this.cboxweek.Size = new System.Drawing.Size(64, 28);
            this.cboxweek.TabIndex = 33;
            this.cboxweek.SelectedIndexChanged += new System.EventHandler(this.cboxweek_SelectedIndexChanged);
            // 
            // lblHargaSatuan
            // 
            this.lblHargaSatuan.AutoSize = true;
            this.lblHargaSatuan.Location = new System.Drawing.Point(507, 89);
            this.lblHargaSatuan.Name = "lblHargaSatuan";
            this.lblHargaSatuan.Size = new System.Drawing.Size(53, 20);
            this.lblHargaSatuan.TabIndex = 28;
            this.lblHargaSatuan.Text = "Harga";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(507, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(236, 20);
            this.lbl1.TabIndex = 28;
            this.lbl1.Text = "1 Warehouse Untuk 1 Checkout";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(734, 155);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(734, 72);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 75);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Duration :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Unit";
            // 
            // cbcategory
            // 
            this.cbcategory.DisplayMember = "nama_obat";
            this.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(118, 42);
            this.cbcategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(382, 28);
            this.cbcategory.TabIndex = 24;
            this.cbcategory.ValueMember = "JUDUL_EVENT";
            this.cbcategory.SelectedIndexChanged += new System.EventHandler(this.cbcategory_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Kategori :";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(6, 235);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 29;
            this.dgvDetail.Size = new System.Drawing.Size(820, 232);
            this.dgvDetail.TabIndex = 0;
            // 
            // txtIDINV
            // 
            this.txtIDINV.Enabled = false;
            this.txtIDINV.Location = new System.Drawing.Point(165, 42);
            this.txtIDINV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIDINV.Name = "txtIDINV";
            this.txtIDINV.ReadOnly = true;
            this.txtIDINV.Size = new System.Drawing.Size(272, 26);
            this.txtIDINV.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "User ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Invoice :";
            // 
            // gbunit
            // 
            this.gbunit.BackColor = System.Drawing.Color.Transparent;
            this.gbunit.Controls.Add(this.Dgvadd);
            this.gbunit.Controls.Add(this.gbLaporan);
            this.gbunit.Controls.Add(this.Btnadd2);
            this.gbunit.Controls.Add(this.tboxunitadd);
            this.gbunit.Controls.Add(this.label7);
            this.gbunit.Controls.Add(this.cboxcategori);
            this.gbunit.Controls.Add(this.label8);
            this.gbunit.Location = new System.Drawing.Point(77, 96);
            this.gbunit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbunit.Name = "gbunit";
            this.gbunit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbunit.Size = new System.Drawing.Size(882, 509);
            this.gbunit.TabIndex = 36;
            this.gbunit.TabStop = false;
            this.gbunit.Text = "Add Unit";
            // 
            // Dgvadd
            // 
            this.Dgvadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvadd.Location = new System.Drawing.Point(90, 155);
            this.Dgvadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgvadd.Name = "Dgvadd";
            this.Dgvadd.RowHeadersWidth = 62;
            this.Dgvadd.Size = new System.Drawing.Size(764, 266);
            this.Dgvadd.TabIndex = 46;
            // 
            // Btnadd2
            // 
            this.Btnadd2.BackColor = System.Drawing.Color.LightBlue;
            this.Btnadd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnadd2.Location = new System.Drawing.Point(90, 111);
            this.Btnadd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btnadd2.Name = "Btnadd2";
            this.Btnadd2.Size = new System.Drawing.Size(112, 35);
            this.Btnadd2.TabIndex = 45;
            this.Btnadd2.Text = "Add";
            this.Btnadd2.UseVisualStyleBackColor = false;
            this.Btnadd2.Click += new System.EventHandler(this.Btnadd2_Click);
            // 
            // tboxunitadd
            // 
            this.tboxunitadd.Location = new System.Drawing.Point(90, 69);
            this.tboxunitadd.Name = "tboxunitadd";
            this.tboxunitadd.ReadOnly = true;
            this.tboxunitadd.Size = new System.Drawing.Size(100, 26);
            this.tboxunitadd.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Unit :";
            // 
            // cboxcategori
            // 
            this.cboxcategori.DisplayMember = "nama_obat";
            this.cboxcategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxcategori.FormattingEnabled = true;
            this.cboxcategori.Location = new System.Drawing.Point(90, 28);
            this.cboxcategori.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboxcategori.Name = "cboxcategori";
            this.cboxcategori.Size = new System.Drawing.Size(382, 28);
            this.cboxcategori.TabIndex = 43;
            this.cboxcategori.ValueMember = "JUDUL_EVENT";
            this.cboxcategori.SelectedIndexChanged += new System.EventHandler(this.cboxcategori_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Kategori :";
            // 
            // btnreport
            // 
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnreport.Location = new System.Drawing.Point(403, 12);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(150, 49);
            this.btnreport.TabIndex = 11;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnsales
            // 
            this.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsales.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnsales.Location = new System.Drawing.Point(229, 12);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(153, 49);
            this.btnsales.TabIndex = 12;
            this.btnsales.Text = "Sales";
            this.btnsales.UseVisualStyleBackColor = true;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnaddd
            // 
            this.btnaddd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddd.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnaddd.Location = new System.Drawing.Point(748, 12);
            this.btnaddd.Name = "btnaddd";
            this.btnaddd.Size = new System.Drawing.Size(128, 49);
            this.btnaddd.TabIndex = 14;
            this.btnaddd.Text = "Add";
            this.btnaddd.UseVisualStyleBackColor = true;
            this.btnaddd.Click += new System.EventHandler(this.btnaddd_Click);
            // 
            // FormadminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 702);
            this.Controls.Add(this.gbunit);
            this.Controls.Add(this.btnaddd);
            this.Controls.Add(this.btnsales);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.gbPenjualan);
            this.Controls.Add(this.btnunit);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btntransferhitory);
            this.DoubleBuffered = true;
            this.Name = "FormadminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormadminDashboard";
            this.Load += new System.EventHandler(this.FormadminDashboard_Load);
            this.gbPenjualan.ResumeLayout(false);
            this.gbPenjualan.PerformLayout();
            this.gbLaporan.ResumeLayout(false);
            this.gbLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.gbunit.ResumeLayout(false);
            this.gbunit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvadd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btntransferhitory;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnunit;
        private System.Windows.Forms.GroupBox gbPenjualan;
        private System.Windows.Forms.ComboBox cbuser_id;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label lblHargaSatuan;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.TextBox txtIDINV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.GroupBox gbLaporan;
        private System.Windows.Forms.DataGridView dgvreport;
        private System.Windows.Forms.ComboBox cbJenisLaporan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ComboBox cboxyear;
        private System.Windows.Forms.ComboBox cboxmonth;
        private System.Windows.Forms.ComboBox cboxweek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxunit;
        private System.Windows.Forms.TextBox tboxtime;
        private System.Windows.Forms.Button btnaddd;
        private System.Windows.Forms.GroupBox gbunit;
        private System.Windows.Forms.DataGridView Dgvadd;
        private System.Windows.Forms.Button Btnadd2;
        private System.Windows.Forms.TextBox tboxunitadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxcategori;
        private System.Windows.Forms.Label label8;
    }
}