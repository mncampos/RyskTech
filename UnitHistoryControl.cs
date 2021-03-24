using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class UnitHistoryControl : UserControl
    {
        public UnitHistoryControl()
        {
            InitializeComponent();
        }

        private void UnitHistoryTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit_info.history = UnitHistoryTextBox.Text;
        }
    }
}
