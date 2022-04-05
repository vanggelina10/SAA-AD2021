
namespace SAA_AD_2021
{
    partial class Formadmin
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
            this.tboxpassword = new System.Windows.Forms.TextBox();
            this.tboxusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxpassword
            // 
            this.tboxpassword.Location = new System.Drawing.Point(512, 408);
            this.tboxpassword.Name = "tboxpassword";
            this.tboxpassword.Size = new System.Drawing.Size(217, 26);
            this.tboxpassword.TabIndex = 6;
            this.tboxpassword.UseSystemPasswordChar = true;
            // 
            // tboxusername
            // 
            this.tboxusername.Location = new System.Drawing.Point(216, 408);
            this.tboxusername.Name = "tboxusername";
            this.tboxusername.Size = new System.Drawing.Size(217, 26);
            this.tboxusername.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fangsong Std R", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Adobe Fangsong Std R", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(216, 380);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(164, 25);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Username Admin";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.OldLace;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnlogin.Location = new System.Drawing.Point(214, 440);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 35);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.OldLace;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnback.Location = new System.Drawing.Point(514, 440);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(89, 35);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Visible = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Formadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources.app_2aaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.tboxpassword);
            this.Controls.Add(this.tboxusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.btnlogin);
            this.Name = "Formadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formadmin";
            this.Load += new System.EventHandler(this.Formadmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxpassword;
        private System.Windows.Forms.TextBox tboxusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnback;
    }
}