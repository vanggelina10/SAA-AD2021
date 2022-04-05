
namespace SAA_AD_2021
{
    partial class FormLogin
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxusername = new System.Windows.Forms.TextBox();
            this.tboxpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsignup = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.llabeladmin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.OldLace;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnlogin.Location = new System.Drawing.Point(604, 316);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 35);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Adobe Fangsong Std R", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(603, 169);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(101, 25);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fangsong Std R", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // tboxusername
            // 
            this.tboxusername.Location = new System.Drawing.Point(604, 197);
            this.tboxusername.Name = "tboxusername";
            this.tboxusername.Size = new System.Drawing.Size(217, 26);
            this.tboxusername.TabIndex = 1;
            // 
            // tboxpassword
            // 
            this.tboxpassword.Location = new System.Drawing.Point(604, 268);
            this.tboxpassword.Name = "tboxpassword";
            this.tboxpassword.Size = new System.Drawing.Size(217, 26);
            this.tboxpassword.TabIndex = 2;
            this.tboxpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(600, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "*                first if you don\'t have an account";
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblsignup.Location = new System.Drawing.Point(609, 375);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(63, 20);
            this.lblsignup.TabIndex = 7;
            this.lblsignup.TabStop = true;
            this.lblsignup.Text = "Sign up";
            this.lblsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblsignup_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(678, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "*               here If you are admin";
            // 
            // llabeladmin
            // 
            this.llabeladmin.AutoSize = true;
            this.llabeladmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.llabeladmin.Location = new System.Drawing.Point(690, 551);
            this.llabeladmin.Name = "llabeladmin";
            this.llabeladmin.Size = new System.Drawing.Size(54, 20);
            this.llabeladmin.TabIndex = 9;
            this.llabeladmin.TabStop = true;
            this.llabeladmin.Text = "Log In";
            this.llabeladmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llabeladmin_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.llabeladmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxpassword);
            this.Controls.Add(this.tboxusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.btnlogin);
            this.DoubleBuffered = true;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxusername;
        private System.Windows.Forms.TextBox tboxpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblsignup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llabeladmin;
    }
}

