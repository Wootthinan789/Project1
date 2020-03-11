using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Manu
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string U = textBox1.Text;
            string P = textBox2.Text;
            GoAdmin goAdmin = new GoAdmin();
            this.Hide();
            if (U == "Admin")
            {
                if (P == "123456")
                {
                    this.Hide();
                    goAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password ของท่านไม่ถูกต้อง","คำเตือน");
                }
            }
            else
            {
                MessageBox.Show("Username ของท่านไม่ถูกต้อง","คำเตือน");
            }
        }
    }
}
