
namespace SAA_AD_2021
{
    partial class FormPurchaseHistory
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
            this.dgvtampilan = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvdelete = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtampilan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtampilan
            // 
            this.dgvtampilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtampilan.Location = new System.Drawing.Point(12, 106);
            this.dgvtampilan.Name = "dgvtampilan";
            this.dgvtampilan.RowHeadersWidth = 62;
            this.dgvtampilan.RowTemplate.Height = 28;
            this.dgvtampilan.Size = new System.Drawing.Size(1020, 220);
            this.dgvtampilan.TabIndex = 0;
            this.dgvtampilan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtampilan_CellClick);
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(928, 541);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(91, 30);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dgvdelete
            // 
            this.dgvdelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdelete.Location = new System.Drawing.Point(12, 381);
            this.dgvdelete.Name = "dgvdelete";
            this.dgvdelete.RowHeadersWidth = 62;
            this.dgvdelete.RowTemplate.Height = 28;
            this.dgvdelete.Size = new System.Drawing.Size(1020, 151);
            this.dgvdelete.TabIndex = 3;
            // 
            // FormPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources.purchase_history__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 580);
            this.Controls.Add(this.dgvdelete);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvtampilan);
            this.DoubleBuffered = true;
            this.Name = "FormPurchaseHistory";
            this.Text = "FormPurchaseHistory";
            this.Load += new System.EventHandler(this.FormPurchaseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtampilan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtampilan;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvdelete;
    }
}