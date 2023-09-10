namespace SmartTestAutomation.Desktop
{
    partial class Home
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
            this.btnCreateTestCases = new System.Windows.Forms.Button();
            this.btnCreateTestProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTestCases
            // 
            this.btnCreateTestCases.Location = new System.Drawing.Point(94, 216);
            this.btnCreateTestCases.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTestCases.Name = "btnCreateTestCases";
            this.btnCreateTestCases.Size = new System.Drawing.Size(300, 50);
            this.btnCreateTestCases.TabIndex = 3;
            this.btnCreateTestCases.Text = "Create Test cases";
            this.btnCreateTestCases.UseVisualStyleBackColor = true;
            this.btnCreateTestCases.Click += new System.EventHandler(this.BtnCreateTestCases_Click);
            // 
            // btnCreateTestProject
            // 
            this.btnCreateTestProject.Location = new System.Drawing.Point(568, 216);
            this.btnCreateTestProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTestProject.Name = "btnCreateTestProject";
            this.btnCreateTestProject.Size = new System.Drawing.Size(300, 50);
            this.btnCreateTestProject.TabIndex = 7;
            this.btnCreateTestProject.Text = "Create Test Project";
            this.btnCreateTestProject.UseVisualStyleBackColor = true;
            this.btnCreateTestProject.Click += new System.EventHandler(this.BtnCreateTestProject_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnCreateTestProject);
            this.Controls.Add(this.btnCreateTestCases);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Smart Test Automation";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCreateTestCases;        
        private Button btnCreateTestProject;
    }
}