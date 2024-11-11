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
                Random randGen = new Random();
                int randomValue = randGen.Next(1, 101);

                if (randomValue > 70)
                {
                    page = 4;
                }
                else
                {
                    page = 5;
                }
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
                page = 8;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 99)
            {
                Close();
            }

            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You wander upon a diner. Go inside?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 2:
                    outputLabel.Text = "An old woman greets you and brings you a menu. What do you order?";
                    option1Label.Text = "Milkshake";
                    option2Label.Text = "Coffee";

                    break;
                case 3:
                    outputLabel.Text = "You turn around and get hit by a car. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "It was poisoned and you die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You enjoy your drink and ask for the bill. How much do you tip?";
                    option1Label.Text = "Nothing";
                    option2Label.Text = "2.00$";
                    break;
                case 6:
                    outputLabel.Text = "The old lady gets upset and kills you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "You pay and leave. It's getting dark out, " +
                        "do you call a taxi or walk home?";
                    option1Label.Text = "Call a Taxi";
                    option2Label.Text = "Walk Home";
                    break;
                case 8:
                    outputLabel.Text = "You get lost and eaten by wolves. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    outputLabel.Text = "You call a taxi and wait for it to arrive." +
                        "While you're driving, you notice this isn't the way to your house." +
                        "Do you mention this?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "Your driver apologizes for the mistake and turns around." +
                        "Once you're home you get ready for bed. You hear a noise. Do you ignore it?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 11:
                    outputLabel.Text = "You get kidnapped and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "Trying to find the noise, you trip down the stairs and break your neck." +
                        "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "You ignore it and fall asleep. The next day you wakeup and get ready " +
                        "for work. As you're leaving you grab a snack. What do you choose?";
                    option1Label.Text = "Apple";
                    option2Label.Text = "Muffin";
                    break;
                case 14:
                    outputLabel.Text = "You choke and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "You enjoy the muffin on your drive. While approaching a traffic light" +
                        "it turns yellow. Do you speed up or slow down?";
                    option1Label.Text = "Speed thru";
                    option2Label.Text = "Slow down";
                    break;
                case 16:
                    outputLabel.Text = "You get in an accident and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "You stop at the light and safely make it to work." +
                        "Congrats!! Play again?";

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

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 99;
            }

            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You wander upon a diner. Go inside?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 2:
                    outputLabel.Text = "An old woman greets you and brings you a menu. What do you order?";
                    option1Label.Text = "Milkshake";
                    option2Label.Text = "Coffee";

                    break;
                case 3:
                    outputLabel.Text = "You turn around and get hit by a car. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "It was poisoned and you die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You enjoy your drink and ask for the bill. How much do you tip?";
                    option1Label.Text = "Nothing";
                    option2Label.Text = "2.00$";
                    break;
                case 6:
                    outputLabel.Text = "The old lady gets upset and kills you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "You pay and leave. It's getting dark out, " +
                        "do you call a taxi or walk home?";
                    option1Label.Text = "Walk Home";
                    option2Label.Text = "Call a Taxi";
                    break;
                case 8:
                    outputLabel.Text = "You get lost and eaten by wolves. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    outputLabel.Text = "You call a taxi and wait for it to arrive." +
                        "While you're driving, you notice this isn't the way to your house." +
                        "Do you mention this?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "Your driver apologizes for the mistake and turns around." +
                        "Once you're home you get ready for bed. You hear a noise. Do you ignore it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 11:
                    outputLabel.Text = "You get kidnapped and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "Trying to find the noise, you trip down the stairs and break your neck." +
                        "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "You ignore it and fall asleep. The next day you wakeup and get ready " +
                        "for work. As you're leaving you grab a snack. What do you choose?";
                    option1Label.Text = "Apple";
                    option2Label.Text = "Muffin";
                    break;
                case 14:
                    outputLabel.Text = "You choke and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "You enjoy the muffin on your drive. While approaching a traffic light" +
                        "it turns yellow. Do you speed up or slow down?";
                    option1Label.Text = "Speed thru";
                    option2Label.Text = "Slow down";
                    break;
                case 16:
                    outputLabel.Text = "You get in an accident and die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "You stop at the light and safely make it to work." +
                        "Congrats!! Play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing !!";
                    option1Label.Text = "Close Program";
                    option2Label.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}
    
    

