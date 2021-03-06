﻿namespace StarPeru
{
    public class Afo
    {
        public string Origin { get; }
        public string Departure { get; }
        public string OutboundYear { get; }
        public string OutboundMonth { get; }
        public string OutboundDay { get; }
        public string InboundYear { get; }
        public string InboundMonth { get; }
        public string InboundDay { get; }
        public char CabinClass { get; }
        public bool IsRt { get; }

        public Afo(string[] searchCriteria)
        {
            Origin = searchCriteria[0];
            Departure = searchCriteria[1];
            OutboundYear = searchCriteria[2];
            OutboundMonth = searchCriteria[3];
            OutboundDay = searchCriteria[4];
            InboundYear = searchCriteria[5];
            InboundMonth = searchCriteria[6];
            InboundDay = searchCriteria[7];
            CabinClass = searchCriteria[8].ToCharArray()[0];
            IsRt = searchCriteria[9].Equals("R") ? true : false; 
        }
    }
}
