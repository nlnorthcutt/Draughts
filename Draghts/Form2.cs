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
        private List<int> listOfBoardSquares = new List<int>();
        public Form2()
        {
            InitializeComponent();
            proxy = new DraughtsServiceReference.PortalClient();

            for (int i = 0; i < 64; i++)
            {

                listOfBoardSquares.Add(i);

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool result;
            if (tbSignUpPW.Text == tbConfirmPW.Text)
            {
                result = proxy.signUp(tbUser.Text, tbPass.Text);

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
            result = proxy.logIn(tbUser.Text,tbPass.Text);
            if (result)
            {
                Form1 gameForm = new Form1();
                gameForm.Show();
            }
            else
            {
                lbWarning2.Visible = true;
            }

        }
        public int calculateBoardSquareAtPost(Point pt)
        {
            int row, column;

            column = pt.X % 50;
            row = pt.Y % 50;

            return (8 * row) + column;
        }
       
    }
}
