
namespace OODProject
{
    partial class Service
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
            this.manageServiceLabel = new System.Windows.Forms.Label();
            this.addServiceLabel = new System.Windows.Forms.Label();
            this.deleteServiceLabel = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.deleteCombo = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageServiceLabel
            // 
            this.manageServiceLabel.AutoSize = true;
            this.manageServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageServiceLabel.Location = new System.Drawing.Point(172, 32);
            this.manageServiceLabel.Name = "manageServiceLabel";
            this.manageServiceLabel.Size = new System.Drawing.Size(308, 42);
            this.manageServiceLabel.TabIndex = 0;
            this.manageServiceLabel.Text = "Manage Services";
            // 
            // addServiceLabel
            // 
            this.addServiceLabel.AutoSize = true;
            this.addServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceLabel.Location = new System.Drawing.Point(15, 124);
            this.addServiceLabel.Name = "addServiceLabel";
            this.addServiceLabel.Size = new System.Drawing.Size(119, 25);
            this.addServiceLabel.TabIndex = 1;
            this.addServiceLabel.Text = "Add Service";
            // 
            // deleteServiceLabel
            // 
            this.deleteServiceLabel.AutoSize = true;
            this.deleteServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteServiceLabel.Location = new System.Drawing.Point(15, 218);
            this.deleteServiceLabel.Name = "deleteServiceLabel";
            this.deleteServiceLabel.Size = new System.Drawing.Size(139, 25);
            this.deleteServiceLabel.TabIndex = 2;
            this.deleteServiceLabel.Text = "Delete Service";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(192, 124);
            this.addTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(244, 22);
            this.addTextBox.TabIndex = 4;
            // 
            // deleteCombo
            // 
            this.deleteCombo.FormattingEnabled = true;
            this.deleteCombo.Location = new System.Drawing.Point(192, 220);
            this.deleteCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteCombo.Name = "deleteCombo";
            this.deleteCombo.Size = new System.Drawing.Size(244, 24);
            this.deleteCombo.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(479, 124);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(155, 36);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add Service";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(479, 220);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(148, 36);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete Service";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(259, 309);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(148, 39);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 420);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteCombo);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.deleteServiceLabel);
            this.Controls.Add(this.addServiceLabel);
            this.Controls.Add(this.manageServiceLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Service";
            this.Text = "Manage Services";
            this.Load += new System.EventHandler(this.Service_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manageServiceLabel;
        private System.Windows.Forms.Label addServiceLabel;
        private System.Windows.Forms.Label deleteServiceLabel;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.ComboBox deleteCombo;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button backBtn;
    }
}