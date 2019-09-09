using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    class Guy
    {
        public string Name; //The guy's name
        public Bet MyBet;   //An instance of Bet() that has his bet
        public int Cash;    //How much cash he has

        //The last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton;   //My RadioButton
        public Label MyLabel;   //My Label

        public void UpdateLabels()
        {
            //Set my label to my bet's description, and the label on my
            //radio button to show my cash ("Joe has 43 bucks")
            MyRadioButton.Text = Name + " has " + Cash + " bucks";

            if (MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();
            }
        }

        public void ClearBet()
        {
            if (MyBet != null)
            {
                MyBet.Amount = 0;
            }
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            //Place a new bet and store it in my bet field
            //Return true if the guy had enough money to bet
            MyBet = new Bet();
            MyBet.Bettor = this;
            bool canBet = false;

            if (Cash >= Amount)
            {
                MyBet.Amount = Amount;
                MyBet.Dog = Dog;
                MyBet.Bettor = this;
                canBet = true;
            }
            else
            {
                ClearBet();
                MessageBox.Show(Name + " doesn't have enough cash for that bet.");
            }
            UpdateLabels();
            return canBet;
        }

        public void Collect(int Winner)
        {
            //Ask my bet to pay out
            if (MyBet != null)
            {
                Cash += MyBet.PayOut(Winner);
            }
        }
    }
}
