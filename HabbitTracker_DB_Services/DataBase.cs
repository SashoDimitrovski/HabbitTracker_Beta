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
                DateOfBirth = new DateTime(1982,3,29),
                UserName = "SashoDim",
                Password = "trackthis"

                },
                new Person
                {
                FirstName = "Steve",
                LastName = "Harris",
                Email = "steveharris@imaiden.com",
                DateOfBirth = new DateTime(1956,3,12),
                UserName = "SashoDim",
                Password = "trackthis"
                }

             };


            
        }





        
    }
    
}
