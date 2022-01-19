using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class ErrorControl : UserControl
    {
        public ErrorControl(string agentType)
        {
            InitializeComponent();
            string msg = "Parece que seu laboratório não manipula agentes " + agentType + ". Caso isto não seja verdade, retorne à aba inicial e altere sua seleção";
            errorMsgLabel.Text = msg;
        }
    }
}
