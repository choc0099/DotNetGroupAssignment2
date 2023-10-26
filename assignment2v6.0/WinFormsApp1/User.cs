using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment2
{
    class User
    {
        string username, password, fname, lname, dob, email, phone, address;

        public User(string username, string password, string fname, string lname, string email, string phone, string address, string dob)
        {
            this.username = username;
            this.password = password;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.dob = dob;
            StreamWriter file = new StreamWriter("login.txt", true);
            file.WriteLine(username + "," + password);
            file.Close();
        }

        public string getUsername()
        {
            return this.username;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return this.password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getfname()
        {
            return this.fname;
        }
        public void setfname(string fname)
        {
            this.fname = fname;
        }
        public string getlname()
        {
            return this.username;
        }
        public void setlname(string lname)
        {
            this.lname = lname;
        }

        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getPhone()
        {
            return this.phone;
        }
        public void setPhone(string phone)
        {
            this.dob = phone;
        }

        public string getAddress()
        {
            return this.address;
        }
        public void setAddress(string address)
        {
            this.dob = address;
        }
        public string getdob()
        {
            return this.dob;
        }
        public void setDob(string dob)
        {
            this.dob = dob;
        }
        //---------------------------------------

        public List<User> getUsers()
        {
            String[] userInfo = System.IO.File.ReadAllLines("login.txt");
            List<User> users = new List<User>();

            try
            {
                foreach (string i in userInfo)
                {
                    string[] temp = i.Split(',');
                    for (int g = 0; g < temp.Length; g = g + 6)
                    {
                        User user = new User(temp[g], temp[g + 1], temp[g + 2], temp[g + 3], temp[g + 4], temp[g + 5], temp[g+6], temp[g+7]);
                        users.Add(user);
                        //user.printUser();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            return users;
        }



    }
}
