using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class HistoryControl : UserControl
    {
        private string history;

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
            // TODO
        }
    }
}
