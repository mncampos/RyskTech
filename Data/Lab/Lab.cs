using System.Collections.Generic;

namespace RyskTech.Data
{
    public class Lab
    {
        public LabScope generalInformation;
        public Characteristics spaceCharacterization;
        public Equipment safetyEquipment;
        public Training safetyTraining;

        public List<ChemicalResidue> manipulatedChemicalResidues;
        public List<ChemicalReactor> manipulatedChemicalReactors;
        public float riskIndice; //Risco geral
        public Storage chemicalResidueStorageInfo;

        public BiologicalInfo biologicalAgentsInfo;
        public string biologicalAgentsStorage;
        public string biologicalAgentsDestination;

        public List<PhysicalAgent> physicalAgentsInfo;

        public List<MechanicalAgent> mechanicalAgentsInfo;

        public RiskAnalysis riskAnalysisInformation;

        public Lab() { }
    }
}
