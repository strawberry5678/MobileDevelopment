using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace App1
{
    public class DatabaseHelper
    {
        SQLiteConnection database;


        public class User
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

            public string mobileNumber { get; set; } 

            public string gender { get; set; }

            public string currentAccountBalance { get; set; }

            public string savingsAccountBalance { get; set; }
       
        }


        public DatabaseHelper(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
        database.CreateTable<User>(); // Example: Creating a table for users
        }

    // Insert a new user record into the database
    public void InsertUser(User user)
    {
        database.Insert(user);
    }

    // Query all users from the database
    public List<User> GetAllUsers()
    {
        return database.Table<User>().ToList();
    }


        public bool IsEmailExists(string email)
        {
            return database.Table<User>().Any(u => u.Email == email);
        }

        // Authenticate a user during login
        public bool AuthenticateUser(string email, string password)
        {
            var user = database.Table<User>().FirstOrDefault(u => u.Email == email && u.Password == password);
            return user != null;
        }
    }
}
