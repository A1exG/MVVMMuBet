using System;
using System.Collections.Generic;
using System.Text;

namespace MySportBets.Model.Model
{
    public class SportEvent
    {
        public int SportEventId { get; set; }
        public DateTime DateEvent { get; set; }
        public virtual string Category {get;}
        internal virtual ICollection<Bet> Bets { get; set; }
        public virtual string Team1 { get; set; }
        public virtual string Team2 { get; set; }
        public decimal Coef1 { get; set; }
        public decimal Coef2 { get; set; }

        public SportEvent(DateTime dateEvent, string category, string team1, decimal coef1, string team2, decimal coef2)
        {
            DateEvent = dateEvent;
            Category = category;
            Team1 = team1;
            Coef1 = coef1;
            Team2 = team2;
            Coef2 = coef2;
        }
    }
    //public class FootbolEvents : SportEvent
    //{
    //    public override string Category
    //    {
    //        get
    //        {
    //            return "Footbol";
    //        }
    //    }
    //    public override string Team1
    //    {
    //        get
    //        {
    //            return "Team1";
    //        }
    //        set
    //        {
    //            Team1 = value;
    //        }
    //    }

    //    public override string Team2
    //    {
    //        get
    //        {
    //            return "Team2";
    //        }
    //        set
    //        {
    //            Team2 = value;
    //        }
    //    }

    //}
    //public class TennisEvents : SportEvent
    //{
    //    public override string Category
    //    {
    //        get
    //        {
    //            return "Tennis";
    //        }
    //    }

    //    public override string Team1
    //    {
    //        get
    //        {
    //            return "Player1";
    //        }
    //        set
    //        {
    //            Team1 = value;
    //        }
    //    }

    //    public override string Team2
    //    {
    //        get
    //        {
    //            return "Player2";
    //        }
    //        set
    //        {
    //            Team2 = value;
    //        }
    //    }
    
}
