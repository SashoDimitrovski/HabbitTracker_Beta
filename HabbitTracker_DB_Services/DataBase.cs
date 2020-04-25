using System;
using HabbitTracker_Domain;
namespace HabbitTracker_DB_Services
{
    
    public class DataBase
    {
        public Person[] Users;
        public DataBase()
        {
            Users = new Person[]
            {
                new Person()
                {
                FirstName = "Sasho",
                LastName = "Dimitrovski",
                Email = "sasodimitrovski1982@yahoo.com",
                DateOfBirth =
                UserName = "SashoDim",

                }
        };
            
        }

        public string UserName { get; private set; }
    }
}
