using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace InYourFace
{
    public partial class MainForm : Form
    {
        public bool IsGoingUp { get; set; }
        public int InternalCounter { get; set; }
        public int InternalInterval { get; set; }
        List<Player> Players { get; set; }
        ArduinoListener Arduino { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.IsGoingUp = true;
            this.InternalCounter = 0;
            this.InternalInterval = 13;
            int chosenNumber = new Random().Next() % 1000;
            this.labelChosenNumber.Text = chosenNumber.ToString();
            this.labelCurrentNumber.Text = (chosenNumber - new Random().NextDouble() % 200 + new Random().NextDouble() % 200).ToString();
            this.Players = new List<Player>() 
            {
                new Player(0, this.labelPlayer1),
                new Player(1, this.labelPlayer2),
                new Player(2, this.labelPlayer3),
                new Player(3, this.labelPlayer4)
            };
            this.Arduino = new ArduinoListener("COM3", this.Players);

            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.InternalCounter++;
            uint currentNumber = uint.Parse(this.labelCurrentNumber.Text);
            uint chosenNumber = uint.Parse(this.labelChosenNumber.Text);

            updatePlayer((int)currentNumber);
            if (true == isGameFinished())
            {
                Player loser = getLoser((int)chosenNumber);
                Debug.Print("Loser Is {0} --- shooooooot!!", loser.Id);
            }


            bool shouldDoSomething = this.InternalCounter % this.InternalInterval == 0;
            if (false == shouldDoSomething)
            {
                return;
            }

            int distance = Math.Abs((int)currentNumber - (int)chosenNumber);
            this.InternalInterval = GetNewInterval(distance);

            if (shouldChangeDirection(currentNumber, chosenNumber, this.IsGoingUp))
            {
                this.IsGoingUp = !this.IsGoingUp;
            }

            if (this.IsGoingUp)
            {
                currentNumber++;
            }
            else
            {
                currentNumber--;
            }

            this.labelCurrentNumber.Text = currentNumber.ToString();

        }

        private int GetNewInterval(int distance)
        {
            if (distance < 10)
            {
                return 3;
            }

            if (distance < 50)
            {
                return 5;
            }

            if (distance < 100)
            {
                return 8;
            }

            return 5;
        }

        private bool shouldChangeDirection(uint currentNumber, uint chosenNumber, bool isGoingUp)
        {
            int distanec = Math.Abs((int)currentNumber - (int)chosenNumber);
            bool isChosenBiggerThanCurrent = chosenNumber > currentNumber;

            //we are on the buttom!
            if (0 == currentNumber && (false == isGoingUp))
            {
                return true;
            }

            //we are on the top!
            if (1000 == currentNumber && (true == isGoingUp))
            {
                return true;
            }

            //we are too far.. lets go back quick
            if (distanec > 100)
            {
                if (false == isChosenBiggerThanCurrent)
                {
                    return isGoingUp;
                }
                else
                {
                    return !isGoingUp;
                }
            }

            double maxDistance = 100;
            double chanceToChange = (double)Math.Abs((int)(currentNumber) - (int)(chosenNumber)) / maxDistance;

            //increase the chanses to get closer..
            if (isChosenBiggerThanCurrent && (false == isGoingUp))
            {
                chanceToChange *= 1.1;
            }

            if ((false == isChosenBiggerThanCurrent) && isGoingUp)
            {
                chanceToChange *= 1.1;
            }

            return new Random().NextDouble() < chanceToChange;
        }

        private void updatePlayer(int currentNumber)
        {
            foreach (Player player in this.Players)
            {
                if (true == player.IsPressed && player.SelectedNumber == -1)
                {
                    player.SelectedNumber = currentNumber;
                    player.Label.Text = currentNumber.ToString();
                }
            }
        }

        private bool isGameFinished()
        {
            return this.Players.Count(player => player.SelectedNumber == -1) == 0;
        }

        private Player getLoser(int chosenNumber)
        {
            return this.Players.First();//this.Players.Min(player => Math.Abs(player.SelectedNumber - chosenNumber));
        }
    }

}
