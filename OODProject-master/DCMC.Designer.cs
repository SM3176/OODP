namespace OODProject
{
    partial class DCMC
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
            this.ManageAirportBtn = new System.Windows.Forms.Button();
            this.ManageCityBtn = new System.Windows.Forms.Button();
            this.ManageCountryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ManageAirportBtn
            // 
            this.ManageAirportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAirportBtn.Location = new System.Drawing.Point(195, 131);
            this.ManageAirportBtn.Name = "ManageAirportBtn";
            this.ManageAirportBtn.Size = new System.Drawing.Size(194, 37);
            this.ManageAirportBtn.TabIndex = 0;
            this.ManageAirportBtn.Text = "Manage Airport";
            this.ManageAirportBtn.UseVisualStyleBackColor = true;
            this.ManageAirportBtn.Click += new System.EventHandler(this.ManageAirportBtn_Click);
            // 
            // ManageCityBtn
            // 
            this.ManageCityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCityBtn.Location = new System.Drawing.Point(195, 208);
            this.ManageCityBtn.Name = "ManageCityBtn";
            this.ManageCityBtn.Size = new System.Drawing.Size(194, 37);
            this.ManageCityBtn.TabIndex = 1;
            this.ManageCityBtn.Text = "Manage City";
            this.ManageCityBtn.UseVisualStyleBackColor = true;
            this.ManageCityBtn.Click += new System.EventHandler(this.ManageCityBtn_Click);
            // 
            // ManageCountryBtn
            // 
            this.ManageCountryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCountryBtn.Location = new System.Drawing.Point(195, 285);
            this.ManageCountryBtn.Name = "ManageCountryBtn";
            this.ManageCountryBtn.Size = new System.Drawing.Size(194, 37);
            this.ManageCountryBtn.TabIndex = 2;
            this.ManageCountryBtn.Text = "Manage Country";
            this.ManageCountryBtn.UseVisualStyleBackColor = true;
            this.ManageCountryBtn.Click += new System.EventHandler(this.ManageCountryBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Airport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manage Country";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(287, 380);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 36);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Manage Destinations";
            // 
            // DCMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManageCountryBtn);
            this.Controls.Add(this.ManageCityBtn);
            this.Controls.Add(this.ManageAirportBtn);
            this.Name = "DCMC";
            this.Text = "DCMC";
            this.Load += new System.EventHandler(this.DCMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageAirportBtn;
        private System.Windows.Forms.Button ManageCityBtn;
        private System.Windows.Forms.Button ManageCountryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label4;
    }
}