﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Admin
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;

        public Admin(int id, string firstName, string lastName, string email, string password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
        }

        public int Id { 
            get => id; 
            set => id = value; 
        }
        public string FirstName { 
            get => firstName; 
            set => firstName = value; 
        }
        public string LastName { 
            get => lastName; 
            set => lastName = value; 
        }
        public string Email {
            get => email; 
            set => email = value; 
        }
        public string Password { 
            get => password; 
            set => password = value; 
        }
    }
}
