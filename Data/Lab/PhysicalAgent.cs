using System;
using System.Collections.Generic;

namespace RyskTech.Data
{
    public class PhysicalAgent
    {
        public string equipment;
        public string usage;
        public string generatedRisks;

        public PhysicalAgent() { }

        public PhysicalAgent(string equipment, string usage, string generatedRisks)
        {
            this.equipment = equipment;
            this.usage = usage;
            this.generatedRisks = generatedRisks;
        }

        public void CheckValidity()
        {
            if (equipment == null || equipment.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoAgentName);

            if (usage == null || usage.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoAgentUsage);

            if (generatedRisks == null || generatedRisks.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoAssociatedDanger);
        }
    }
}
