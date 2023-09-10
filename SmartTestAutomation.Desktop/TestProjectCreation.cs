using SmartTestAutomation.Core.Implementations;
using SmartTestAutomation.Core.Interfaces;
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
    public partial class TestProjectCreation : Form
    {
        public TestProjectCreation()
        {
            InitializeComponent();            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbFile.Text))
                {

                    MessageBox.Show("Please Select file.");

                }
                else if (String.IsNullOrEmpty(tbProjectFolder.Text))
                {

                    MessageBox.Show("Please Select folder.");

                }
                else if (String.IsNullOrEmpty(tbProjectName.Text))
                {
                    MessageBox.Show("Please enter the project name.");
                }
                else
                {
                    ISmartTestService service = new SmartTestService();

                    service.StartTheProcess(tbFile.Text, tbProjectName.Text, tbProjectFolder.Text);

                }


            }
            catch
            {
                MessageBox.Show("Some error occured please validate your input.");
                throw;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SmartTestAutomation form = new();
            form.ShowDialog();
            this.Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
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
                        tbFile.Text = path;
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


        private void btnProjectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var folderBrowserDialog1 = new FolderBrowserDialog();

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog1.SelectedPath;
                    // Use the folderPath as needed in your application
                    tbProjectFolder.Text = folderPath;
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
    }
}

    

        
