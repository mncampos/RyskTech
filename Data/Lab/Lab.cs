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
        public Storage chemicalResidueStorageInfo;

        public Lab() { }
    }
}
