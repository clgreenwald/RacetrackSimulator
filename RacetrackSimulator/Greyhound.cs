using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RacetrackSimulator
{
    class Greyhound
    {
        public int StartingPosition;    //Where my PictureBox starts
        public int RacetrackLength;     //How long the racetrack is
        public PictureBox MyPictureBox = null;  //MyPictureBox object
        public int Location = 0;    //My Location on the racetrack
        public Random Randomizer;   //An instance of Random

        public bool Run()
        {
            //Move forward either 1, 2, 3, of 4 spaces at random
            //Update the position of my PictureBox on the form
            //Return true if I won the race
            //Randomizer = new Random();
            int distance = Randomizer.Next(1, 5);

            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;

            if (MyPictureBox.Location.X + MyPictureBox.Width >= RacetrackLength)
            {
                return true;
            }

            return false;
        }

        public void TakeStartingPosition()
        {
            //Reset my location to the start line
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}
