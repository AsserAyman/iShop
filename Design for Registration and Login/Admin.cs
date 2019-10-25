using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_for_Registration_and_Login
{
    public class Admin
    {
        private string firstName;
        private string lastName;
        private string email;
        private string mobile;
        private string address;
        private string securityQuest;
        private string questAnswer;
        private string gender;
        private string userName;
        private string password;
        private string age;

        public Admin()
        {

        }

        public Admin(
            string firstName,
            string lastName,
            string userName,
            string password,
            string gender,
            string email,
            string mobile,
            string address,
            string securityQuest,
            string questAnswer,
            string age
            )
        {
            this.password = password;
            this.address = address;
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.gender = gender;
            this.email = email;
            this.mobile = mobile;
            this.securityQuest = securityQuest;
            this.questAnswer = questAnswer;
        }
        public string getUsername()
        {
            return userName;
        }

        public string getPassword()
        {
            return password;
        }
        public string getEmail()
        {
            return email;
        }

        public string getAnswer()
        {
            return questAnswer;
        }

        public string getQuestion()
        {
            return securityQuest;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }
        public string getMobile()
        {
            return mobile;
        }

        public string getAddress()
        {
            return address;
        }

        public string getGender()
        {
            return gender;
        }

        public string getAge()
        {
            return age;
        }


        //setters
        public void setPassword(string password)
        {
            this.password = password;
        }
        
    }
}
