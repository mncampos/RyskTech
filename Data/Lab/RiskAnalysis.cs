using System;
using System.Collections.Generic;

namespace RyskTech.Data
{

    public class RiskAnalysis
    {
        public List<Risk> identifiedRisks;
        public string conclusion;
        public string recomendations;
        public string accidents;

        public RiskAnalysis() { }

        public List<List<String>> GetFormattedRiskList()
        {
            List<List<String>> formattedList = new List<List<String>>();

            for (int i = 0; i < identifiedRisks.Count; i++)
                formattedList.Add(identifiedRisks[i].GetFormattedRiskList());

            return formattedList;
        }

        public void CheckValidity()
        {
            if (conclusion == null || conclusion.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoConclusion);
        }
    }
}
