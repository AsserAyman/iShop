using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Design_for_Registration_and_Login
{
    class Public
    {
        public static List<Admin> admins = new List<Admin>();
        public static List<User> users = new List<User>();

        public static User user = new User();

        public static string feedbackPath = @"C:\Users\Asser Ayman\Desktop\P\Updated\Design for Registration and Login - Copy (2)\feedback.txt";
        public static string adminFilePath = @"C:\Users\Asser Ayman\Desktop\P\Updated\Design for Registration and Login - Copy (2) \Admins.txt";

        public static string userFilePath =
            @"C:\Users\Asser Ayman\Desktop\P\Updated\Design for Registration and Login - Copy (2) \Users.txt";

        public static bool isUinque(List<User> users, List<Admin> admins, string username)
        {
            foreach (var user in users)
            {
                if (user.getUsername() == username)
                {
                    return true;
                }
            }
            foreach (var admin in admins)
            {
                if (admin.getUsername() == username)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isEmailUinque(List<User> users, List<Admin> admins, string email)
        {
            foreach (var user in users)
            {
                if (user.getEmail() == email)
                {
                    return true;
                }
            }
            foreach (var admin in admins)
            {
                if (admin.getEmail() == email)
                {
                    return true;
                }
            }
            return false;
        }

        public static Admin AdminLogIn(List<Admin> admins, string username, string password)
        {
            foreach (var admin in admins)
            {
                if (admin.getUsername() == username && admin.getPassword() == password)
                {
                    return admin;
                }
            }
            return new Admin();
        }

        public static User UserLogIn(List<User> users, string username, string password)
        {
            foreach (var user in users)
            {
                if (user.getUsername() == username && user.getPassword() == password)
                {
                    return user;
                }
            }
            return new User();
        }

        public static Admin AdminRegister(
            string firstName,
            string lastName,
            string username,
            string password,
            string gender,
            string email,
            string mobile,
            string address,
            string securityQuest,
            string questAnswer,
            string age)
        {
            return new Admin(firstName, lastName, username, password, gender, email, mobile, address, securityQuest, questAnswer, age);
        }

        public static User UserRegister(
            string firstName,
            string lastName,
            string username,
            string password,
            string gender,
            string email,
            string mobile,
            string address,
            string securityQuest,
            string questAnswer,
            string age,
            string creditCard)
        {
            return new User(firstName, lastName, username, password, gender, email, mobile, address, securityQuest, questAnswer, creditCard, age);
        }
        public static Admin IdentifyAdmin(List<Admin> admins, string username, string email, string quest, string ans)
        {
            foreach (var admin in admins)
            {
                if (admin.getUsername() == username &&
                    admin.getEmail() == email &&
                    admin.getQuestion() == quest &&
                    admin.getAnswer() == ans)
                {
                    return admin;
                }
            }
            return new Admin();
        }

        public static User IdentifyUser(List<User> users, string username, string email, string quest, string ans)
        {
            foreach (var user in users)
            {
                if (user.getUsername() == username &&
                    user.getEmail() == email &&
                    user.getQuestion() == quest &&
                    user.getAnswer() == ans)
                {
                    return user;
                }
            }
            return new User();
        }

        public static void LoadData()
        {

            /*
             * ****************
             * Load Admins Data
             * ****************
             */

            var adminAllLines = File.ReadAllLines(adminFilePath);
            foreach (var line in adminAllLines)
            {
                if (line == "")
                    break;
                string[] tokens = line.Split('|');
                admins.Add(new Admin(
                    tokens[0].ToString(),tokens[1],tokens[2],tokens[3], tokens[4], tokens[5], tokens[6], tokens[7], tokens[8], tokens[9], tokens[10]
                    ));
            }

            /*
             * ***************************
             * reading users data
             * ***************************
             */
            var usersAllLines = File.ReadAllLines(userFilePath);

            foreach (var line in usersAllLines)
            {
                if (line == "")
                    break;
                string[] tokens = line.Split('|');
                users.Add(new User(
                    tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], tokens[7], tokens[8], tokens[9], tokens[10],tokens[11]
                    ));
            }
        }

        public static void SaveData()
        {

            /*
             * ***************
             * save for admins
             * ***************
             */

            var AdminLines = new string[admins.Count];
            var i = 0;
            foreach (var admin in admins)
            {
                AdminLines[i] += admin.getFirstName() +'|'+ admin.getLastName()+ '|' + admin.getUsername() + '|' + admin.getPassword() +'|'+
                              admin.getGender() + '|' + admin.getEmail() +'|' + admin.getMobile() +'|' + admin.getAddress() +'|' +
                              admin.getQuestion() + '|' + admin.getAnswer() + '|' + admin.getAge() +'\n';
                i++;
            }
            File.WriteAllLines(adminFilePath,AdminLines);
                        
             /* ***************
             * save for users
             * ***************
             */
            var Userlines = new string[users.Count];
            i = 0;
            foreach (var user in users)
            {
                Userlines[i] += user.getFirstName() + '|' + user.getLastName() + '|' + user.getUsername() + '|' + user.getPassword() + '|' +
                                user.getGender() + '|' + user.getEmail() + '|' + user.getMobile() + '|' + user.getAddress() + '|' +
                                user.getQuestion() + '|' + user.getAnswer() + '|' + user.getCredit() +'|' + user.getAge() + '\n';
                i++;
            }
            File.WriteAllLines(userFilePath, Userlines);

        }
    }
}
