using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTestAutomation.Desktop
{
    public partial class SmartTestAutomation : Form
    {
        public SmartTestAutomation()
        {
            InitializeComponent();            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbCTP.Checked)
            {
                TestProjectCreation form = new();
                form.ShowDialog();
                this.Close();
            }
            else if (rbCTS.Checked)
            {
                TestCaseCreation form = new();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}

    

        
