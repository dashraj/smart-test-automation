﻿namespace SmartTestAutomation.Desktop
{
    partial class CreateTestCases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFileUpload = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.lblSelectFeatureFolderPath = new System.Windows.Forms.Label();
            this.lblFeatureFileFolderPath = new System.Windows.Forms.Label();
            this.btnBrowseFeaturepath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFileUpload
            // 
            this.lblFileUpload.AutoSize = true;
            this.lblFileUpload.Location = new System.Drawing.Point(79, 44);
            this.lblFileUpload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileUpload.Name = "lblFileUpload";
            this.lblFileUpload.Size = new System.Drawing.Size(178, 25);
            this.lblFileUpload.TabIndex = 0;
            this.lblFileUpload.Text = "Select file to upload :";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFilePath.Location = new System.Drawing.Point(405, 44);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 25);
            this.lblFilePath.TabIndex = 1;
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFileUpload.Location = new System.Drawing.Point(79, 95);
            this.btnFileUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Size = new System.Drawing.Size(224, 36);
            this.btnFileUpload.TabIndex = 2;
            this.btnFileUpload.Text = "Browse file to upload";
            this.btnFileUpload.UseVisualStyleBackColor = false;
            this.btnFileUpload.Click += new System.EventHandler(this.btnFileUpload_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(79, 321);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(188, 36);
            this.btnUploadFile.TabIndex = 3;
            this.btnUploadFile.Text = "Create Test cases";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // lblSelectFeatureFolderPath
            // 
            this.lblSelectFeatureFolderPath.AutoSize = true;
            this.lblSelectFeatureFolderPath.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectFeatureFolderPath.Location = new System.Drawing.Point(79, 171);
            this.lblSelectFeatureFolderPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectFeatureFolderPath.Name = "lblSelectFeatureFolderPath";
            this.lblSelectFeatureFolderPath.Size = new System.Drawing.Size(242, 25);
            this.lblSelectFeatureFolderPath.TabIndex = 5;
            this.lblSelectFeatureFolderPath.Text = "Select Feature file folder path";
            this.lblSelectFeatureFolderPath.Click += new System.EventHandler(this.lblSelectFeatureFolderPath_Click);
            // 
            // lblFeatureFileFolderPath
            // 
            this.lblFeatureFileFolderPath.AutoSize = true;
            this.lblFeatureFileFolderPath.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFeatureFileFolderPath.Location = new System.Drawing.Point(405, 171);
            this.lblFeatureFileFolderPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeatureFileFolderPath.Name = "lblFeatureFileFolderPath";
            this.lblFeatureFileFolderPath.Size = new System.Drawing.Size(0, 25);
            this.lblFeatureFileFolderPath.TabIndex = 6;
            this.lblFeatureFileFolderPath.Click += new System.EventHandler(this.lblFeatureFileFolderPath_Click);
            // 
            // btnBrowseFeaturepath
            // 
            this.btnBrowseFeaturepath.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnBrowseFeaturepath.Location = new System.Drawing.Point(79, 229);
            this.btnBrowseFeaturepath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseFeaturepath.Name = "btnBrowseFeaturepath";
            this.btnBrowseFeaturepath.Size = new System.Drawing.Size(281, 36);
            this.btnBrowseFeaturepath.TabIndex = 7;
            this.btnBrowseFeaturepath.Text = "Browse feature folder path";
            this.btnBrowseFeaturepath.UseVisualStyleBackColor = false;
            this.btnBrowseFeaturepath.Click += new System.EventHandler(this.btnBrowseFeaturepath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(86, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Test features created successfully.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(86, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Error occured.. Please validate the file.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Go back to Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CreateTestCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseFeaturepath);
            this.Controls.Add(this.lblFeatureFileFolderPath);
            this.Controls.Add(this.lblSelectFeatureFolderPath);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.btnFileUpload);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblFileUpload);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateTestCases";
            this.Text = "Smart Test Automation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFileUpload;
        private Label lblFilePath;
        private Button btnFileUpload;
        private Button btnUploadFile;
        private Label lblSelectFeatureFolderPath;
        private Label lblFeatureFileFolderPath;
        private Button btnBrowseFeaturepath;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}