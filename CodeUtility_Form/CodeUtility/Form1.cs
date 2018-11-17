using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace CodeUtility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
