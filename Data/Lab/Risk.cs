using System;
using System.Collections.Generic;

namespace RyskTech.Data
{
    public class Risk
    {

        private static Dictionary<Tuple<string, string>, int> riskClassificationMap =
            new Dictionary<Tuple<string, string>, int>()
            {
                {new Tuple<string, string>("A","1"), 1 },
                {new Tuple<string, string>("A","2"), 1 },
                {new Tuple<string, string>("A","3"), 1 },
                {new Tuple<string, string>("A","4"), 2 },

                {new Tuple<string, string>("B","1"), 1 },
                {new Tuple<string, string>("B","2"), 1 },
                {new Tuple<string, string>("B","3"), 2 },
                {new Tuple<string, string>("B","4"), 3 },

                {new Tuple<string, string>("C","1"), 1 },
                {new Tuple<string, string>("C","2"), 2 },
                {new Tuple<string, string>("C","3"), 3 },
                {new Tuple<string, string>("C","4"), 4 },

                {new Tuple<string, string>("D","1"), 2 },
                {new Tuple<string, string>("D","2"), 3 },
                {new Tuple<string, string>("D","3"), 4 },
                {new Tuple<string, string>("D","4"), 5 },

                {new Tuple<string, string>("E","1"), 3 },
                {new Tuple<string, string>("E","2"), 4 },
                {new Tuple<string, string>("E","3"), 5 },
                {new Tuple<string, string>("E","4"), 5 }
            };

        public string description;
        public string associatedDanger;
        public string safetyNet;
        public string severityClassification;
        public string frequencyClassification;
        public int riskClassification;

        public Risk() { }

        public Risk(string description, string associatedDanger, string safetyNet, string severityClassification, string frequencyClassification)
        {
            this.description = description;
            this.associatedDanger = associatedDanger;
            this.safetyNet = safetyNet;
            this.severityClassification = severityClassification;
            this.frequencyClassification = frequencyClassification;
            this.riskClassification = riskClassificationMap[new Tuple<string,string>(frequencyClassification, severityClassification)];
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
        }
    }
}
