/*
Hugh Dunnem
ICS3U
Cash Register Project
March 1, 2023
*/

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
        //Globals
        double steak = 13.50;
        double numOfSteak = 0;

        double ham = 10.50;
        double numOfHam = 0;

        double milk = 4.00;
        double numOfMilk = 0;

        double tendered = 0;

        double tax = 0.13;

        double change = 0;

        double subTotal;
        double taxTotal;
        double total;


        public pubMain()
        {
            InitializeComponent();

            //Parent function to align receipt prices
            receiptAmountLabel.Parent = receiptLabel;
            receiptAmountLabel.Location = new Point(150, 70);

            amountLabel.Parent = receiptLabel;
            amountLabel.Location = new Point(10, 70);
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
                numOfSteak = Math.Abs(Convert.ToDouble(steakNumInput.Text));
                numOfHam = Math.Abs(Convert.ToDouble(rumHamNumInput.Text));
                numOfMilk = Math.Abs(Convert.ToDouble(fightMilkNumInput.Text));

                steakNumInput.Text = $"{numOfSteak.ToString()}";
                rumHamNumInput.Text = $"{numOfHam.ToString()}";
                fightMilkNumInput.Text = $"{numOfMilk.ToString()}";

                //Math
                subTotal = Math.Round((numOfSteak * steak) + (numOfHam * ham) + (numOfMilk * milk), 2);
                taxTotal = Math.Round(subTotal * tax, 2);
                total = Math.Round(subTotal + taxTotal, 2);

                //Text
                stPriceOutput.Text = $"{subTotal.ToString("C")}";
                taPriceOutput.Text = $"{taxTotal.ToString("C")}";
                toPriceOutput.Text = $"{total.ToString("C")}";
                
                //Can't use button yet
                changeButton.Enabled = true;
            }

            catch
            {
                changeButton.Enabled = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            //Ka-Ching sound (cash register sound)
            SoundPlayer player = new SoundPlayer(Properties.Resources.registersound);
            player.Play(); 

            //Laugh track
            SoundPlayer poorPlayer = new SoundPlayer(Properties.Resources.hahapoor);

            try
            {
                //Converts tender 
                tenderInput.Text = Convert.ToString(Math.Round(Convert.ToDouble(tenderInput.Text), 2));
                tendered = Convert.ToDouble(tenderInput.Text);

                if (tendered < total)
                {
                    //If there isn't enough money
                    poorPlayer.Play();
                    errorLabel.Refresh();
                    Thread.Sleep(850);
                    errorLabel.Text = "POOR PERSON ALERT";
                    errorLabel.ForeColor = Color.White;
                    errorLabel.BackColor= Color.Red;

                    errorLabel.Refresh();
                    Thread.Sleep(2000);
                    
                    //Resets inputs
                    errorLabel.Text = "";
                    errorLabel.BackColor = Color.Transparent;
                    steakNumInput.Text = "";
                    rumHamNumInput.Text = "";
                    fightMilkNumInput.Text = "";
                    stPriceOutput.Text = "";
                    taPriceOutput.Text = "";
                    toPriceOutput.Text = "";
                    changeOutput.Text = "";
                    tenderInput.Text = "";
                    numOfHam = 0;
                    numOfSteak = 0;
                    numOfMilk = 0;

                    poorPlayer.Stop();


                }

                else 
                {
                    //Calculates change
                    change = Math.Round(tendered - total, 2);
                    changeOutput.Text = $"${change}";
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
            //VREEBEEVREE sound (receipt print)
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptprinter);
           player.Play();

            //Receipt Text
            receiptLabel.Text = $"\n*******************************************";
            receiptLabel.Text += $"\n                Paddy's Pub";
            receiptLabel.Text += $"\n             February 27, 2023";
            receiptLabel.Text += $"\n*******************************************";
            receiptLabel.Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n\n              Milk Steak";
            receiptAmountLabel.Text += $"\n\n${(numOfSteak * steak)}";
            amountLabel.Text += $"\n\n{numOfSteak}";
            receiptLabel.Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n              Rum Ham";
            receiptAmountLabel.Text += $"\n${(numOfHam * ham)}";
            amountLabel.Text += $"\n{numOfHam}";
            receiptLabel.Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n              Fight Milk";
            receiptAmountLabel.Text += $"\n${(numOfMilk * milk)}";
            amountLabel.Text += $"\n{numOfMilk}";
            receiptLabel.Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n\n              Sub Total";
            receiptAmountLabel.Text += $"\n\n${subTotal}";
            receiptLabel.Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n              Sales Tax";
            receiptAmountLabel.Text += $"\n${taxTotal}";
            receiptLabel.Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n              Total";
            receiptAmountLabel.Text += $"\n${total}";
            receiptLabel.Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n\n              Cash";
            receiptAmountLabel.Text += $"\n\n${tendered}";
            receiptLabel.Text += $"\n              Change";
            receiptAmountLabel.Text += $"\n${change}";
            receiptLabel.Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n\n\n       Thank you for Shopping!";
            receiptLabel.Text += $"\n            Don't Come Back!";

            player.Stop();

        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            //KSSSSHHHH sound (receipt rip)
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptrip);
            player.Play();
            
            //Resets receipt
            steakNumInput.Text = "";
            rumHamNumInput.Text = "";
            fightMilkNumInput.Text = "";
            receiptLabel.Text = "";
            stPriceOutput.Text = "";
            taPriceOutput.Text = "";
            toPriceOutput.Text = "";
            changeOutput.Text = "";
            tenderInput.Text = "";
            receiptAmountLabel.Text = "";
            amountLabel.Text = "";
            numOfHam = 0;
            numOfSteak = 0;
            numOfMilk = 0;




        }
    }
}
