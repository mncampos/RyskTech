using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class BioStorage : UserControl
    {
        public string storage;
        public string destination;

        public BioStorage()
        {
            InitializeComponent();
        }

        private void bioResidueDestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            destination = bioResidueDestinationTextBox.Text;
        }

        private void bioStorageTextBox_TextChanged(object sender, EventArgs e)
        {
            storage = bioStorageTextBox.Text;
        }

        public void ValidateData()
        {
            if (storage == null || destination == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            if (storage.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueStorageDescription);

            if (destination.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueDestination);
        }
    }
}
