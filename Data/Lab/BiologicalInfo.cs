using System;
using System.Collections.Generic;

namespace RyskTech.Data
{
    public class BiologicalInfo
    {
        public List<BiologicalAgent> biologicalAgentList;
        public List<String> processedSamples;
        public bool hasOGM;
        public bool hasBioSecurityCertificate;
        public string SISGEN;


        public BiologicalInfo()
        {
            biologicalAgentList = new List<BiologicalAgent>();
            processedSamples = new List<String>();
        }

        public void CheckValidity()
        {
            if (biologicalAgentList.Count <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoBiologicalAgents);
        }
    }
}
