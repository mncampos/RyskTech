using System;

namespace RyskTech.Data
{
    public class Space
    {
        public string buildingIdentifier;
        public string roomIdentifier;
        public string floorIdentifier;
        public TimeSpan turnStart;
        public TimeSpan turnEnd;

        public Space() { }

        public Space(string buildingId, string roomId, string floorId, TimeSpan startTime, TimeSpan endTime)
        {
            this.buildingIdentifier = buildingId;
            this.roomIdentifier = roomId;
            this.floorIdentifier = floorId;
            this.turnStart = startTime;
            this.turnEnd = endTime;
        }
    }
}
