﻿using System;
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
       private IPrizeRequester _callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            _callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNameTextBox.Text,
                                                  placeNumberTextBox.Text,
                                                  prizeAmountTextBox.Text,
                                                  prizePercentageTextBox.Text);
   
                GlobalConfig.Connection?.CreatePrize(model);

                _callingForm.PrizeComplete(model);

                this.Close();
               
                //placeNameTextBox.Text = "";
                //placeNumberTextBox.Text = "";
                //prizeAmountTextBox.Text = "0";
                //prizePercentageTextBox.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(placeNumberTextBox.Text, out placeNumber);

            if (placeNumberValid == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageTextBox.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
