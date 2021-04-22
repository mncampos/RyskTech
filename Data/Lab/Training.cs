using System;

namespace RyskTech.Data
{
    public class Training
    {
        public bool providesTraining;
        public int periodicityAmount;
        public string periodicityUnit;
        public string involvedPersonel;

        public Training() 
        {
            this.providesTraining = false;
        }

        public void CheckValidity()
        {
            if (providesTraining)
            {
                if (periodicityAmount <= 0 || periodicityUnit == null || periodicityUnit.Length <= 0)
                    throw new ApplicationException(Resources.Language.pt_local.TrainingPeriodicityNotComplete);

                if (involvedPersonel == null || involvedPersonel.Length <= 0)
                    throw new ApplicationException(Resources.Language.pt_local.TrainingPersonelNotSpecified);
            }
        }
    }
}
