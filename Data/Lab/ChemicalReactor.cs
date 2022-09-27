namespace RyskTech.Data
{
    public class ChemicalReactor : ChemicalAgent
    {        
        public string mixtureDescription;
        public bool inert;
        public float dangerFactor; //Facot de perigo FEPAM
        public float riskIndice; //Índice de risco FEPAM


        public ChemicalReactor()
        {

        }

        public ChemicalReactor(string name, float quantity, string measurementUnit, string casNumber)
        {
            this.name = name;
            this.casNumber = casNumber;
            this.quantity = quantity;
            this.measurementUnit = measurementUnit;
            
        }

        public ChemicalReactor(string name, string physicalState, float quantity, string measurementUnit, string origin, string casNumber, string mixtureDescription, string dangerCharacteristics, string container, string storageDetails, bool inert, float riskIndice)
        {
            this.name = name;
            this.physicalState = physicalState;
            this.casNumber = casNumber;
            this.quantity = quantity;
            this.measurementUnit = measurementUnit;
            this.origin = origin;
            this.mixtureDescription = mixtureDescription;
            this.dangerCharacteristics = dangerCharacteristics;
            this.container = container;
            this.storageDetails = storageDetails;
            this.inert = inert;
            this.dangerFactor = riskIndice;
        }
    }
}
