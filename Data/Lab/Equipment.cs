using System;

namespace RyskTech.Data
{
    public class Equipment
    {
        public bool[] EPCS; // areia, vermiculita, cal, pa, capela, exaustor, outros
        public string otherEPC;
        public bool[] EPIS; // oculos, mureta, luva, dosimetro, po, mascara, outros
        public string otherEPI;
        public string maskEPI;
        public bool[] firstAidObjects; // gaze, tesoura, agua, fita, outros
        public string otherFirstAid;
        public bool noFirstAid = false;

        public Equipment()
        {
            this.EPCS = new bool[7];
            this.EPIS = new bool[7];
            this.firstAidObjects = new bool[5];

            for (int i = 0; i < 7; i++)
            {
                this.EPCS[i] = false;
                this.EPIS[i] = false;
                if (i < 5)
                    this.firstAidObjects[i] = false;
            }
        }

        public void CheckValidity()
        {
            if (EPCS[6] && (otherEPC == null || otherEPC.Length <= 0))
                throw new ApplicationException(Resources.Language.pt_local.OtherNotSpecified);

            if (EPIS[6] && (otherEPI == null || otherEPI.Length <= 0))
                throw new ApplicationException(Resources.Language.pt_local.OtherNotSpecified);

            if (firstAidObjects[4] && (otherFirstAid == null || otherFirstAid.Length <= 0))
                throw new ApplicationException(Resources.Language.pt_local.OtherNotSpecified);
        }
    }
}
