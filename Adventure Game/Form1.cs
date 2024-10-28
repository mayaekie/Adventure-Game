using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        //Tracks what page the user is at
        int page = 1;

        public Form1()
        {
            InitializeComponent();

            // Display initial message and options

            outputLabel.Text = "You wander upon a diner. Go inside?";
            option1Label.Text = "Yes";
            option2Label.Text = "No";
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 1;
            }


            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You're lost in a forest";
                    option1Label.Text = "Go North";
                    option2Label.Text = "Go South";

                    break;
                case 2:
                    outputLabel.Text = "You find a lake. Take a drink?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 3:
                    outputLabel.Text = "You fall in a pit and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "The water is foul. You die of cholera. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You find a horse. Do you ride it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "You tame the horse and ride to safety. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "The horse walks past and you die of loneliness. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 8:
                    outputLabel.Text = "You jump over a chasm to freedom. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing !!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
    }
    
}
