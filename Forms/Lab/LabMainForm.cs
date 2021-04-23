using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class LabMainForm : Form
    {
        private Data.Lab data;

        public LabMainForm()
        {
            InitializeComponent();
        }

        private void LabMainForm_Load(object sender, EventArgs e)
        {
            data = new Data.Lab();
        }

        private void PrepareForGeneration()
        {
            labWelcomeControl1.ValidateData();
            data.generalInformation = labWelcomeControl1.data;

            generalInformationControl1.ValidateData();
            data.spaceCharacterization = generalInformationControl1.data;

            safetyEquipmentControl1.ValidateData();
            data.safetyEquipment = safetyEquipmentControl1.data;

            safetyTrainingControl2.ValidateData();
            data.safetyTraining = safetyTrainingControl2.data;

            if (data.generalInformation.manipulatesChemicalAgents)
            {
                chemicalResidueControl1.ValidateData();
                data.manipulatedChemicalResidues = chemicalResidueControl1.residueData;
                data.manipulatedChemicalReactors = chemicalResidueControl1.reactorData;
                data.chemicalResidueStorageInfo = chemicalResidueControl1.storageInfo;
            }

            if (data.generalInformation.manipulatesBiologicalAgents)
            {
                biologicalAgentsInformation1.ValidateData();
                data.biologicalAgentsInfo = biologicalAgentsInformation1.data;
                data.biologicalAgentsDestination = biologicalAgentsInformation1.destination;
                data.biologicalAgentsStorage = biologicalAgentsInformation1.storage;
            }

            if (data.generalInformation.manipulatesMechanicalAgents)
            {
                mechanicalAgentControl1.ValidateData();
                data.mechanicalAgentsInfo = mechanicalAgentControl1.mechanicalAgentList;
            }

            if (data.generalInformation.manipulatesPhysicalAgents)
            {
                physicalAgentsControl1.ValidateData();
                data.physicalAgentsInfo = physicalAgentsControl1.physicalAgentList;
            }

            finalConsiderationsControl1.ValidateData();
            data.riskAnalysisInformation = finalConsiderationsControl1.data;
        }

        public void Complete()
        {
            try
            {
                PrepareForGeneration();

                APR compilation = new APR(data);

                DocumentBuilder docBuilder = new DocumentBuilder(compilation, "APR_Laboratorio.docx");

                int statusCode = docBuilder.CreateLabDocumentFromAPR();

                if (statusCode == 0)
                    MessageBox.Show("APR Gerada com sucesso!", "Obrigado por usar RyskTech! :)");
                else
                    MessageBox.Show("Foram encontrados alguns erros na geração da APR", ":(");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
