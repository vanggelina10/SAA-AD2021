
namespace SAA_AD_2021
{
    partial class FormProfile
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
            this.btnsaveatas = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.tboxnew = new System.Windows.Forms.TextBox();
            this.tboxpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxphoneno = new System.Windows.Forms.TextBox();
            this.tboxemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxusername = new System.Windows.Forms.TextBox();
            this.tboxfullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnsavebawah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsaveatas
            // 
            this.btnsaveatas.Enabled = false;
            this.btnsaveatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveatas.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveatas.Location = new System.Drawing.Point(651, 521);
            this.btnsaveatas.Name = "btnsaveatas";
            this.btnsaveatas.Size = new System.Drawing.Size(90, 32);
            this.btnsaveatas.TabIndex = 32;
            this.btnsaveatas.Text = "Save";
            this.btnsaveatas.UseVisualStyleBackColor = true;
            this.btnsaveatas.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(534, 526);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(90, 32);
            this.btnedit.TabIndex = 31;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // tboxnew
            // 
            this.tboxnew.Enabled = false;
            this.tboxnew.Location = new System.Drawing.Point(510, 461);
            this.tboxnew.Name = "tboxnew";
            this.tboxnew.Size = new System.Drawing.Size(217, 26);
            this.tboxnew.TabIndex = 30;
            this.tboxnew.UseSystemPasswordChar = true;
            // 
            // tboxpassword
            // 
            this.tboxpassword.Enabled = false;
            this.tboxpassword.Location = new System.Drawing.Point(513, 388);
            this.tboxpassword.Name = "tboxpassword";
            this.tboxpassword.Size = new System.Drawing.Size(217, 26);
            this.tboxpassword.TabIndex = 29;
            this.tboxpassword.UseSystemPasswordChar = true;
            this.tboxpassword.TextChanged += new System.EventHandler(this.tboxpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(511, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(509, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Current Password";
            // 
            // tboxphoneno
            // 
            this.tboxphoneno.Location = new System.Drawing.Point(513, 319);
            this.tboxphoneno.Name = "tboxphoneno";
            this.tboxphoneno.ReadOnly = true;
            this.tboxphoneno.Size = new System.Drawing.Size(217, 26);
            this.tboxphoneno.TabIndex = 26;
            this.tboxphoneno.TextChanged += new System.EventHandler(this.tboxphoneno_TextChanged);
            // 
            // tboxemail
            // 
            this.tboxemail.Location = new System.Drawing.Point(513, 250);
            this.tboxemail.Name = "tboxemail";
            this.tboxemail.ReadOnly = true;
            this.tboxemail.Size = new System.Drawing.Size(217, 26);
            this.tboxemail.TabIndex = 25;
            this.tboxemail.TextChanged += new System.EventHandler(this.tboxemail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(509, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(509, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "email";
            // 
            // tboxusername
            // 
            this.tboxusername.Location = new System.Drawing.Point(513, 178);
            this.tboxusername.Name = "tboxusername";
            this.tboxusername.ReadOnly = true;
            this.tboxusername.Size = new System.Drawing.Size(217, 26);
            this.tboxusername.TabIndex = 22;
            this.tboxusername.TextChanged += new System.EventHandler(this.tboxusername_TextChanged);
            // 
            // tboxfullname
            // 
            this.tboxfullname.Location = new System.Drawing.Point(513, 117);
            this.tboxfullname.Name = "tboxfullname";
            this.tboxfullname.ReadOnly = true;
            this.tboxfullname.Size = new System.Drawing.Size(217, 26);
            this.tboxfullname.TabIndex = 21;
            this.tboxfullname.TextChanged += new System.EventHandler(this.tboxfullname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(509, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Username";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Location = new System.Drawing.Point(509, 84);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 20);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Full Name";
            // 
            // btncancel
            // 
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(409, 526);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 32);
            this.btncancel.TabIndex = 33;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Adobe Gothic Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(808, 523);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(80, 30);
            this.btnback.TabIndex = 34;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnchange
            // 
            this.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchange.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchange.Location = new System.Drawing.Point(755, 388);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(161, 32);
            this.btnchange.TabIndex = 35;
            this.btnchange.Text = "Change Password";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnsavebawah
            // 
            this.btnsavebawah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavebawah.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavebawah.Location = new System.Drawing.Point(755, 471);
            this.btnsavebawah.Name = "btnsavebawah";
            this.btnsavebawah.Size = new System.Drawing.Size(90, 32);
            this.btnsavebawah.TabIndex = 36;
            this.btnsavebawah.Text = "Save";
            this.btnsavebawah.UseVisualStyleBackColor = true;
            this.btnsavebawah.Click += new System.EventHandler(this.btnsavebawah_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources.update_profile2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.btnsavebawah);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsaveatas);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.tboxnew);
            this.Controls.Add(this.tboxpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxphoneno);
            this.Controls.Add(this.tboxemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxusername);
            this.Controls.Add(this.tboxfullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaveatas;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox tboxnew;
        private System.Windows.Forms.TextBox tboxpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxphoneno;
        private System.Windows.Forms.TextBox tboxemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxusername;
        private System.Windows.Forms.TextBox tboxfullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnsavebawah;
    }
}