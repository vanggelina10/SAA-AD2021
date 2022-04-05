
namespace SAA_AD_2021
{
    partial class Formdeleteuser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtnactiv = new System.Windows.Forms.RadioButton();
            this.rbtnblock = new System.Windows.Forms.RadioButton();
            this.lblname = new System.Windows.Forms.Label();
            this.lbluse_id = new System.Windows.Forms.Label();
            this.lbltransaction = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transaction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = ":";
            // 
            // rbtnactiv
            // 
            this.rbtnactiv.AutoSize = true;
            this.rbtnactiv.BackColor = System.Drawing.Color.Transparent;
            this.rbtnactiv.Checked = true;
            this.rbtnactiv.Location = new System.Drawing.Point(167, 245);
            this.rbtnactiv.Name = "rbtnactiv";
            this.rbtnactiv.Size = new System.Drawing.Size(100, 24);
            this.rbtnactiv.TabIndex = 8;
            this.rbtnactiv.TabStop = true;
            this.rbtnactiv.Text = "Activated";
            this.rbtnactiv.UseVisualStyleBackColor = false;
            this.rbtnactiv.CheckedChanged += new System.EventHandler(this.rbtnactiv_CheckedChanged);
            // 
            // rbtnblock
            // 
            this.rbtnblock.AutoSize = true;
            this.rbtnblock.BackColor = System.Drawing.SystemColors.Control;
            this.rbtnblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnblock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbtnblock.Location = new System.Drawing.Point(273, 245);
            this.rbtnblock.Name = "rbtnblock";
            this.rbtnblock.Size = new System.Drawing.Size(98, 24);
            this.rbtnblock.TabIndex = 9;
            this.rbtnblock.TabStop = true;
            this.rbtnblock.Text = "Blocked";
            this.rbtnblock.UseVisualStyleBackColor = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(174, 75);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 20);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "Name";
            // 
            // lbluse_id
            // 
            this.lbluse_id.AutoSize = true;
            this.lbluse_id.Location = new System.Drawing.Point(174, 130);
            this.lbluse_id.Name = "lbluse_id";
            this.lbluse_id.Size = new System.Drawing.Size(51, 20);
            this.lbluse_id.TabIndex = 11;
            this.lbluse_id.Text = "Name";
            // 
            // lbltransaction
            // 
            this.lbltransaction.AutoSize = true;
            this.lbltransaction.Location = new System.Drawing.Point(174, 187);
            this.lbltransaction.Name = "lbltransaction";
            this.lbltransaction.Size = new System.Drawing.Size(51, 20);
            this.lbltransaction.TabIndex = 12;
            this.lbltransaction.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(187, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 40);
            this.label12.TabIndex = 13;
            this.label12.Text = "User Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Times";
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.Info;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(392, 283);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(92, 32);
            this.btnsubmit.TabIndex = 15;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.OrangeRed;
            this.btnback.Location = new System.Drawing.Point(40, 284);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(72, 31);
            this.btnback.TabIndex = 57;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Formdeleteuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources.update_profile2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(519, 327);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbltransaction);
            this.Controls.Add(this.lbluse_id);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.rbtnblock);
            this.Controls.Add(this.rbtnactiv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formdeleteuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formdeleteuser";
            this.Load += new System.EventHandler(this.Formdeleteuser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtnactiv;
        private System.Windows.Forms.RadioButton rbtnblock;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbluse_id;
        private System.Windows.Forms.Label lbltransaction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnback;
    }
}