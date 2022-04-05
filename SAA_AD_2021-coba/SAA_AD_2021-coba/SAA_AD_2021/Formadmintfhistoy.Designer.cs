
namespace SAA_AD_2021
{
    partial class Formadmintfhistoy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formadmintfhistoy));
            this.dgvtampilanPH = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.lblrows = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbJenisLaporan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtampilanPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtampilanPH
            // 
            this.dgvtampilanPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtampilanPH.Location = new System.Drawing.Point(46, 131);
            this.dgvtampilanPH.Name = "dgvtampilanPH";
            this.dgvtampilanPH.RowHeadersWidth = 62;
            this.dgvtampilanPH.RowTemplate.Height = 28;
            this.dgvtampilanPH.Size = new System.Drawing.Size(842, 361);
            this.dgvtampilanPH.TabIndex = 0;
            this.dgvtampilanPH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtampilanPH_CellClick);
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(798, 536);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(90, 32);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblrows
            // 
            this.lblrows.AutoSize = true;
            this.lblrows.BackColor = System.Drawing.Color.Transparent;
            this.lblrows.Location = new System.Drawing.Point(117, 510);
            this.lblrows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrows.Name = "lblrows";
            this.lblrows.Size = new System.Drawing.Size(51, 20);
            this.lblrows.TabIndex = 14;
            this.lblrows.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(52, 510);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Result :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-81, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1096, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbJenisLaporan
            // 
            this.cbJenisLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisLaporan.FormattingEnabled = true;
            this.cbJenisLaporan.Items.AddRange(new object[] {
            "All",
            "Purchase Status",
            "Purchase Cancelled"});
            this.cbJenisLaporan.Location = new System.Drawing.Point(121, 92);
            this.cbJenisLaporan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbJenisLaporan.Name = "cbJenisLaporan";
            this.cbJenisLaporan.Size = new System.Drawing.Size(290, 28);
            this.cbJenisLaporan.TabIndex = 29;
            this.cbJenisLaporan.SelectedIndexChanged += new System.EventHandler(this.cbJenisLaporan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Filter :";
            // 
            // Formadmintfhistoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbJenisLaporan);
            this.Controls.Add(this.lblrows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvtampilanPH);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formadmintfhistoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formadmintfhistoy";
            this.Load += new System.EventHandler(this.Formadmintfhistoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtampilanPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtampilanPH;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblrows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbJenisLaporan;
        private System.Windows.Forms.Label label2;
    }
}