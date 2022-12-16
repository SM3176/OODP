
namespace OODProject
{
    partial class AdminMain
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
            this.manageServices = new System.Windows.Forms.Button();
            this.manageUsers = new System.Windows.Forms.Button();
            this.ManageBookings = new System.Windows.Forms.Button();
            this.ManageFlights = new System.Windows.Forms.Button();
            this.dcmc = new System.Windows.Forms.Button();
            this.messages = new System.Windows.Forms.Button();
            this.backupDB = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageServices
            // 
            this.manageServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageServices.Location = new System.Drawing.Point(213, 108);
            this.manageServices.Name = "manageServices";
            this.manageServices.Size = new System.Drawing.Size(400, 36);
            this.manageServices.TabIndex = 0;
            this.manageServices.Text = "Manage Services";
            this.manageServices.UseVisualStyleBackColor = true;
            this.manageServices.Click += new System.EventHandler(this.manageServices_Click);
            // 
            // manageUsers
            // 
            this.manageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsers.Location = new System.Drawing.Point(213, 177);
            this.manageUsers.Name = "manageUsers";
            this.manageUsers.Size = new System.Drawing.Size(400, 36);
            this.manageUsers.TabIndex = 1;
            this.manageUsers.Text = "Manage Users";
            this.manageUsers.UseVisualStyleBackColor = true;
            this.manageUsers.Click += new System.EventHandler(this.manageUsers_Click);
            // 
            // ManageBookings
            // 
            this.ManageBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBookings.Location = new System.Drawing.Point(213, 246);
            this.ManageBookings.Name = "ManageBookings";
            this.ManageBookings.Size = new System.Drawing.Size(400, 36);
            this.ManageBookings.TabIndex = 2;
            this.ManageBookings.Text = "Manage Bookings";
            this.ManageBookings.UseVisualStyleBackColor = true;
            this.ManageBookings.Click += new System.EventHandler(this.ManageBookings_Click);
            // 
            // ManageFlights
            // 
            this.ManageFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageFlights.Location = new System.Drawing.Point(213, 315);
            this.ManageFlights.Name = "ManageFlights";
            this.ManageFlights.Size = new System.Drawing.Size(400, 36);
            this.ManageFlights.TabIndex = 3;
            this.ManageFlights.Text = "Manage Flights";
            this.ManageFlights.UseVisualStyleBackColor = true;
            this.ManageFlights.Click += new System.EventHandler(this.ManageFlights_Click);
            // 
            // dcmc
            // 
            this.dcmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcmc.Location = new System.Drawing.Point(213, 384);
            this.dcmc.Name = "dcmc";
            this.dcmc.Size = new System.Drawing.Size(400, 36);
            this.dcmc.TabIndex = 5;
            this.dcmc.Text = "DCMC";
            this.dcmc.UseVisualStyleBackColor = true;
            this.dcmc.Click += new System.EventHandler(this.dcmc_Click);
            // 
            // messages
            // 
            this.messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messages.Location = new System.Drawing.Point(599, 12);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(121, 33);
            this.messages.TabIndex = 6;
            this.messages.Text = "Messages";
            this.messages.UseVisualStyleBackColor = true;
            this.messages.Click += new System.EventHandler(this.messages_Click);
            // 
            // backupDB
            // 
            this.backupDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupDB.Location = new System.Drawing.Point(569, 440);
            this.backupDB.Name = "backupDB";
            this.backupDB.Size = new System.Drawing.Size(151, 29);
            this.backupDB.TabIndex = 7;
            this.backupDB.Text = "Database Backup";
            this.backupDB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage Services";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Manage Users";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Manage Bookings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manage Flights";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Admin Form";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Manage Destinations";
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(13, 13);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(95, 32);
            this.logOut.TabIndex = 15;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 481);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backupDB);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.dcmc);
            this.Controls.Add(this.ManageFlights);
            this.Controls.Add(this.ManageBookings);
            this.Controls.Add(this.manageUsers);
            this.Controls.Add(this.manageServices);
            this.Name = "AdminMain";
            this.Text = "Admind Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageServices;
        private System.Windows.Forms.Button manageUsers;
        private System.Windows.Forms.Button ManageBookings;
        private System.Windows.Forms.Button ManageFlights;
        private System.Windows.Forms.Button dcmc;
        private System.Windows.Forms.Button messages;
        private System.Windows.Forms.Button backupDB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button logOut;
    }
}

