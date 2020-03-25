using System;
using System.Collections.Generic;
using System.Text;

namespace MySportBets.Data.Model
{
    public class Bet
    {
        public int BetId { get; set; }
        public DateTime DateBet { get; set; }
        public decimal SumBet { get; set; }
        public decimal CoefBet { get; set; }
        public decimal SumWinBet { get; set; }
        public int UserId { get; set; }
        internal virtual User User { get; set; }
        public int EventId { get; set; }
        internal virtual SportEvent Event { get; set; }
        public string Team { get; set; }
    }
}
