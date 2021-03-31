using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class HistoryControl : UserControl
    {
        public string history;

        public HistoryControl()
        {
            InitializeComponent();
        }

        private void UnitHistoryTextBox_TextChanged(object sender, EventArgs e)
        {
            history = UnitHistoryTextBox.Text;
        }

        public void ValidateData()
        {
            if (history == null || history.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.NoHistory);
        }
    }
}
