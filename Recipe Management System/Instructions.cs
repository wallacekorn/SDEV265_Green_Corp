﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Management_System
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            /* Initializes the Instructions form */

            InitializeComponent();
        }

        private void instructionsExitButton_Click(object sender, EventArgs e)
        {
            /* Close the instructions form on click */
            this.Close();
        }
    }
}
