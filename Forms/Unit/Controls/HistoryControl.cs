using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
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
