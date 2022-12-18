
namespace OODProject
{
    partial class ManageCountry
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
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countryGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateCountry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(520, 225);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 33);
            this.addBtn.TabIndex = 50;
            this.addBtn.Text = "Add User";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(15, 47);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 32);
            this.backBtn.TabIndex = 49;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(520, 142);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(247, 22);
            this.countryTextBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Country Name";
            // 
            // countryGridView
            // 
            this.countryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryGridView.Location = new System.Drawing.Point(15, 96);
            this.countryGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryGridView.Name = "countryGridView";
            this.countryGridView.RowHeadersWidth = 51;
            this.countryGridView.RowTemplate.Height = 24;
            this.countryGridView.Size = new System.Drawing.Size(481, 341);
            this.countryGridView.TabIndex = 44;
            this.countryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.countryGridView_CellContentClick);
            this.countryGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.countryGridView_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Manage Country";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(653, 225);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 33);
            this.deleteBtn.TabIndex = 51;
            this.deleteBtn.Text = "Delete User";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateCountry
            // 
            this.updateCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCountry.Location = new System.Drawing.Point(592, 296);
            this.updateCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateCountry.Name = "updateCountry";
            this.updateCountry.Size = new System.Drawing.Size(95, 33);
            this.updateCountry.TabIndex = 52;
            this.updateCountry.Text = "Update";
            this.updateCountry.UseVisualStyleBackColor = true;
            this.updateCountry.Click += new System.EventHandler(this.updateCountry_Click);
            // 
            // ManageCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateCountry);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageCountry";
            this.Text = "ManageCountry";
            this.Load += new System.EventHandler(this.ManageCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView countryGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateCountry;
    }
}