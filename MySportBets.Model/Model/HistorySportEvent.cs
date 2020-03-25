using System;
using System.Collections.Generic;
using System.Text;

namespace MySportBets.Model.Model
{
    public class HistorySportEvent
    {
        public int HistoryId { get; set; }
        public int EventId { get; set; }
        public DateTime DateEvent { get; set; }
        public string Team1 { get; set; }
        public decimal Team1Coef { get; set; }
        public string Team2 { get; set; }
        public decimal Team2Coef { get; set; }
        public string Winner { get; set; }
        public string EventEnd { get; set; }
    }
}
