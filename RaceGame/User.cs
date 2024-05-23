using System;
using System.Collections.Generic;
using System.Linq;
namespace Race
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set;}
        public int Coins { get; set; }
        public DateTime Date { get; set; }

        public User()
        {
            
        }

        public User(string name) 
        {
            Name = name;              
        }   
        


    }
}
