using System;

namespace RyskTech.Data
{
    public class Storage
    {
        public bool NBRCompliant;
        public string residueDestination;
        public string storageDescription;
        public bool FISPQCompliant;
        public string FISPQExplanation;

        public Storage()
        {
            this.NBRCompliant = false;
            this.FISPQCompliant = false;
        }

        public void CheckValidity()
        {
            if (residueDestination == null || residueDestination.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueDestination);

            if (storageDescription == null || storageDescription.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueStorageDescription);

            if (FISPQCompliant && (FISPQExplanation == null || FISPQExplanation.Length <= 0))
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoFISPQExplanation) ;
        }
    }
}
