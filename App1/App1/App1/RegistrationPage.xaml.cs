using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


/*Lungile Shongwe
 * Purpose: To facilitate the creation of new user accounts and provide information such as their email address, desired username, password.*/
namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            //  validatio
            if (string.IsNullOrWhiteSpace(firstNameEntry.Text) ||
                string.IsNullOrWhiteSpace(lastNameEntry.Text) ||
                string.IsNullOrWhiteSpace(emailEntry.Text) ||
                string.IsNullOrWhiteSpace(passwordEntry.Text) ||
                string.IsNullOrWhiteSpace(mobileEntry.Text) ||
                genderPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }

            // Performing further validation such as email format
            if (!IsValidEmail(emailEntry.Text))
            {
                await DisplayAlert("Error", "Please enter a valid email address.", "OK");
                return;
            }

            // Performoing additional validation as per requirements (e.g., password length)
            if (passwordEntry.Text.Length < 5)
            {
                await DisplayAlert("Error", "Password must be at least five characters long.", "OK");
                return;
            }


           /* var newUser = new DatabaseHelper.User
            {
                FirstName = firstNameEntry.Text,
                LastName = lastNameEntry.Text,
                Email = emailEntry.Text,
                Password = passwordEntry.Text,
                mobileNumber = mobileEntry.Text,
                gender = genderPicker.SelectedItem.ToString()
            };*/

//  App.Database.InsertUser(newUser);

await DisplayAlert("Success", "Registration successful!", "OK");

            // Navigate to the login page after successful registration
            await Navigation.PushAsync(new LoginUI());
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Navigating to the login page
            await Navigation.PushAsync(new LoginUI());
        }

        private bool IsValidEmail(string email)
        {
            //email validation
            return !string.IsNullOrWhiteSpace(email) && email.Contains("@") && email.Contains(".");
        }
    }
}