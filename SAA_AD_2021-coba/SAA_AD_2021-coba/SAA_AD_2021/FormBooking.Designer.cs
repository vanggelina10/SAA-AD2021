
namespace SAA_AD_2021
{
    partial class FormBooking
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
            this.DTPstartdate = new System.Windows.Forms.DateTimePicker();
            this.tboxtime = new System.Windows.Forms.TextBox();
            this.cboxweek = new System.Windows.Forms.ComboBox();
            this.cboxmonth = new System.Windows.Forms.ComboBox();
            this.cboxyear = new System.Windows.Forms.ComboBox();
            this.tboxtotal = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.tboxnumber = new System.Windows.Forms.TextBox();
            this.tboxfullname = new System.Windows.Forms.TextBox();
            this.tboxcategory = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTPstartdate
            // 
            this.DTPstartdate.Location = new System.Drawing.Point(78, 347);
            this.DTPstartdate.Name = "DTPstartdate";
            this.DTPstartdate.Size = new System.Drawing.Size(217, 26);
            this.DTPstartdate.TabIndex = 13;
            this.DTPstartdate.ValueChanged += new System.EventHandler(this.DTPstartdate_ValueChanged);
            // 
            // tboxtime
            // 
            this.tboxtime.Location = new System.Drawing.Point(335, 409);
            this.tboxtime.Name = "tboxtime";
            this.tboxtime.ReadOnly = true;
            this.tboxtime.Size = new System.Drawing.Size(217, 26);
            this.tboxtime.TabIndex = 16;
            this.tboxtime.TextChanged += new System.EventHandler(this.tboxtime_TextChanged);
            // 
            // cboxweek
            // 
            this.cboxweek.FormattingEnabled = true;
            this.cboxweek.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboxweek.Location = new System.Drawing.Point(379, 339);
            this.cboxweek.Name = "cboxweek";
            this.cboxweek.Size = new System.Drawing.Size(64, 28);
            this.cboxweek.TabIndex = 20;
            this.cboxweek.SelectedIndexChanged += new System.EventHandler(this.cboxday_SelectedIndexChanged);
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
            this.cboxmonth.Location = new System.Drawing.Point(528, 339);
            this.cboxmonth.Name = "cboxmonth";
            this.cboxmonth.Size = new System.Drawing.Size(66, 28);
            this.cboxmonth.TabIndex = 21;
            this.cboxmonth.SelectedIndexChanged += new System.EventHandler(this.cboxmonth_SelectedIndexChanged);
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
            this.cboxyear.Location = new System.Drawing.Point(666, 339);
            this.cboxyear.Name = "cboxyear";
            this.cboxyear.Size = new System.Drawing.Size(76, 28);
            this.cboxyear.TabIndex = 22;
            this.cboxyear.SelectedIndexChanged += new System.EventHandler(this.cboxyear_SelectedIndexChanged);
            // 
            // tboxtotal
            // 
            this.tboxtotal.Location = new System.Drawing.Point(78, 409);
            this.tboxtotal.Name = "tboxtotal";
            this.tboxtotal.ReadOnly = true;
            this.tboxtotal.Size = new System.Drawing.Size(172, 26);
            this.tboxtotal.TabIndex = 24;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Khaki;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Location = new System.Drawing.Point(692, 454);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(152, 43);
            this.btnsubmit.TabIndex = 25;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Khaki;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(58, 486);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(110, 43);
            this.btnback.TabIndex = 26;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tboxnumber
            // 
            this.tboxnumber.Location = new System.Drawing.Point(466, 179);
            this.tboxnumber.Name = "tboxnumber";
            this.tboxnumber.ReadOnly = true;
            this.tboxnumber.Size = new System.Drawing.Size(178, 26);
            this.tboxnumber.TabIndex = 8;
            // 
            // tboxfullname
            // 
            this.tboxfullname.Location = new System.Drawing.Point(113, 179);
            this.tboxfullname.Name = "tboxfullname";
            this.tboxfullname.ReadOnly = true;
            this.tboxfullname.Size = new System.Drawing.Size(217, 26);
            this.tboxfullname.TabIndex = 7;
            // 
            // tboxcategory
            // 
            this.tboxcategory.Location = new System.Drawing.Point(113, 243);
            this.tboxcategory.Name = "tboxcategory";
            this.tboxcategory.ReadOnly = true;
            this.tboxcategory.Size = new System.Drawing.Size(193, 26);
            this.tboxcategory.TabIndex = 28;
            // 
            // btnreset
            // 
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Location = new System.Drawing.Point(782, 339);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(81, 32);
            this.btnreset.TabIndex = 29;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources.bookingform2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.tboxcategory);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tboxtotal);
            this.Controls.Add(this.cboxyear);
            this.Controls.Add(this.cboxmonth);
            this.Controls.Add(this.cboxweek);
            this.Controls.Add(this.tboxtime);
            this.Controls.Add(this.DTPstartdate);
            this.Controls.Add(this.tboxnumber);
            this.Controls.Add(this.tboxfullname);
            this.Name = "FormBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBooking";
            this.Load += new System.EventHandler(this.FormBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DTPstartdate;
        private System.Windows.Forms.TextBox tboxtime;
        private System.Windows.Forms.ComboBox cboxweek;
        private System.Windows.Forms.ComboBox cboxmonth;
        private System.Windows.Forms.ComboBox cboxyear;
        private System.Windows.Forms.TextBox tboxtotal;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox tboxnumber;
        private System.Windows.Forms.TextBox tboxfullname;
        private System.Windows.Forms.TextBox tboxcategory;
        private System.Windows.Forms.Button btnreset;
    }
}