using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InYourFace
{
    public partial class Form1 : Form
    {
        public bool IsGoingUp { get; set; }
        public int InternalCounter { get; set; }
        public int InternalInterval { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.IsGoingUp = true;
            this.InternalCounter = 0;
            this.InternalInterval = 13;
            int chosenNumber = new Random().Next() % 1000;
            this.labelChosenNumber.Text = chosenNumber.ToString();
            this.labelCurrentNumber.Text = (chosenNumber - new Random().NextDouble() % 200 + new Random().NextDouble() % 200).ToString();

            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.InternalCounter++;
            bool shouldDoSomething = this.InternalCounter % this.InternalInterval == 0;
            if (false == shouldDoSomething)
            {
                return;
            }
            
            uint currentNumber = uint.Parse(this.labelCurrentNumber.Text);
            uint chosenNumber = uint.Parse(this.labelChosenNumber.Text);
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
    }
}
