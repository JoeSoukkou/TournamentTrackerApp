using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text,
                    PlaceNumberValue.Text,
                    PrizeAmountValue.Text,
                    PrizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);
                
                PlaceNameValue.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This is an Invalid Form ! Please Check it and try Again !");
            }
            
        }
        private bool ValidateForm()
        {
            bool output = true;
            int PlaceNumber = 0;
            bool isPlaceNumberValid = int.TryParse(PlaceNumberValue.Text, out PlaceNumber);
            //Check if Place Number is Invalid 
            if (isPlaceNumberValid == false) 
            {
                output = false;
            }
            if (PlaceNumber < 1)
            {
                output = false;
            }
            //Check if Place Name is Invalid
            if (PlaceNameValue.Text.Length == 0) 
            {
                output = false;
            }
            decimal PrizeAmount = 0;
            double PrizePercentage = 0;

            bool isPrizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out PrizeAmount);
            bool isPrizePercentageValid = double.TryParse(PrizePercentageValue.Text, out PrizePercentage);

            //Check if Prize Amount / Percentage are Invalid
            if (isPrizeAmountValid  == false|| isPrizePercentageValid == false)
            {
                output = false;
            }
            if (PrizeAmount <= 0 && PrizePercentage <= 0)
            {
                output = false;
            }
            if (PrizePercentage < 0 || PrizePercentage > 100 )
            {
                output = false;
            }
            return output;
            

        }
    }
}
