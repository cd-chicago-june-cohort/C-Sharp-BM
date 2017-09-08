using System;
using System.Collections.Generic;
using DbConnection;

namespace simpleCRUD
{
    class Program
    {
        public static void getUser(){
            List<Dictionary<string, object>> users = new List<Dictionary<string, object>>();

            users = DbConnector.Query("select * from Users");

            Console.WriteLine("All users in database:");
            foreach (Dictionary<string, object> allUsers in users)
            {
                Console.WriteLine(" - " + allUsers["FirstName"] + " - ID:" + allUsers["id"]);
            }
        }

        public static void addUser(){
            Console.WriteLine("Enter new user's first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter new user's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter new user's favorite number");
            int favoriteNumber = Int32.Parse(Console.ReadLine());
            DbConnector.Execute($"insert into Users(FirstName, LastName, FavoriteNumber) values('{firstName}', '{lastName}', '{favoriteNumber}')");
            Console.WriteLine($"Successfully added {firstName} {lastName} to the database");
            getUser();
        }
        public static void updateUser(){
            Console.WriteLine("Enter the id of the user you wish to update");
            int userID = Int32.Parse(Console.ReadLine());
            Dictionary<string, object> user = DbConnector.Query($"select * from users where id = {userID}")[0];
            Console.WriteLine("Currently, this user information is as follows:");
            Console.WriteLine("{0} {1}'s favorite number is {2}", user["FirstName"], user["LastName"], user["FavoriteNumber"]);
            Console.WriteLine("Update the user's first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Update the user's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Update the user's favorite number");
            int favoriteNumber = Int32.Parse(Console.ReadLine());
            DbConnector.Execute($"update Users set FirstName='{firstName}' where id={userID}");
            getUser();
        }
        public static void deleteUser(){
            Console.WriteLine("Enter the id of the user you wish you delete");
            int userID = Int32.Parse(Console.ReadLine());
            DbConnector.Execute($"DELETE FROM users WHERE id = {userID}");
            getUser();
        }
        static void Main(string[] args){
            // addUser("Chris", "Fields", 25);
            
            getUser();
            updateUser();
            addUser();
            deleteUser();
    
        }

    }
}