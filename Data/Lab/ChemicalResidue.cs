namespace RyskTech.Data
{
    public class ChemicalResidue : ChemicalAgent
    {
        public bool dangerous;
        public bool inert;

        public ChemicalResidue() 
        {
        }

        public ChemicalResidue(string name, string physicalState, bool inert, float quantity, string measurementUnit, string[] origin, bool dangerous, string[] dangerCharacteristics, string container, string storageDetails)
        {
            this.name = name;
            this.physicalState = physicalState;
            this.inert = inert;
            this.quantity = quantity;
            this.measurementUnit = measurementUnit;
            this.origin = origin;
            this.dangerous = dangerous;
            this.dangerCharacteristics = dangerCharacteristics;
            this.container = container;
            this.storageDetails = storageDetails;
        }
    }
}
