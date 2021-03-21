using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class UnitMethodologyControl : UserControl
    {
        public UnitMethodologyControl()
        {
            InitializeComponent();

            // Load default text to textbox
            try
            {
                StreamReader re = File.OpenText("../../Resources/default_method.txt");
                string default_method_text = re.ReadToEnd();
                MethodologyTextBox.Text = default_method_text;
                re.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
