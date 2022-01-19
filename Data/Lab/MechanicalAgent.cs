using System;

namespace RyskTech.Data
{
    public class MechanicalAgent
    {
        public string name;
        public string associatedRisk;
        public string additionalInfo;

        public MechanicalAgent() { }

        public MechanicalAgent(string name, string associatedRisk, string additionalInfo)
        {
            this.name = name;
            this.associatedRisk = associatedRisk;
            this.additionalInfo = additionalInfo;
        }

        public void CheckValidity()
        {
            if (name == null || name.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoAgentName);

            if (associatedRisk == null || associatedRisk.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoAssociatedDanger);
        }
    }
}
