using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class HistoryControl : UserControl
    {
        public HistoryControl()
        {
            InitializeComponent();
        }

        private void UnitHistoryTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.history = UnitHistoryTextBox.Text;
        }
    }
}
