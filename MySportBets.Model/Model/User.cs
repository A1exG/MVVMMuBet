using System;
using System.Collections.Generic;

namespace MySportBets.Model.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public DateTime Birthday { get; set; }
        public string UserLogin { get; set; }
        public string UserPass { get; set; }
        public string Role { get; set; }
        public decimal Balance { get; set; }
        internal virtual ICollection<Bet> Bets { get; set; }
        public User(string userLogin, string userPassword, string name, string secondName, string surName, DateTime birthday, string role, decimal balance)
        {
            UserLogin = userLogin;
            UserPass = userPassword;
            Name = name;
            SecondName = secondName;
            SurName = surName;
            Birthday = birthday;
            Role = role;
            Balance = balance;
        }
        public User(string userLogin, string userPass)
        {
            UserLogin = userLogin;
            UserPass = userPass;
        }

        public User(string userLogin)
        {
            UserLogin = userLogin;
        }

        public User()
        {

        }
    }
}
