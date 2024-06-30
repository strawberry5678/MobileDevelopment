using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string userFirstName = GetCurrentUserFirstName();
            welcomeLabel.Text = $"Welcome, {userFirstName}!";
        }

        private async void OnViewAccountBalanceClicked(object sender, EventArgs e)
        {
            // Navigating to the View Account Balance page
            await Navigation.PushAsync(new ViewAccountBalancePage());
        }

        private async void OnTransferBetweenAccountsClicked(object sender, EventArgs e)
        {
            // Navigating to the Transfer Between Accounts page
            await Navigation.PushAsync(new TransferBetweenAccountsPage());
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // logout action 
            
            await Navigation.PopToRootAsync();
        }

        private string GetCurrentUserFirstName()
        {
         
            return "Lungile"; 
        }







    }
}
