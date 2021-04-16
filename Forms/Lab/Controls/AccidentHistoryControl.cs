using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class AccidentHistoryControl : UserControl
    {
        public string accidentHistory;

        public AccidentHistoryControl()
        {
            InitializeComponent();
        }

        private void accidentHistoryTextBox_TextChanged(object sender, System.EventArgs e)
        {
            accidentHistory = accidentHistoryTextBox.Text;
        }

        public void ValidateData()
        {
            //nil
        }
    }
}
