using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{

    public partial class pubMain : Form
    {
        //Globals... probably
        double steak = 13.50;
        double numOfSteak = 0;
        double steakTotal;

        double ham = 10.50;
        double numOfHam = 0;
        double hamTotal;

        double milk = 4.00;
        double numOfMilk = 0;
        double milkTotal;

        double tendered = 0;

        double tax = 0.13;

        double change = 0;

        double subTotal;
        double taxTotal;
        double total;


        public pubMain()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //If input is left blank, sets to 0
            if (steakNumInput.Text == "")
            {
                steakNumInput.Text = "0";
            }

            if (rumHamNumInput.Text == "")
            {
                rumHamNumInput.Text = "0";
            }

            if (fightMilkNumInput.Text == "")
            {
                fightMilkNumInput.Text = "0";
            }

            try
            {
                //Converts products
                numOfSteak = Convert.ToDouble(steakNumInput.Text);
                numOfHam = Convert.ToDouble(rumHamNumInput.Text);
                numOfMilk = Convert.ToDouble(fightMilkNumInput.Text);

                //Math
                subTotal = Math.Round((numOfSteak * steak) + (numOfHam * ham) + (numOfMilk * milk), 2);
                taxTotal = Math.Round(subTotal * tax, 2);
                total = Math.Round(subTotal + taxTotal, 2);

                //Text
                stPriceOutput.Text = $"{subTotal.ToString("C")}";
                taPriceOutput.Text = $"{taxTotal.ToString("C")}";
                toPriceOutput.Text = $"{total.ToString("C")}";
                 
                changeButton.Enabled = true;
            }

            catch
            {
                changeButton.Enabled = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            //Ka-Ching sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.registersound);
            player.Play(); 
            SoundPlayer poorPlayer = new SoundPlayer(Properties.Resources.hahapoor);

            try
            {
                //Converts tender 
                tenderInput.Text = Convert.ToString(Math.Round(Convert.ToDouble(tenderInput.Text), 2));
                tendered = Convert.ToDouble(tenderInput.Text);

                if (tendered < total)
                {
                    //If there isn't enough money
                    receiptLabel.Text = "\nPoor Person Alert";
                    poorPlayer.Play();

                }

                else 
                {
                    //Calculates change
                    change = tendered - total;
                    changeOutput.Text = $"{change}";
                }

                //Can't use button yet
                receiptButton.Enabled = true;
            }

            catch
            {
                receiptButton.Enabled = false;
            }

        }

        private void receiptButton_Click(object sender, EventArgs e)

        {
            //VREEBEEVREE sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptprinter);
           player.Play();

            //Receipt Text
            receiptLabel.Text += $"\n*****************************************";
            receiptLabel.Text += $"\nPaddy's Pub";
            receiptLabel.Text += $"\nFebruary 27, 2023";
            receiptLabel.Text += $"\n*****************************************";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n{numOfSteak}    Milk Steak                 {(numOfSteak * steak)}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n{numOfHam}      Rum Ham               {(numOfHam * ham)}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n{numOfMilk}     Fight Milk            {(numOfMilk * milk)}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n\n    Sub Total                 {subTotal}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n      Sales Tax               {taxTotal}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n      Total                     {total}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n\n    Cash                      ${tendered}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n\nThank you for Shopping!";
            receiptLabel.Text += $"\nDon't Come Back!";

            player.Stop();

        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            //KSSSSHHHH sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptrip);
            player.Play();
           
            steakNumInput.Text = "";
            rumHamNumInput.Text = "";
            fightMilkNumInput.Text = "";
            receiptLabel.Text = "";
            stPriceOutput.Text = "";
            taPriceOutput.Text = "";
            toPriceOutput.Text = "";
            changeOutput.Text = "";
            tenderInput.Text = "";



        }
    }
}
