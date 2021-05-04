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
        public string surroundingsComments;
        public string weekDays;

        public Space() { }

        public Space(string buildingId, string roomId, string floorId, TimeSpan startTime, TimeSpan endTime, string weekDays)
        {
            this.buildingIdentifier = buildingId;
            this.roomIdentifier = roomId;
            this.floorIdentifier = floorId;
            this.turnStart = startTime;
            this.turnEnd = endTime;
            this.weekDays = weekDays;
        }

        public void CheckValidity()
        {
            if (buildingIdentifier == null || buildingIdentifier.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidSpaceBuilding);

            if (roomIdentifier == null || roomIdentifier.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidSpaceRoom);

            if (floorIdentifier == null || floorIdentifier.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidSpaceFloor);

            if (turnStart == null || turnEnd == null)
                throw new ApplicationException(Resources.Language.pt_local.InvalidUsageTurn);

            if (weekDays == null || weekDays.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.NoUsageDays);
        }
    }
}
