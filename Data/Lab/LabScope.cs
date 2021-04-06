using System;

namespace RyskTech.Data
{
    public class LabScope
    {
        public string belongingUnitName;
        public string labName;

        public bool manipulatesChemicalAgents;
        public bool manipulatesBiologicalAgents;
        public bool manipulatesPhysicalAgents;
        public bool manipulatesMechanicalAgents;


        public LabScope() 
        {
            manipulatesChemicalAgents = false;
            manipulatesBiologicalAgents = false;
            manipulatesPhysicalAgents = false;
            manipulatesMechanicalAgents = false;
        }

        public void CheckValidity()
        {
            if (this.belongingUnitName == null || this.belongingUnitName.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorInvalidUnitName);

            if (this.labName == null || this.labName.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorInvalidLabName);

            if (!manipulatesBiologicalAgents && !manipulatesChemicalAgents && !manipulatesMechanicalAgents && !manipulatesPhysicalAgents)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoManipulatedAreasSelected);
        }
    }
}
