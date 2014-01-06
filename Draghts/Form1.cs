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
        private DraughtsServiceReference.Piece[] pieces;
        private DraughtsServiceReference.Player[] plyrs;
        private List<PictureBox>listOfPBs=new List<PictureBox>();
        public bool pieceSelected = false;
        int selectedBoardSquare;
        PictureBox pbSelected;
        private DraughtsServiceReference.Piece selectedPiece;
        public Form1()
        {
            Proxy.loddy = this;
            InitializeComponent();
            //proxy = new DraughtsServiceReference.GamePlayClient(new InstanceContext(this));
            //proxy2 = new DraughtsServiceReference.PortalClient(new InstanceContext(this));
            //proxy2.Subscribe();

            
            pieces = PortalProxy.proxy.getPieceList();
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
        //public void OnLoggingInOrOut1(DraughtsServiceReference.Player[] players)
        //{
        //    lbOnlineList.Items.Clear();
        //    foreach (DraughtsServiceReference.Player pl in players)
        //    {
        //        lbOnlineList.Items.Add(pl.userName);
        //    }

        //}


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
                        PortalProxy.proxy.changeLocation(selectedPiece, newPost.X, newPost.Y);
                    }
                    else
                        MessageBox.Show("Do not move to white space!");
                }
                else
                    MessageBox.Show("The space is already taken!");
            }
            //if (gameStarted)
            //{
            //    if (listOfBoardSquares[calculateBoardSquareAtPost(e.Location)] == 1)
            //    {
            //            for (int i = 0; i < 64; i++)
            //            {
            //                if (pieces[i].CorrespondingBS == listOfBoardSquares[calculateBoardSquareAtPost(e.Location)])
            //                {
            //                    selectedPiece = pieces[i];
            //                    for (int j = 0; j < 24; j++)
            //                    {

            //                        if (listOfPBs[j].Location.X == pieces[i].XCoordinate && listOfPBs[j].Location.Y == pieces[i].YCoordinate)
            //                        {
            //                            pbSelected=listOfPBs[j];
            //                            pbLocation = listOfPBs[j].Location;
            //                            pieceSelected = true;
            //                        }
                                   
            //                    }


            //                }
            //            }
                    
                  
            //    }
            //    else
            //    {
            //        pbSelected.Location = e.Location;
            //        proxy.changeLocation(selectedPiece, pbSelected.Location.X, pbSelected.Location.Y);
            //    }
            //}
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
        public void determinePieceSelected(int pieceNumber,int pbNumber)
        {
            selectedPiece = pieces[pieceNumber];
            pbSelected = listOfPBs[pbNumber];
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(0,5);
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(1,6);
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(2, 7);
        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(3, 10);
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(4, 3);
        }

        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(5, 9);
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(6, 7);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(7, 1);
        }

        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(8, 11);
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(9, 8);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(10, 0);
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            determinePieceSelected(11, 2);
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
                Proxy.proxy.Invite(Proxy.myUsername,Convert.ToString(lbOnlineList.SelectedItem));
            }
            else
                MessageBox.Show("Please select a user first");
        }
        public void loadGame()
        {
            for (int i = 0; i < listOfPBs.Count; i++)
            {
                listOfPBs[i].Visible = true;
            }

        }
    }
}
