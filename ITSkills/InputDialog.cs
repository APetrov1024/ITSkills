﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSkills
{
    public partial class InputDialog : Form
    {
        private static InputDialog newInputDialog;
        private static string returnString;
        public InputDialog()
        {
            InitializeComponent();
        }

        public static string Show(string inputDialogText, string caption)
        {
            newInputDialog = new InputDialog();
            newInputDialog.messageLabel.Text = inputDialogText;
            newInputDialog.Text = caption;
            newInputDialog.ShowDialog();
            return returnString;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            returnString = inputTextBox.Text;
            newInputDialog.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            returnString = "";
            newInputDialog.Dispose();
        }
    }
}
