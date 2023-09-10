using SmartTestAutomation.Core.Helpers;
using SmartTestAutomation.Steps.Core;
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
    public partial class CreateTestCases : Form
    {
        public CreateTestCases()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
        }

        private void lblSelectFeatureFolderPath_Click(object sender, EventArgs e)
        {

        }

        private void lblFeatureFileFolderPath_Click(object sender, EventArgs e)
        {

        }

       
        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select file to upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialog1.Filter = "Select Valid Document(*.csv; )|*.csv;";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        lblFilePath.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBrowseFeaturepath_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog1.SelectedPath;
                    // Use the folderPath as needed in your application
                    lblFeatureFileFolderPath.Text = folderPath;
                }
                else
                {
                    MessageBox.Show("Please Select Folder.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
           
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            try
            {
                var lines = FileHelpers.ReadTestCases(lblFilePath.Text);
                var destinationfolder = lblFeatureFileFolderPath.Text;
                FileHelpers.CreateFeatures(lines, destinationfolder);

                CommandHelpers.RunCommand("mkdir StepDefinitions", CommandHelpers.ReplaceFirstOccurrence(destinationfolder, "Feature", "") );

                FileHelpers.CreateStepDefinitions(lines, destinationfolder, "SmartTestAutomation");
               
                label1.Show();
               
            }
            catch { 
                label2.Show();
            }
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Home form = new();
            form.ShowDialog();
            this.Close();
        }
    }
}
