using System;

namespace RyskTech.Data
{
    public class Storage
    {
        public bool NBRCompliant;
        public string residueDestination;
        public string storageDescription;

        public Storage()
        {
            this.NBRCompliant = false;
        }

        public void CheckValidity()
        {
            if (residueDestination == null || residueDestination.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueDestination);

            if (storageDescription == null || storageDescription.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueStorageDescription);
        }
    }
}
