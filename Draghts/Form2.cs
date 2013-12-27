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
       
       
        //private DraughtsServiceReference.PortalClient proxy;
        public Form2()
        {
            Proxy.login = this;
            InitializeComponent();
            //PortalProxy.proxy = new DraughtsServiceReference.PortalClient();
            //proxy.Subscribe();

        }
        //public void OnLoggingInOrOut(DraughtsServiceReference.Player[] players)
        //{
        //    string name;
        //    foreach (DraughtsServiceReference.Player pl in players)
        //    {
        //        name = pl.userName;
        //    }

        //}

        //public void OnLoggingInOrOut1(DraughtsServiceReference.Player[] players)
        //{
        //    string name;
        //    foreach (DraughtsServiceReference.Player pl in players)
        //    {
        //        lbOnlineList.Items.Add(pl.userName);
        //    }

        //}
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool result;
            if (tbSignUpPW.Text == tbConfirmPW.Text)
            {
                result = Proxy.proxy.signUp(tbUser.Text, tbPass.Text);

                if (result == true)
                {
                    MessageBox.Show("You have successfully signed up");
                    Form1 gameForm = new Form1();
                    gameForm.Show();
                }
                else if (result == false)
                {
                    MessageBox.Show("The username you input is already in use,please try another one");
                }
            }
            else
                lbWarning.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool result=false;

            result = Proxy.proxy.logIn(tbUser.Text, tbPass.Text);
            if (result)
            {
                Form1 gameForm = new Form1();
                gameForm.Show();
                
                //proxy.Subscribe();
            }
            else
            {
                lbWarning2.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       
    }


   
}
