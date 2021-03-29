using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyskTech
{
    class SafetyInformation
    {
        // Equipment
        public bool[] EPCS; // areia, vermiculita, cal, pa, capela, exaustor, outros
        public string otherEPC;
        public bool[] EPIS; // oculos, mureta, luva, dosimetro, po, mascara, outros
        public string otherEPI;
        public string maskEPI;
        public bool[] firstAidObjects; // gaze, tesoura, agua, fita, outros
        public string otherFirstAid;
        public bool noFirstAid = false;

        // Training
        public bool providesTraining;

        public int periodicityAmount;
        public string periodicityUnit;

        public string involvedPersonel;

        public SafetyInformation()
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
    }
}
