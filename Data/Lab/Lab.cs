using System.Collections.Generic;

namespace RyskTech.Data
{
    public class Lab
    {
        public LabScope generalInformation;
        public Equipment safetyEquipment;
        public Training safetyTraining;
        
        public List<ChemicalAgent> manipulatedChemicalAgents;
        public Storage chemicalResidueStorageInfo;

        public Lab() { }
    }
}
