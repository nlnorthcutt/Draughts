using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Forms;
using System.Drawing;

namespace Draghts
{
    static public class Proxy 
    {
        static public Form2 login;
        static public Form1 loddy;
        static public string myUsername;
       static public MyClass callback = new MyClass();
       static public InstanceContext context = new InstanceContext(callback);
       static public DraughtsServiceReference.PortalClient proxy = new DraughtsServiceReference.PortalClient(context);
   
    }

    public class MyClass:DraughtsServiceReference.IPortalCallback
	{
        
        public void OnLoggingInOrOut1(DraughtsServiceReference.Player[] players)
        {
            Proxy.loddy.lbOnlineList.Items.Clear();
            foreach (DraughtsServiceReference.Player pl in players)
            {
                Proxy.loddy.lbOnlineList.Items.Add(pl.userName);
            }
            
        }
        public bool OnInvitation(string sender, DraughtsServiceReference.Player pl)
        {
            if (MessageBox.Show(sender + " has invited you to play,Do you want to play?", "Invitation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < Proxy.loddy.listOfPBs.Count; i++)
                {
                    Proxy.loddy.listOfPBs[i].Visible = true;

                } 

                return true;
                
            }
            else
            {
                return false;

            }

        }
        public void loadGame()
        {
            for (int i = 0; i < Proxy.loddy.listOfPBs.Count; i++)
            {
              
                Proxy.loddy.listOfPBs[i].Visible = true;

              
            }

        }
        public void updateChanges(int pbIndex, int xPos, int yPos)
        {
            Point newPosition=new Point(xPos,yPos);
            Proxy.loddy.listOfPBs[pbIndex].Location= newPosition;
            Proxy.loddy.listOfBoardSquares[pbIndex] = 0;

        }
		
	}
    static class PortalProxy
    {
        //static public MyClass callback = new MyClass();
        static public DraughtsServiceReference.GamePlayClient proxy = new DraughtsServiceReference.GamePlayClient();

    }
}
