
namespace SAA_AD_2021
{
    partial class FormDashboard
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
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnstorage = new System.Windows.Forms.Button();
            this.btnContactus = new System.Windows.Forms.Button();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.pboxprofile = new System.Windows.Forms.PictureBox();
            this.Btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBooking
            // 
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBooking.Location = new System.Drawing.Point(319, 210);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(293, 54);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.Text = "Booking Now";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnstorage
            // 
            this.btnstorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstorage.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstorage.Location = new System.Drawing.Point(319, 286);
            this.btnstorage.Name = "btnstorage";
            this.btnstorage.Size = new System.Drawing.Size(293, 54);
            this.btnstorage.TabIndex = 1;
            this.btnstorage.Text = "Store Unit and  Price";
            this.btnstorage.UseVisualStyleBackColor = true;
            this.btnstorage.Click += new System.EventHandler(this.btnstorage_Click);
            // 
            // btnContactus
            // 
            this.btnContactus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactus.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnContactus.Location = new System.Drawing.Point(319, 446);
            this.btnContactus.Name = "btnContactus";
            this.btnContactus.Size = new System.Drawing.Size(293, 54);
            this.btnContactus.TabIndex = 2;
            this.btnContactus.Text = "Contact Us";
            this.btnContactus.UseVisualStyleBackColor = true;
            this.btnContactus.Click += new System.EventHandler(this.btnContactus_Click);
            // 
            // btnpurchase
            // 
            this.btnpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurchase.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchase.Location = new System.Drawing.Point(319, 369);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(293, 54);
            this.btnpurchase.TabIndex = 4;
            this.btnpurchase.Text = "Purchase History";
            this.btnpurchase.UseVisualStyleBackColor = true;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // pboxprofile
            // 
            this.pboxprofile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxprofile.Image = global::SAA_AD_2021.Properties.Resources.depositphotos_39258143_stock_illustration_businessman_avatar_profile_picture;
            this.pboxprofile.Location = new System.Drawing.Point(50, 24);
            this.pboxprofile.Name = "pboxprofile";
            this.pboxprofile.Size = new System.Drawing.Size(59, 50);
            this.pboxprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxprofile.TabIndex = 16;
            this.pboxprofile.TabStop = false;
            this.pboxprofile.Click += new System.EventHandler(this.pboxprofile_Click);
            // 
            // Btnlogout
            // 
            this.Btnlogout.BackColor = System.Drawing.Color.Red;
            this.Btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlogout.ForeColor = System.Drawing.Color.Snow;
            this.Btnlogout.Location = new System.Drawing.Point(762, 24);
            this.Btnlogout.Name = "Btnlogout";
            this.Btnlogout.Size = new System.Drawing.Size(122, 35);
            this.Btnlogout.TabIndex = 17;
            this.Btnlogout.Text = "Logout";
            this.Btnlogout.UseVisualStyleBackColor = false;
            this.Btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.Btnlogout);
            this.Controls.Add(this.pboxprofile);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.btnContactus);
            this.Controls.Add(this.btnstorage);
            this.Controls.Add(this.btnBooking);
            this.DoubleBuffered = true;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxprofile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnstorage;
        private System.Windows.Forms.Button btnContactus;
        private System.Windows.Forms.Button btnpurchase;
        private System.Windows.Forms.PictureBox pboxprofile;
        private System.Windows.Forms.Button Btnlogout;
    }
}