using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MySportBets.Model.Model
{
    [DataContract]
    public class Bet
    {
        [DataMember]
        public int BetId { get; set; }
        [DataMember]
        public DateTime DateBet { get; set; }
        [DataMember]
        public decimal SumBet { get; set; }
        [DataMember]
        public decimal CoefBet { get; set; }
        [DataMember]
        public decimal SumWinBet { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        internal virtual User User { get; set; }
        [DataMember]
        public int SportEventId { get; set; }
        [DataMember]
        internal virtual SportEvent Event { get; set; }
        [DataMember]
        public string Team { get; set; }

        public Bet(DateTime dateBet, decimal sumBet, decimal coefBet, decimal sumWinBet, int userId, int eventId, string team)
        {
            DateBet = dateBet;
            SumBet = sumBet;
            CoefBet = coefBet;
            SumWinBet = sumWinBet;
            UserId = userId;
            SportEventId = eventId;
            Team = team;
        }
        public Bet()
        {

        }
    }
}
