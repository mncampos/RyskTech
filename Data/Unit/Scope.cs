using System;

namespace RyskTech.Data
{
    public class Scope
    {
        public string name;

        public bool manipulatesChemicalAgents;
        public bool manipulatesBiologicalAgents;
        public bool manipulatesPhysicalAgents;
        public bool manipulatesMechanicalAgents;

        // TODO Analysis scope goes here maybe?

        public Scope()
        {
            manipulatesChemicalAgents = false;
            manipulatesBiologicalAgents = false;
            manipulatesPhysicalAgents = false;
            manipulatesMechanicalAgents = false;
        }

        public void CheckValidity()
        {
            if (this.name == null || this.name.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.UnitWelcomeScreen + " : " + Resources.Language.pt_local.ErrorInvalidUnitName);

            if (!manipulatesBiologicalAgents && !manipulatesChemicalAgents && !manipulatesMechanicalAgents && !manipulatesPhysicalAgents)
                throw new ApplicationException(Resources.Language.pt_local.UnitWelcomeScreen + " : " + Resources.Language.pt_local.ErrorNoManipulatedAreasSelected);
        }
    }
}
