
namespace SAA_AD_2021
{
    partial class Formchekout1
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
            this.tboxtime = new System.Windows.Forms.TextBox();
            this.tboxtotalprice = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btncheckout = new System.Windows.Forms.Button();
            this.tboxstart = new System.Windows.Forms.TextBox();
            this.tboxcategory = new System.Windows.Forms.TextBox();
            this.tboxphone = new System.Windows.Forms.TextBox();
            this.Tboxfullname = new System.Windows.Forms.TextBox();
            this.tboxunit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxtime
            // 
            this.tboxtime.Location = new System.Drawing.Point(381, 419);
            this.tboxtime.Name = "tboxtime";
            this.tboxtime.ReadOnly = true;
            this.tboxtime.Size = new System.Drawing.Size(166, 26);
            this.tboxtime.TabIndex = 30;
            // 
            // tboxtotalprice
            // 
            this.tboxtotalprice.Location = new System.Drawing.Point(115, 412);
            this.tboxtotalprice.Name = "tboxtotalprice";
            this.tboxtotalprice.ReadOnly = true;
            this.tboxtotalprice.Size = new System.Drawing.Size(165, 26);
            this.tboxtotalprice.TabIndex = 38;
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(75, 505);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(123, 37);
            this.btnback.TabIndex = 40;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btncheckout
            // 
            this.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheckout.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.Location = new System.Drawing.Point(680, 467);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(123, 37);
            this.btncheckout.TabIndex = 39;
            this.btncheckout.Text = "Checkout";
            this.btncheckout.UseVisualStyleBackColor = true;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click_1);
            // 
            // tboxstart
            // 
            this.tboxstart.Location = new System.Drawing.Point(123, 360);
            this.tboxstart.Name = "tboxstart";
            this.tboxstart.ReadOnly = true;
            this.tboxstart.Size = new System.Drawing.Size(152, 26);
            this.tboxstart.TabIndex = 44;
            // 
            // tboxcategory
            // 
            this.tboxcategory.Location = new System.Drawing.Point(138, 241);
            this.tboxcategory.Name = "tboxcategory";
            this.tboxcategory.ReadOnly = true;
            this.tboxcategory.Size = new System.Drawing.Size(217, 26);
            this.tboxcategory.TabIndex = 45;
            // 
            // tboxphone
            // 
            this.tboxphone.Location = new System.Drawing.Point(591, 169);
            this.tboxphone.Name = "tboxphone";
            this.tboxphone.ReadOnly = true;
            this.tboxphone.Size = new System.Drawing.Size(174, 26);
            this.tboxphone.TabIndex = 46;
            // 
            // Tboxfullname
            // 
            this.Tboxfullname.Location = new System.Drawing.Point(133, 171);
            this.Tboxfullname.Name = "Tboxfullname";
            this.Tboxfullname.ReadOnly = true;
            this.Tboxfullname.Size = new System.Drawing.Size(217, 26);
            this.Tboxfullname.TabIndex = 47;
            // 
            // tboxunit
            // 
            this.tboxunit.Location = new System.Drawing.Point(411, 169);
            this.tboxunit.Name = "tboxunit";
            this.tboxunit.ReadOnly = true;
            this.tboxunit.Size = new System.Drawing.Size(95, 26);
            this.tboxunit.TabIndex = 49;
            // 
            // Formchekout1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources.checkout2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.tboxunit);
            this.Controls.Add(this.Tboxfullname);
            this.Controls.Add(this.tboxphone);
            this.Controls.Add(this.tboxcategory);
            this.Controls.Add(this.tboxstart);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btncheckout);
            this.Controls.Add(this.tboxtotalprice);
            this.Controls.Add(this.tboxtime);
            this.Name = "Formchekout1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formchekout";
            this.Load += new System.EventHandler(this.Formchekout1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxtime;
        private System.Windows.Forms.TextBox tboxtotalprice;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.TextBox tboxstart;
        private System.Windows.Forms.TextBox tboxcategory;
        private System.Windows.Forms.TextBox tboxphone;
        private System.Windows.Forms.TextBox Tboxfullname;
        private System.Windows.Forms.TextBox tboxunit;
    }
}