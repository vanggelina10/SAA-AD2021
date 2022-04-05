
namespace SAA_AD_2021
{
    partial class Formunit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formunit));
            this.dgvunit = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.lblrows = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvunit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvunit
            // 
            this.dgvunit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvunit.Location = new System.Drawing.Point(27, 128);
            this.dgvunit.Name = "dgvunit";
            this.dgvunit.RowHeadersWidth = 62;
            this.dgvunit.RowTemplate.Height = 28;
            this.dgvunit.Size = new System.Drawing.Size(875, 374);
            this.dgvunit.TabIndex = 1;
            this.dgvunit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvunit_CellClick);
            this.dgvunit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvunit_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Salmon;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(799, 518);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(103, 33);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblrows
            // 
            this.lblrows.AutoSize = true;
            this.lblrows.BackColor = System.Drawing.Color.Transparent;
            this.lblrows.Location = new System.Drawing.Point(88, 522);
            this.lblrows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrows.Name = "lblrows";
            this.lblrows.Size = new System.Drawing.Size(51, 20);
            this.lblrows.TabIndex = 16;
            this.lblrows.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 522);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Result :";
            // 
            // Formunit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.lblrows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvunit);
            this.DoubleBuffered = true;
            this.Name = "Formunit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formunit";
            this.Load += new System.EventHandler(this.Formunit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvunit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblrows;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvunit;
    }
}