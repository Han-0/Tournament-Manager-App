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

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequestor callingForm;
        public CreatePrizeForm(IPrizeRequestor caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Prize model = new Prize(
                    placeNameVal.Text,
                    placeNumberValue.Text,
                    prizeAmountVal.Text,
                    prizePercentageVal.Text);

                GlobalConfig.Connection.CreatePrize(model);

                callingForm.prizeComplete(model);

                this.Close();
                
                //placeNameVal.Text = "";
                //placeNumberValue.Text = "";
                //prizeAmountVal.Text = "0";
                //prizePercentageVal.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNum = 0;
            bool placeNumberValid = int.TryParse(placeNumberValue.Text, out placeNum);

            if (!placeNumberValid)
            {
                output = false;
            }
            if (placeNum < 1)
            {
                output = false;
            }
            if (placeNameVal.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmnt = 0;
            double prizePercentage = 0;
            bool prizeAmntValid = decimal.TryParse(prizeAmountVal.Text, out prizeAmnt);
            bool prizePercentageValid = double.TryParse(prizePercentageVal.Text, out prizePercentage);

            if (!prizeAmntValid || !prizePercentageValid)
            {
                output = false;
            }
            if (prizeAmnt <= 0 && prizePercentage <- 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100 )
            {
                output = false;
            }

            return output;
        }
    }
}
