namespace SmartTestAutomation.Desktop
{
    partial class SmartTestAutomation
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCTS = new System.Windows.Forms.RadioButton();
            this.rbCTP = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(901, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Smart Test Automation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(122, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Create Test Cases";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(122, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create Test Project";
            // 
            // rbCTS
            // 
            this.rbCTS.AutoSize = true;
            this.rbCTS.Location = new System.Drawing.Point(92, 175);
            this.rbCTS.Name = "rbCTS";
            this.rbCTS.Size = new System.Drawing.Size(21, 20);
            this.rbCTS.TabIndex = 6;
            this.rbCTS.TabStop = true;
            this.rbCTS.UseVisualStyleBackColor = true;
            // 
            // rbCTP
            // 
            this.rbCTP.AutoSize = true;
            this.rbCTP.Location = new System.Drawing.Point(92, 301);
            this.rbCTP.Name = "rbCTP";
            this.rbCTP.Size = new System.Drawing.Size(21, 20);
            this.rbCTP.TabIndex = 7;
            this.rbCTP.TabStop = true;
            this.rbCTP.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(142, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(793, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Import the test cases in csv format and create the features and spec definitions " +
    "in the target folder ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(142, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(639, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Import the test cases in csv format and create a new selenium spec flow project";
            // 
            // SmartTestAutomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbCTP);
            this.Controls.Add(this.rbCTS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SmartTestAutomation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rbCTS;
        private RadioButton rbCTP;
        private Label label4;
        private Label label5;
    }
}