using SmartTestAutomation.Core.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTestAutomation.Desktop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void BtnCreateTestCases_Click(object sender, EventArgs e)
        {
            CreateTestCases form = new();
            form.ShowDialog();
            this.Close();
        }

        private void BtnCreateTestProject_Click(object sender, EventArgs e)
        {
            CreateTestProject form = new();
            form.ShowDialog();
            this.Close();
        }
    }
}
