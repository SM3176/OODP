using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODProject
{
    public partial class EmpPreviewUsers : Form
    {
        public EmpPreviewUsers()
        {
            InitializeComponent();
        }

        private void EmpPreviewUsers_Load_1(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = EmpUserBooking.userSubset;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
