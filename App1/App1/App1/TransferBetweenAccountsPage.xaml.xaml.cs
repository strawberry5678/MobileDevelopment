using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*Lungile Shongwe 
 * Purpose: Transfers Between Accounts being made successfully
 */

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransferBetweenAccountsPage : ContentPage
	{
		public TransferBetweenAccountsPage ()
		{
			InitializeComponent ();
		}

		 private async void OnTransferClicked(object sender, EventArgs e)
        {
            // Getting the amount to transfer from the entry field
            if (!double.TryParse(amountEntry.Text, out double amount))
            {
                await DisplayAlert("Error", "Please enter a valid amount.", "OK");
                return;
            }

            // Determining the transfer direction
            string transferDirection = directionPicker.SelectedItem as string;
            if (string.IsNullOrEmpty(transferDirection))
            {
                await DisplayAlert("Error", "Please select a transfer direction.", "OK");
                return;
            }

            // Performing  the transfer based on the selected direction
            if (transferDirection == "From Current to Savings")
            {
                // current account to savings account
               
                await DisplayAlert("Success", $"Transferred ${amount} from Current to Savings.", "OK");
            }
            else if (transferDirection == "From Savings to Current")
            {
                // from savings account to current account
            
                await DisplayAlert("Success", $"Transferred ${amount} from Savings to Current.", "OK");
            }

            // Clearing entry field after transfer
            amountEntry.Text = string.Empty;
        }




	}
}