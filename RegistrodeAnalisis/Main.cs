﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistrodeAnalisis.UI.Registro;

namespace RegistrodeAnalisis
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void rAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAnalisis ra = new rAnalisis();
            ra.Show();
        }
    }
}
