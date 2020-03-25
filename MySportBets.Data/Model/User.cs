using System;
using System.Collections.Generic;

namespace MySportBets.Data.Model
{
    public abstract class User
    {
        public int UserId { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public DateTime Birthday { get; set; }
        public string UserLogin { get; set; }
        public string UserPass { get; set; }
        internal virtual ICollection<Bet> Bets { get; set; }
        public abstract string Role { get; }

    }
    public sealed class Administrator : User
    {
        public override string Role
        {
            get
            {
                return "Administrator";
            }
        }
    }
    public sealed class ProgrammUser : User
    {
        public decimal Balance { get; set; }
        public override string Role
        {
            get
            {
                return "ProgrammUser";
            }
        }
    }

}
