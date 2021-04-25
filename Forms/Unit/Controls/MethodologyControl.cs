using System;
using System.IO;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class MethodologyControl : UserControl
    {
        public string methodology;
        private bool visited = false;

        public MethodologyControl()
        {
            InitializeComponent();
            visited = true;
        }

        private void MethodologyControl_Load(object sender, EventArgs e)
        {
            // Load default text to textbox
            MethodologyTextBox.Text = Properties.Resources.default_methodology;
        }

        private void MethodologyTextBox_TextChanged(object sender, EventArgs e)
        {
            methodology = MethodologyTextBox.Text;
        }

        private void showTable1Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro1, "Quadro 1");
            table1.ShowDialog();
        }

        private void showTable2Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro2, "Quadro 2");
            table1.ShowDialog();
        }

        private void showTable3Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro3, "Quadro 3");
            table1.ShowDialog();
        }

        private void showTable4Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro4, "Quadro 4");
            table1.ShowDialog();
        }

        public void ValidateData()
        {
            if (!visited)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);
        }
    }
}
