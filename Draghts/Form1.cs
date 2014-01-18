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
    public partial class Form1 : Form 
    {
        //private DraughtsServiceReference.GamePlayClient proxy;
        //private DraughtsServiceReference.PortalClient proxy2;
        bool gameStarted = true;
        private List<int> listOfBoardSquares = new List<int>();

        private DraughtsServiceReference.Player[] plyrs;
        public List<PictureBox>listOfPBs=new List<PictureBox>();
        public bool pieceSelected = false;
        int selectedBoardSquare;
        PictureBox pbSelected;
 
        public Form1()
        {
            Proxy.loddy = this;
            InitializeComponent();
            //proxy = new DraughtsServiceReference.GamePlayClient(new InstanceContext(this));
            //proxy2 = new DraughtsServiceReference.PortalClient(new InstanceContext(this));
            //proxy2.Subscribe();

            for (int i = 0; i < 64; i++)
            {

                listOfBoardSquares.Add(i);
                listOfBoardSquares[i] = 0;

            }
            for (int j = 1; j < 24; j=j+2)
            {

                
                listOfBoardSquares[j] = 1;

            }
            for (int j = 41; j < 63; j = j + 2)
            {

               
                listOfBoardSquares[j] = 1;

            }
            
            listOfPBs.Add(pictureBox2);
            listOfPBs.Add(pictureBox3);
            listOfPBs.Add(pictureBox4);
            listOfPBs.Add(pictureBox5);
            listOfPBs.Add(pictureBox6);
            listOfPBs.Add(pictureBox7);
            listOfPBs.Add(pictureBox8);
            listOfPBs.Add(pictureBox9);
            listOfPBs.Add(pictureBox10);
            listOfPBs.Add(pictureBox11);
            listOfPBs.Add(pictureBox12);
            listOfPBs.Add(pictureBox13);
            listOfPBs.Add(pictureBox14);
            listOfPBs.Add(pictureBox15);
            listOfPBs.Add(pictureBox16);
            listOfPBs.Add(pictureBox17);
            listOfPBs.Add(pictureBox18);
            listOfPBs.Add(pictureBox19);
            listOfPBs.Add(pictureBox20);
            listOfPBs.Add(pictureBox21);
            listOfPBs.Add(pictureBox22);
            listOfPBs.Add(pictureBox23);
            listOfPBs.Add(pictureBox25);
            listOfPBs.Add(pictureBox26);
            //onlineUsers.Add("Users Online");
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point newPost = new Point();
            newPost = calculateBoardSquareAtPost(e.Location);
            if (gameStarted)
            {
                
                if (listOfBoardSquares[selectedBoardSquare] == 0)
                {
                    if (newPost.X != -1 && newPost.Y != -1)
                    {
                        pbSelected.Location = newPost;
                        PortalProxy.proxy.makeMove(newPost.X, newPost.Y);
                    }
                    else
                        MessageBox.Show("Do not move to white space!");
                }
                else
                    MessageBox.Show("The space is already taken!");
            }
          
        }
        public Point calculateBoardSquareAtPost(Point pt)
        {
            int row, column,x,y;
            Point point;

            column = pt.X / 50;
            row = pt.Y / 50;

            y = (50 * row)+35; 
            x= (50 * column)+246;
            selectedBoardSquare=(8 * row) + column;
            if ((row % 2) == 0)
            {
                if ((selectedBoardSquare % 2) != 0)
                {
                    point = new Point(x, y);
                }
                else
                    point = new Point(-1,-1);
            }
            else
            {
                if ((selectedBoardSquare % 2) == 0)
                {
                    point = new Point(x, y);
                }
                else
                    point = new Point(-1,-1);
            }
            
                
            return point;
        }
        public void determinePieceSelected(int pbNumber)
        {
            
            pbSelected = listOfPBs[pbNumber];
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(5);
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(6);
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(7);
        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(10);
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(3);
        }

        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(9);
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(7);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(1);
        }

        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(11);
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(8);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(0);
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plyrs=Proxy.proxy.GetlistOfPlayers();

            for (int i = 0; i < plyrs.Length-1;i++)
            {
                if (plyrs.Length==1)
                {
                    lbOnlineList.Items.Add("Empty");
                }
                else
                lbOnlineList.Items.Add(plyrs[i].userName);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbOnlineList.SelectedItem != null)
            {
                if (Proxy.proxy.Invite(Proxy.myUsername, Convert.ToString(lbOnlineList.SelectedItem)))
                {
                    for (int i = 0; i < listOfPBs.Count; i++)
                    {

                        listOfPBs[i].Visible = true;


                    }
                }
            }
            else
                MessageBox.Show("Please select a user first");
        }
      

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
