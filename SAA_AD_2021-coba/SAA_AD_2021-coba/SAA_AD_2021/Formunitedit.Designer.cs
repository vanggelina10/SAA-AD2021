
namespace SAA_AD_2021
{
    partial class Formunitedit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formunitedit));
            this.rbtnavailable = new System.Windows.Forms.RadioButton();
            this.rbtnrented = new System.Windows.Forms.RadioButton();
            this.btnback = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblduration = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblstartrent = new System.Windows.Forms.Label();
            this.lblunitno = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnavailable
            // 
            this.rbtnavailable.AutoSize = true;
            this.rbtnavailable.BackColor = System.Drawing.Color.Transparent;
            this.rbtnavailable.Location = new System.Drawing.Point(675, 405);
            this.rbtnavailable.Name = "rbtnavailable";
            this.rbtnavailable.Size = new System.Drawing.Size(97, 24);
            this.rbtnavailable.TabIndex = 58;
            this.rbtnavailable.TabStop = true;
            this.rbtnavailable.Text = "Available";
            this.rbtnavailable.UseVisualStyleBackColor = false;
            this.rbtnavailable.CheckedChanged += new System.EventHandler(this.rbtnavailable_CheckedChanged);
            // 
            // rbtnrented
            // 
            this.rbtnrented.AutoSize = true;
            this.rbtnrented.BackColor = System.Drawing.Color.Transparent;
            this.rbtnrented.Checked = true;
            this.rbtnrented.Location = new System.Drawing.Point(551, 405);
            this.rbtnrented.Name = "rbtnrented";
            this.rbtnrented.Size = new System.Drawing.Size(87, 24);
            this.rbtnrented.TabIndex = 57;
            this.rbtnrented.TabStop = true;
            this.rbtnrented.Text = "Rented";
            this.rbtnrented.UseVisualStyleBackColor = false;
            this.rbtnrented.CheckedChanged += new System.EventHandler(this.rbtnrented_CheckedChanged);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.OrangeRed;
            this.btnback.Location = new System.Drawing.Point(214, 527);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(80, 41);
            this.btnback.TabIndex = 56;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Azure;
            this.btnupdate.Location = new System.Drawing.Point(569, 527);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(179, 41);
            this.btnupdate.TabIndex = 55;
            this.btnupdate.Text = "Update Status";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.BackColor = System.Drawing.Color.Transparent;
            this.lblduration.Location = new System.Drawing.Point(609, 158);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(65, 20);
            this.lblduration.TabIndex = 54;
            this.lblduration.Text = "[............]";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.BackColor = System.Drawing.Color.Transparent;
            this.lblcategory.Location = new System.Drawing.Point(173, 274);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(65, 20);
            this.lblcategory.TabIndex = 53;
            this.lblcategory.Text = "[............]";
            // 
            // lblstartrent
            // 
            this.lblstartrent.AutoSize = true;
            this.lblstartrent.BackColor = System.Drawing.Color.Transparent;
            this.lblstartrent.Location = new System.Drawing.Point(609, 279);
            this.lblstartrent.Name = "lblstartrent";
            this.lblstartrent.Size = new System.Drawing.Size(65, 20);
            this.lblstartrent.TabIndex = 52;
            this.lblstartrent.Text = "[............]";
            // 
            // lblunitno
            // 
            this.lblunitno.AutoSize = true;
            this.lblunitno.BackColor = System.Drawing.Color.Transparent;
            this.lblunitno.Location = new System.Drawing.Point(228, 375);
            this.lblunitno.Name = "lblunitno";
            this.lblunitno.Size = new System.Drawing.Size(65, 20);
            this.lblunitno.TabIndex = 51;
            this.lblunitno.Text = "[............]";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Location = new System.Drawing.Point(210, 158);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 20);
            this.lblname.TabIndex = 50;
            this.lblname.Text = "[............]";
            // 
            // Formunitedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.rbtnavailable);
            this.Controls.Add(this.rbtnrented);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lblstartrent);
            this.Controls.Add(this.lblunitno);
            this.Controls.Add(this.lblname);
            this.DoubleBuffered = true;
            this.Name = "Formunitedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formunitedit";
            this.Load += new System.EventHandler(this.Formunitedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnavailable;
        private System.Windows.Forms.RadioButton rbtnrented;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblstartrent;
        private System.Windows.Forms.Label lblunitno;
        private System.Windows.Forms.Label lblname;
    }
}