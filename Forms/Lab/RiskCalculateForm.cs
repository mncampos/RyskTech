﻿using RyskTech.Forms.Lab.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class RiskCalculateForm : Form
    {
        private CalculateControl calculateControl;

        public RiskCalculateForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void RiskCalculateFormBetter_Load(object sender, EventArgs e)
        {
            calculateControl = new CalculateControl();
            calculateControl.Dock = DockStyle.Fill;        
        }
    }
}
