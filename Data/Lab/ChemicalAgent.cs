namespace RyskTech.Data
{
    public class ChemicalAgent
    {
        public string name;
        public string physicalState;
        public bool inert;
        public float quantity;
        public string measurementUnit;
        public string[] origin;
        public string[] dangerCharacteristics;
        public string container;
        public string storageDetails;

        public ChemicalAgent(string name, string physicalState, bool inert, float quantity, string measurementUnit, string[] origin, string[] dangerCharacteristics, string container, string storageDetails)
        {
            this.name = name;
            this.physicalState = physicalState;
            this.inert = inert;
            this.quantity = quantity;
            this.measurementUnit = measurementUnit;
            this.origin = origin;
            this.dangerCharacteristics = dangerCharacteristics;
            this.container = container;
            this.storageDetails = storageDetails;
        }
    }
}
