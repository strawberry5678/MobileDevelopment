using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


/* Lungile Shongwe 
 * Purpose:  On this Page the user can view his or her account balance.
 */
namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewAccountBalancePage : ContentPage
	{
		public ViewAccountBalancePage ()
		{
			InitializeComponent ();


            BindingContext = this;

            // Setting  the initial account balance values
            CurrentAccountBalance = 5000;
            SavingsAccountBalance = 10000;

        }


        public double CurrentAccountBalance { get; set; }
        public double SavingsAccountBalance { get; set; }

        private async void OnBackToMainPageClicked(object sender, EventArgs e)
        {
            // Navigate back to the main page
            await Navigation.PopAsync();
        }


    }
}