using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public partial class frmRaceTrackSim : Form
    {
        Guy[] guys = new Guy[3];
        Greyhound[] dogs = new Greyhound[4];

        public frmRaceTrackSim()
        {
            InitializeComponent();
        }

        private void frmRaceTrackSim_Load(object sender, EventArgs e)
        {
            lblMinBet.Text = lblMinBet.Text + " " + nudBetAmt.Minimum.ToString() + " bucks";

            guys[0] = new Guy() { Name = "Joe", MyBet = null, Cash = 50, MyRadioButton = rdoJoe, MyLabel = lblJoeBet };
            guys[1] = new Guy() { Name = "Bob", MyBet = null, Cash = 75, MyRadioButton = rdoBob, MyLabel = lblBobBet };
            guys[2] = new Guy() { Name = "Al", MyBet = null, Cash = 45, MyRadioButton = rdoAl, MyLabel = lblAlBet };

            for (int i = 0; i < guys.Length; i++)
            {
                guys[i].UpdateLabels();
            }

            dogs[0] = new Greyhound() { StartingPosition = pbDog1.Location.X, RacetrackLength = pbRacetrack.Width, MyPictureBox = pbDog1, Location = 1, Randomizer = new Random() };
            dogs[1] = new Greyhound() { StartingPosition = pbDog2.Location.X, RacetrackLength = pbRacetrack.Width, MyPictureBox = pbDog2, Location = 2, Randomizer = new Random() };
            dogs[2] = new Greyhound() { StartingPosition = pbDog3.Location.X, RacetrackLength = pbRacetrack.Width, MyPictureBox = pbDog3, Location = 3, Randomizer = new Random() };
            dogs[3] = new Greyhound() { StartingPosition = pbDog4.Location.X, RacetrackLength = pbRacetrack.Width, MyPictureBox = pbDog4, Location = 4, Randomizer = new Random() };
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            if (rdoJoe.Checked)
            {
                guys[0].PlaceBet((int)nudBetAmt.Value, (int)nudDogNum.Value);
            }
            else if (rdoBob.Checked)
            {
                guys[1].PlaceBet((int)nudBetAmt.Value, (int)nudDogNum.Value);
            }
            else
            {
                guys[2].PlaceBet((int)nudBetAmt.Value, (int)nudDogNum.Value);
            }
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            btnBets.Enabled = false;
            btnRace.Enabled = false;
            bool isWinner = false;
            int dogWinningNum = 0;

            while (!isWinner)
            {
                //for (int i = 0; i < dogs.Length; i++)
                //{
                Random Randomizer = new Random();
                int randDog = Randomizer.Next(4);
                isWinner = dogs[randDog].Run();
                if (isWinner)
                {
                    dogWinningNum = dogs[randDog].Location;
                }
                //}
                System.Threading.Thread.Sleep(1);
            }

            MessageBox.Show("We have a winner - dog #" + dogWinningNum + "!");

            for (int i = 0; i < guys.Length; i++)
            {
                guys[i].Collect(dogWinningNum);
                guys[i].ClearBet();
                guys[i].UpdateLabels();
            }

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].TakeStartingPosition();
            }

            btnBets.Enabled = true;
            btnRace.Enabled = true;
        }

        private void rdoJoe_CheckedChanged(object sender, EventArgs e)
        {
            lblBettor.Text = guys[0].Name;
        }

        private void rdoBob_CheckedChanged(object sender, EventArgs e)
        {
            lblBettor.Text = guys[1].Name;
        }

        private void rdoAl_CheckedChanged(object sender, EventArgs e)
        {
            lblBettor.Text = guys[2].Name;
        }
    }
}
