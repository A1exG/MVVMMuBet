﻿using System;
using System.Collections.Generic;

namespace MySportBets.Model.Model
{
    public class SportEvent
    {
        public int SportEventId { get; set; }
        public DateTime DateEvent { get; set; }
        public string Category { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public decimal Coef1 { get; set; }
        public decimal Coef2 { get; set; }
        internal virtual ICollection<Bet> Bets { get; set; }

        public SportEvent(DateTime dateEvent, string category, string team1, decimal coef1, string team2, decimal coef2)
        {
            DateEvent = dateEvent;
            Category = category;
            Team1 = team1;
            Coef1 = coef1;
            Team2 = team2;
            Coef2 = coef2;
        }
        public SportEvent()
        {

        }

    }
}

