using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyskTech.Data 
{ 

    public class RiskAnalysis
    {
        public List<Risk> identifiedRisks;
        public string conclusion;
        public string recomendations;
        public string accidents;

        public RiskAnalysis() { }

        public void CheckValidity()
        {
            if (conclusion == null || conclusion.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoConclusion);
        }
    }
}
