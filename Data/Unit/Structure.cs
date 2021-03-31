using System;
using System.Collections.Generic;

namespace RyskTech.Data
{
    public class Structure
    {
        public List<Space> spaces;
        public string surroundingsDetails;

        public Structure() { }

        public void CheckValidity()
        {
            if (spaces.Count <= 0)
                throw new ApplicationException(Resources.Language.pt_local.NoSpacesAdded);

            foreach (Space space in spaces)
                space.CheckValidity();

            if (surroundingsDetails == null || surroundingsDetails.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.NoSurroundingsDetailsAdded);        
        }
    }
}
