using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draghts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //label3.Text = Convert.ToString(e.Location);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = Convert.ToString(e.Location);
        }
    }
}
