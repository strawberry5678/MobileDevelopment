using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*Lungile Shongwe 
 * Purpose:. Its purpose is to facilitate secure access to the application's features and content by verifying the identity 
 */

namespace App1
{
    // This class represents the login user interface
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        // This method is called when the login button is clicked
        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Check if email or password fields are empty
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                // Display an error alert if either field is empty
                await DisplayAlert("Error", "Please enter email and password.", "OK");
                return;
            }

            // Check if the entered email is in a valid format
            if (!IsValidEmail(txtEmail.Text))
            {
                // Display an error alert if the email format is invalid
                await DisplayAlert("Error", "Invalid Email format.", "OK");
                return;
            }

            // Authenticate the user with entered credentials
            bool isAuthenticated = AuthenticateUser(txtEmail.Text, txtPassword.Text);

            if (isAuthenticated)
            {
                // Navigate to the main page upon successful login
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                // Display an error alert if the entered credentials are incorrect
                await DisplayAlert("Oops...", "Username or Password is incorrect!", "Ok");
            }
        }

        // This method performs user authentication based on predefined email and password
        private bool AuthenticateUser(string email, string password)
        {
            // Define predefined email and password
            string predefinedEmail = "user@example.com";
            string predefinedPassword = "password";

            // Check if the entered email and password match the predefined values
            return email == predefinedEmail && password == predefinedPassword;
        }

        // This method validates the format of an email address using a regular expression
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }

        // This method is called when the register label is tapped
        private async void OnRegisterLabelTapped(object sender, EventArgs e)
        {
            // Navigate to the registration page
            await Navigation.PushAsync(new RegistrationPage());
        }

     
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }
    }
}

