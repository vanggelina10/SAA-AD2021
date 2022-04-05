
namespace SAA_AD_2021
{
    partial class FormPurchasestatus
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
            this.lblno = new System.Windows.Forms.Label();
            this.lblpaymentstatus = new System.Windows.Forms.Label();
            this.lblunitno = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltimeperiod = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.btncalcel = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.BackColor = System.Drawing.Color.Transparent;
            this.lblno.Location = new System.Drawing.Point(188, 189);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(65, 20);
            this.lblno.TabIndex = 12;
            this.lblno.Text = "[............]";
            // 
            // lblpaymentstatus
            // 
            this.lblpaymentstatus.AutoSize = true;
            this.lblpaymentstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblpaymentstatus.Location = new System.Drawing.Point(655, 406);
            this.lblpaymentstatus.Name = "lblpaymentstatus";
            this.lblpaymentstatus.Size = new System.Drawing.Size(65, 20);
            this.lblpaymentstatus.TabIndex = 13;
            this.lblpaymentstatus.Text = "[............]";
            // 
            // lblunitno
            // 
            this.lblunitno.AutoSize = true;
            this.lblunitno.BackColor = System.Drawing.Color.Transparent;
            this.lblunitno.Location = new System.Drawing.Point(188, 406);
            this.lblunitno.Name = "lblunitno";
            this.lblunitno.Size = new System.Drawing.Size(65, 20);
            this.lblunitno.TabIndex = 14;
            this.lblunitno.Text = "[............]";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Location = new System.Drawing.Point(655, 289);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(65, 20);
            this.lbltotal.TabIndex = 15;
            this.lbltotal.Text = "[............]";
            // 
            // lbltimeperiod
            // 
            this.lbltimeperiod.AutoSize = true;
            this.lbltimeperiod.BackColor = System.Drawing.Color.Transparent;
            this.lbltimeperiod.Location = new System.Drawing.Point(188, 289);
            this.lbltimeperiod.Name = "lbltimeperiod";
            this.lbltimeperiod.Size = new System.Drawing.Size(65, 20);
            this.lbltimeperiod.TabIndex = 16;
            this.lbltimeperiod.Text = "[............]";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.BackColor = System.Drawing.Color.Transparent;
            this.lblcategory.Location = new System.Drawing.Point(655, 189);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(65, 20);
            this.lblcategory.TabIndex = 17;
            this.lblcategory.Text = "[............]";
            // 
            // btncalcel
            // 
            this.btncalcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcel.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcel.Location = new System.Drawing.Point(673, 480);
            this.btncalcel.Name = "btncalcel";
            this.btncalcel.Size = new System.Drawing.Size(179, 52);
            this.btncalcel.TabIndex = 18;
            this.btncalcel.Text = "Cancel Payment";
            this.btncalcel.UseVisualStyleBackColor = true;
            this.btncalcel.Click += new System.EventHandler(this.btncalcel_Click);
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Adobe Gothic Std B", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(34, 484);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(116, 41);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FormPurchasestatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAA_AD_2021.Properties.Resources.Paymentfinish__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btncalcel);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lbltimeperiod);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblunitno);
            this.Controls.Add(this.lblpaymentstatus);
            this.Controls.Add(this.lblno);
            this.Name = "FormPurchasestatus";
            this.Text = "FormPurchasestatus";
            this.Load += new System.EventHandler(this.FormPurchasestatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Label lblpaymentstatus;
        private System.Windows.Forms.Label lblunitno;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltimeperiod;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Button btncalcel;
        private System.Windows.Forms.Button btnback;
    }
}