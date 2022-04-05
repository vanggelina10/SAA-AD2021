
namespace SAA_AD_2021
{
    partial class Formadminstatus
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lbltimeperiod = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblunitno = new System.Windows.Forms.Label();
            this.lblno = new System.Windows.Forms.Label();
            this.rbtnpaid = new System.Windows.Forms.RadioButton();
            this.rbtnunpaid = new System.Windows.Forms.RadioButton();
            this.lblrentstart = new System.Windows.Forms.Label();
            this.lbltransdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnback.Location = new System.Drawing.Point(111, 484);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(70, 41);
            this.btnback.TabIndex = 40;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnupdate.Location = new System.Drawing.Point(639, 484);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(179, 41);
            this.btnupdate.TabIndex = 39;
            this.btnupdate.Text = "Update Payment";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.BackColor = System.Drawing.Color.Transparent;
            this.lblcategory.Location = new System.Drawing.Point(635, 157);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(65, 20);
            this.lblcategory.TabIndex = 38;
            this.lblcategory.Text = "[............]";
            // 
            // lbltimeperiod
            // 
            this.lbltimeperiod.AutoSize = true;
            this.lbltimeperiod.BackColor = System.Drawing.Color.Transparent;
            this.lbltimeperiod.Location = new System.Drawing.Point(225, 240);
            this.lbltimeperiod.Name = "lbltimeperiod";
            this.lbltimeperiod.Size = new System.Drawing.Size(65, 20);
            this.lbltimeperiod.TabIndex = 37;
            this.lbltimeperiod.Text = "[............]";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Location = new System.Drawing.Point(635, 243);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(65, 20);
            this.lbltotal.TabIndex = 36;
            this.lbltotal.Text = "[............]";
            // 
            // lblunitno
            // 
            this.lblunitno.AutoSize = true;
            this.lblunitno.BackColor = System.Drawing.Color.Transparent;
            this.lblunitno.Location = new System.Drawing.Point(225, 324);
            this.lblunitno.Name = "lblunitno";
            this.lblunitno.Size = new System.Drawing.Size(65, 20);
            this.lblunitno.TabIndex = 35;
            this.lblunitno.Text = "[............]";
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.BackColor = System.Drawing.Color.Transparent;
            this.lblno.Location = new System.Drawing.Point(225, 149);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(65, 20);
            this.lblno.TabIndex = 33;
            this.lblno.Text = "[............]";
            // 
            // rbtnpaid
            // 
            this.rbtnpaid.AutoSize = true;
            this.rbtnpaid.BackColor = System.Drawing.Color.Transparent;
            this.rbtnpaid.Checked = true;
            this.rbtnpaid.Location = new System.Drawing.Point(584, 413);
            this.rbtnpaid.Name = "rbtnpaid";
            this.rbtnpaid.Size = new System.Drawing.Size(65, 24);
            this.rbtnpaid.TabIndex = 42;
            this.rbtnpaid.TabStop = true;
            this.rbtnpaid.Text = "Paid";
            this.rbtnpaid.UseVisualStyleBackColor = false;
            this.rbtnpaid.CheckedChanged += new System.EventHandler(this.rbtnpaid_CheckedChanged);
            // 
            // rbtnunpaid
            // 
            this.rbtnunpaid.AutoSize = true;
            this.rbtnunpaid.BackColor = System.Drawing.Color.Transparent;
            this.rbtnunpaid.Location = new System.Drawing.Point(683, 413);
            this.rbtnunpaid.Name = "rbtnunpaid";
            this.rbtnunpaid.Size = new System.Drawing.Size(85, 24);
            this.rbtnunpaid.TabIndex = 43;
            this.rbtnunpaid.TabStop = true;
            this.rbtnunpaid.Text = "Unpaid";
            this.rbtnunpaid.UseVisualStyleBackColor = false;
            this.rbtnunpaid.CheckedChanged += new System.EventHandler(this.rbtnunpaid_CheckedChanged);
            // 
            // lblrentstart
            // 
            this.lblrentstart.AutoSize = true;
            this.lblrentstart.BackColor = System.Drawing.Color.Transparent;
            this.lblrentstart.Location = new System.Drawing.Point(635, 325);
            this.lblrentstart.Name = "lblrentstart";
            this.lblrentstart.Size = new System.Drawing.Size(65, 20);
            this.lblrentstart.TabIndex = 49;
            this.lblrentstart.Text = "[............]";
            // 
            // lbltransdate
            // 
            this.lbltransdate.AutoSize = true;
            this.lbltransdate.BackColor = System.Drawing.Color.Transparent;
            this.lbltransdate.Location = new System.Drawing.Point(236, 413);
            this.lbltransdate.Name = "lbltransdate";
            this.lbltransdate.Size = new System.Drawing.Size(65, 20);
            this.lbltransdate.TabIndex = 47;
            this.lbltransdate.Text = "[............]";
            // 
            // Formadminstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources.Pink_and_Purple_Sporty_Gradient_Fitness_YouTube_Thumbnail__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.lblrentstart);
            this.Controls.Add(this.lbltransdate);
            this.Controls.Add(this.rbtnunpaid);
            this.Controls.Add(this.rbtnpaid);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lbltimeperiod);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblunitno);
            this.Controls.Add(this.lblno);
            this.DoubleBuffered = true;
            this.Name = "Formadminstatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formadminstatus";
            this.Load += new System.EventHandler(this.Formadminstatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lbltimeperiod;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblunitno;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.RadioButton rbtnpaid;
        private System.Windows.Forms.RadioButton rbtnunpaid;
        private System.Windows.Forms.Label lblrentstart;
        private System.Windows.Forms.Label lbltransdate;
    }
}