using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MySportBets.Model.Model
{
    [DataContract]
    public class HistorySportEvent
    {
        [DataMember]
        public int HistorySportEventId { get; set; }
        [DataMember]
        public int SportEventId { get; set; }
        [DataMember]
        internal virtual SportEvent SportEvent { get; set; }
        [DataMember]
        public DateTime DateEvent { get; set; }
        [DataMember]
        public string Team1 { get; set; }
        [DataMember]
        public decimal Coef1 { get; set; }
        [DataMember]
        public string Team2 { get; set; }
        [DataMember]
        public decimal Coef2 { get; set; }
        [DataMember]
        public string Winner { get; set; }
        [DataMember]
        public string EventEnd { get; set; }

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
