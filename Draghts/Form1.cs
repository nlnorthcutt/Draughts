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
using System.Diagnostics;


namespace Draghts
{
    public partial class Form1 : Form 
    {
        //private DraughtsServiceReference.GamePlayClient proxy;
        //private DraughtsServiceReference.PortalClient proxy2;
        bool gameStarted = true;
        public List<int> listOfBoardSquares = new List<int>();

        private DraughtsServiceReference.Player[] plyrs;
        public List<PictureBox>listOfPBs=new List<PictureBox>();
        public bool pieceSelected = false;
        int selectedBoardSquare;
        int permanentSelectedBoardSquare;
        PictureBox pbSelected;
        public int pbIndex;
        public Stopwatch stopWatch = new Stopwatch();
        public int myScore=0, myOpponentsScore=0;
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
           
            //white
                
                listOfBoardSquares[1] = 5;
                listOfBoardSquares[3] = 6;
                listOfBoardSquares[5] = 7;
                listOfBoardSquares[7] = 10;
                listOfBoardSquares[9] = 3;
                listOfBoardSquares[11] = 9;
                listOfBoardSquares[13] = 4;
                listOfBoardSquares[15] = 1;
                listOfBoardSquares[17] = 12;
                listOfBoardSquares[19] = 8;
                listOfBoardSquares[21] = 0;
                listOfBoardSquares[23] = 2;

            
           
            //black
               
                listOfBoardSquares[41] = 12;
                listOfBoardSquares[43] = 19;
                listOfBoardSquares[45] = 23;
                listOfBoardSquares[47] = 22;
                listOfBoardSquares[49] = 14;
                listOfBoardSquares[51] = 16;
                listOfBoardSquares[53] = 13;
                listOfBoardSquares[55] = 18;
                listOfBoardSquares[57] = 15;
                listOfBoardSquares[59] = 21;
                listOfBoardSquares[61] = 20;
                listOfBoardSquares[63] = 17;

           
            
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
                        if (System.Math.Abs(pbSelected.Location.Y - newPost.Y) <= 100)
                        {
                            if (System.Math.Abs(pbSelected.Location.Y - newPost.Y) <= 50)
                            {
                                pbSelected.Location = newPost;
                                PortalProxy.proxy.makeMove(pbIndex, Proxy.myUsername, newPost.X, newPost.Y);
                                for (int i = 0; i < listOfBoardSquares.Count; i++)
                                {
                                    if (listOfBoardSquares[i] == pbIndex)
                                    {
                                        listOfBoardSquares[i] = 0;
                                    }
                                }
                                listOfBoardSquares[selectedBoardSquare] = pbIndex;
                            }
                            else
                            {
                                Point newPost1;
                                if (newPost.X < pbSelected.Location.X&&newPost.Y>pbSelected.Location.Y)
                                {
                                    newPost1 = new Point(newPost.X + 50, newPost.Y - 50);
                                }
                                else if(newPost.X>pbSelected.Location.X&&newPost.Y>pbSelected.Location.Y)
                                {
                                    newPost1 = new Point(newPost.X - 50, newPost.Y - 50);
                                }
                                else if (pbSelected.Location.Y > newPost.Y&&pbSelected.Location.X>newPost.X)
                                {
                                    newPost1 = new Point(newPost.X - 50, newPost.Y - 50);
                                }
                                else
                                {
                                    newPost1 = new Point(newPost.X + 50, newPost.Y - 50);
                                }
                                
                                calculateBoardSquareAtPost2(newPost1);
                                if (listOfBoardSquares[selectedBoardSquare] != 0)
                                {
                                    pbSelected.Location = newPost;
                                    PortalProxy.proxy.makeMove(pbIndex, Proxy.myUsername, newPost.X, newPost.Y);
                                    for (int i = 0; i < listOfBoardSquares.Count; i++)
                                    {
                                        if (listOfBoardSquares[i] == pbIndex)
                                        {
                                            listOfBoardSquares[i] = 0;
                                        }
                                    }
                                    MessageBox.Show("Check!");
                                    listOfPBs[listOfBoardSquares[selectedBoardSquare]].Visible=false;
                                    myScore++;
                                    Proxy.proxy.updateScore(Proxy.myUsername,listOfBoardSquares[selectedBoardSquare]);
                                    label1.Text = Proxy.myUsername + ": " + myScore;
                                    listOfBoardSquares[permanentSelectedBoardSquare] = pbIndex;

                                }
                                else
                                    MessageBox.Show("Move not allowed!");
                            }
                        }
                        else
                        {


                        }
                    }
                    else
                        MessageBox.Show("Do not move to white space!");
                }
                else
                    MessageBox.Show("The space is already taken!");
            }
          
        }
        public void calculateBoardSquareAtPost2(Point pt)
        {
            int row, column;
        

            column = (pt.X-246) / 50;
            row = (pt.Y-35) / 50;

          
            selectedBoardSquare = (8 * row) + column;
          
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
            permanentSelectedBoardSquare = (8 * row) + column;

            if ((row % 2) == 0)
            {
                if ((selectedBoardSquare % 2) != 0)
                {
                    point = new Point(x, y);
                }
                else
                    point = new Point(-1, -1);
            }
            else
            {
                if ((selectedBoardSquare % 2) == 0)
                {
                    point = new Point(x, y);
                }
                else
                    point = new Point(-1, -1);
            }


            return point;
            //return pt;
        }
        public void determinePieceSelected(int pbNumber)
        {
            pbIndex = pbNumber;
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
            determinePieceSelected(4);
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
            if (PortalProxy.proxy.sendMessage(Proxy.myUsername, this.tbMessage.Text))
            {
                Proxy.loddy.listBox1.Items.Add(this.tbMessage.Text);
            }
            else
            {
                MessageBox.Show("Message not sent!");
            }

        }

        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(12);
        }

        private void pictureBox21_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(19);
        }

        private void pictureBox26_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(23);
        }

        private void pictureBox25_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(22);
        }

        private void pictureBox16_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(14);
        }

        private void pictureBox18_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(16);
        }

        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(13);
        }

        private void pictureBox20_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(18);
        }

        private void pictureBox17_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(15);
        }

        private void pictureBox23_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(21);
        }

        private void pictureBox22_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(20);
        }

        private void pictureBox19_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(17);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PortalProxy.proxy.quitGame(Proxy.myUsername,Proxy.myUsername+" just quit :-(");
        }
    }
}
