using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class BiologicalAgentsInformation : UserControl
    {
        public BiologicalInfo data;
        public string storage;
        public string destination;

        public BiologicalAgentsInformation()
        {
            InitializeComponent();
        }

        private void BiologicalAgentsInformation_Load(object sender, EventArgs e)
        {
            data = new BiologicalInfo();
        }

        public void ValidateData()
        {
            if (this.data == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            this.biologicalResidues1.ValidateData();
            data = biologicalResidues1.data;

            this.bioStorage1.ValidateData();
            this.storage = bioStorage1.storage;
            this.destination = bioStorage1.destination;
        }
    }
}
