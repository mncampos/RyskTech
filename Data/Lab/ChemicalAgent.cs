using System;

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

        public ChemicalAgent() { }

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

        public void CheckValidity()
        {
            if (name == null || name.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidAgentName);

            if (physicalState == null || physicalState.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidPhysicalState);

            if (quantity <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidAgentQuantity);

            if (measurementUnit == null || measurementUnit.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidAgentMeasureUnit);

            if (storageDetails == null || storageDetails.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidAgentContainer);
        }
    }
}
