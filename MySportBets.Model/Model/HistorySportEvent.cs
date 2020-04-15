using System;

namespace MySportBets.Model.Model
{
    public class HistorySportEvent
    {
        public int HistorySportEventId { get; set; }
        public int SportEventId { get; set; }
        public DateTime DateEvent { get; set; }
        public string Team1 { get; set; }
        public decimal Coef1 { get; set; }
        public string Team2 { get; set; }
        public decimal Coef2 { get; set; }
        public string Winner { get; set; }
        public string EventEnd { get; set; }
        internal virtual SportEvent SportEvent { get; set; }

        public HistorySportEvent(int eventId, DateTime dateEvent, string team1, decimal coef1, string team2, decimal coef2, string winner, string eventEnd)
        {
            SportEventId = eventId;
            DateEvent = dateEvent;
            Team1 = team1;
            Coef1 = coef1;
            Team2 = team2;
            Coef2 = coef2;
            Winner = winner;
            EventEnd = eventEnd;
        }

        public HistorySportEvent()
        {

        }
    }
}
