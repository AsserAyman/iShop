using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_for_Registration_and_Login
{
    public class User : Admin
    {
        private string creditCard;

        public User()
        {

        }

        public User(
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
            string creditCard,
            string age

            ) : base(firstName, lastName, userName, password, gender, email, mobile, address, securityQuest, questAnswer, age)
        {
            this.creditCard = creditCard;
        }

        public string getCredit()
        {
            return creditCard;
        }

    }
}
