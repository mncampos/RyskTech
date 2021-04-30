using System;

namespace RyskTech.Data
{
    public class Storage
    {
        public bool NBRCompliant;
        public string residueDestination;
        public bool FISPQCompliant;

        public Storage()
        {
            this.NBRCompliant = false;
            this.FISPQCompliant = false;
        }

        public void CheckValidity()
        {
            if (residueDestination == null || residueDestination.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueDestination);
        }
    }
}
