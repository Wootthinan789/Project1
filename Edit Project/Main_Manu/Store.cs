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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            SiderPanel.Height = pictureBox7.Height;
            SiderPanel.Top = pictureBox7.Top;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home1_Click(object sender, EventArgs e)
        {
            MainManu main = new MainManu();
            this.Close();
            main.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Advice advice = new Advice();
            this.Hide();
            advice.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SiderPanel.Height = pictureBox4.Height;
            SiderPanel.Top = pictureBox4.Top;
            FACEBOOK fACEBOOK = new FACEBOOK();
            fACEBOOK.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SiderPanel.Height = pictureBox6.Height;
            SiderPanel.Top = pictureBox6.Top;
            LINE lINE = new LINE();
            lINE.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SiderPanel.Height = pictureBox5.Height;
            SiderPanel.Top = pictureBox5.Top;
            IG iG = new IG();
            iG.Show();
        }
    }
}
