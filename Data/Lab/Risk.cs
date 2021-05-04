using System;
using System.Collections.Generic;

namespace RyskTech.Data
{
    public class Risk
    {

        private static Dictionary<string, int> riskClassificationMap =
            new Dictionary<string, int>()
            {
                {"A1", 1 },
                {"A2", 1 },
                {"A3", 1 },
                {"A4", 2 },

                {"B1", 1 },
                {"B2", 1 },
                {"B3", 2 },
                {"B4", 3 },

                {"C1", 1 },
                {"C2", 2 },
                {"C3", 3 },
                {"C4", 4 },

                {"D1", 2 },
                {"D2", 3 },
                {"D3", 4 },
                {"D4", 5 },

                {"E1", 3 },
                {"E2", 4 },
                {"E3", 5 },
                {"E4", 5 }
            };

        public string description;
        public string associatedDanger;
        public string safetyNet;
        public string severityClassification;
        public string frequencyClassification;
        public int riskClassification;

        public Risk() { }

        public Risk(string description, string associatedDanger, string safetyNet, string frequencyClassification, string severityClassification)
        {
            this.description = description;
            this.associatedDanger = associatedDanger;
            this.safetyNet = safetyNet;
            this.severityClassification = severityClassification;
            this.frequencyClassification = frequencyClassification;
            if ((frequencyClassification + severityClassification).Length <= 1)
                riskClassification = -1;
            else
                this.riskClassification = riskClassificationMap[frequencyClassification + severityClassification];
        }

        public List<String> GetFormattedRiskList()
        {
            List<String> formattedRisk = new List<string>();

            formattedRisk.Add(description);
            formattedRisk.Add(associatedDanger);
            formattedRisk.Add(safetyNet);
            formattedRisk.Add(severityClassification);
            formattedRisk.Add(frequencyClassification);
            formattedRisk.Add(riskClassification.ToString());

            return formattedRisk;
        }

        public void CheckValidity()
        {
            if (this.description == null || this.description.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoRiskDescription);

            if (this.associatedDanger == null || this.associatedDanger.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoAssociatedDanger);

            if (this.severityClassification == null || this.severityClassification.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoSeverityClassification);

            if (this.frequencyClassification == null || this.frequencyClassification.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoFrequencyClassificaiton);

            if (this.riskClassification <= 0 || riskClassification >= 6)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoFrequencyClassificaiton);
        }
    }
}
