using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace App1
{
    public partial class App : Application
    {

      // public static DatabaseHelper Database { get; private set; }
        public App()
        {

            InitializeComponent();


            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db3");
            DatabaseHelper dbHelper = new DatabaseHelper(dbPath);

            //InitializeComponent();
            //  MainPage = new MainPage();

            MainPage = new NavigationPage(new LoginUI());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
