using System;
using System.Collections.Generic;
using System.Text;

namespace MySportBets.Data.Model
{
    public abstract class SportEvent
    {
        public int EventId { get; set; }
        public DateTime DateEvent { get; set; }
        public abstract string Category {get;}
        internal virtual ICollection<Bet> Bets { get; set; }
    }
    public sealed class FootbolEvents : SportEvent
    {
        public string Team1 { get; set; }
        public decimal Team1Coef { get; set; }
        public string Team2 { get; set; }
        public decimal Team2Coef { get; set; }
        public override string Category
        {
            get
            {
                return "Footbol";
            }
        }
    }
    public sealed class TennisEvents : SportEvent
    {
        public string Player1 { get; set; }
        public decimal Player1Coef { get; set; }
        public string Player2 { get; set; }
        public decimal Player2Coef { get; set; }
        public override string Category
        {
            get
            {
                return "Tennis";
            }
        }
    }
}
