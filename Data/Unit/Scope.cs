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
    }
}
