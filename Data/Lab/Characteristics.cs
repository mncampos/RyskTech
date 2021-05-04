using System;

namespace RyskTech.Data
{
    public class Characteristics
    {
        public string responsiblePersonName;
        public string responsiblePersonContact;
        public string responsiblePersonOccupation;

        public string building;
        public string room;

        public string usageCharacterization;

        public Characteristics() { }

        public void CheckValidity()
        {
            if (responsiblePersonName == null || responsiblePersonName.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidName);

            if (responsiblePersonContact == null || responsiblePersonContact.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidPhoneNumber);

            if (responsiblePersonOccupation == null || responsiblePersonOccupation.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoOccupation);

            if (building == null || building.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidSpaceBuilding);

            if (room == null || room.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidSpaceRoom);

            if (usageCharacterization == null || usageCharacterization.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoUsageDescription);
        }
    }
}
