using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace Draghts
{
    public partial class Form2 : Form 
    {
        private DraughtsServiceReference.PortalClient proxy;

        public Form2()
        {
            InitializeComponent();
            proxy = new DraughtsServiceReference.PortalClient();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool result;
            result=proxy.signUp(tbUser.Text, tbPass.Text);
            if (result == true)
            {
                MessageBox.Show("You have successfully signed up");
                Form1 gameForm = new Form1();
                gameForm.Show();
            }
            else
                MessageBox.Show("Your signing up was unsuccessful");
        }
    }
}
