using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MySportBets.Model.Model
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SecondName { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
        [DataMember]
        public string UserLogin { get; set; }
        [DataMember]
        public string UserPass { get; set; }
        [DataMember]
        public string Role { get; set; }
        [DataMember]
        public decimal Balance { get; set; }
        [DataMember]
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
