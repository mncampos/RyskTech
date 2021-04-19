using System;
using System.Collections.Generic;

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

        public List<String> getEPCS()
        {
            List<String> usedEpcs = new List<String>();
            if (EPCS[0])
                usedEpcs.Add("Caixa de areia");

            if (EPCS[1])
                usedEpcs.Add("Caixa de vermiculita");

            if (EPCS[2])
                usedEpcs.Add("Caixa de cal");

            if (EPCS[3])
                usedEpcs.Add("Pá");

            if (EPCS[4])
                usedEpcs.Add("Capela");

            if (EPCS[5])
                usedEpcs.Add("Exaustor");

            if (EPCS[6])
                usedEpcs.Add(otherEPC);
            
            return usedEpcs;
        }

        public List<String> getEPIS()
        {
            List<String> usedEpis = new List<String>();
            if (EPIS[0])
                usedEpis.Add("Óculos");

            if (EPIS[1])
                usedEpis.Add("Mureta de chumbo");

            if (EPIS[2])
                usedEpis.Add("Luvas");

            if (EPIS[3])
                usedEpis.Add("Dosímetro");

            if (EPIS[4])
                usedEpis.Add("Guarda-pó");

            if (EPIS[5])
                usedEpis.Add(maskEPI);

            if (EPIS[6])
                usedEpis.Add(otherEPI);

            return usedEpis;
        }

        public List<String> getFirstAidObjects()
        {
            List<String> firstAid = new List<String>();

            if (firstAidObjects[0])
                firstAid.Add("Gaze");

            if (firstAidObjects[1])
                firstAid.Add("Tesoura");

            if (firstAidObjects[2])
                firstAid.Add("Água boricada");

            if (firstAidObjects[3])
                firstAid.Add("Fita microporo");

            if (firstAidObjects[4])
                firstAid.Add("otherFirstAid");

            return firstAid;
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
