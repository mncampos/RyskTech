using System;

namespace RyskTech.Data
{
    public class ChemicalAgent
    {
        public string name;
        public string casNumber;
        public string physicalState;
        public float quantity;
        public string measurementUnit;
        public string origin;
        public string dangerCharacteristics;
        public string container;
        public string storageDetails;

        public ChemicalAgent() { }

        public ChemicalAgent(string name, string physicalState, float quantity, string measurementUnit, string origin, string dangerCharacteristics, string container, string storageDetails, string casNumber)
        {
            this.name = name;
            this.physicalState = physicalState;
            this.quantity = quantity;
            this.measurementUnit = measurementUnit;
            this.origin = origin;
            this.dangerCharacteristics = dangerCharacteristics;
            this.container = container;
            this.storageDetails = storageDetails;
            this.casNumber = casNumber;
        }

        public ChemicalAgent(string name, float quantity, string measurementUnit,string casNumber)
        {
            this.name = name;            
            this.quantity = quantity;
            this.measurementUnit = measurementUnit;
            this.casNumber = casNumber;
        }

        public void CheckValidity()
        {
            if (name == null || name.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidAgentName);

            if (quantity <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidAgentQuantity);

            if (measurementUnit == null || measurementUnit.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidAgentMeasureUnit);

            if (casNumber == null || casNumber.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorInvalidCasNumber);
        }

        public void CheckValidity2()
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

            if (origin == null || origin.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoAgentOrigin);
        }
    }
}
