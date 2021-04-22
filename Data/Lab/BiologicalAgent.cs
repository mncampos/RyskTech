using System;

namespace RyskTech.Data
{
    public class BiologicalAgent
    {
        public string name;
        public string riskClassification;
        public string usageScenarios;

        public BiologicalAgent() { }

        public BiologicalAgent(string name, string riskClassification, string usageScenarios)
        {
            this.name = name;
            this.riskClassification = riskClassification;
            this.usageScenarios = usageScenarios;
        }
        
        public void CheckValidity()
        {
            if (name == null || name.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoAgentName);

            if (riskClassification == null || riskClassification.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoRiskClassificaiton);

            if (usageScenarios == null || usageScenarios.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoAgentUsage);
        }
    }
}
