namespace Imprivata
{
    partial class TestForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sortedMergeTab = new System.Windows.Forms.TabPage();
            this.sortedMergeButton = new System.Windows.Forms.Button();
            this.pangramTestTab = new System.Windows.Forms.TabPage();
            this.lstTestStrings = new System.Windows.Forms.ListBox();
            this.pangramTestButton = new System.Windows.Forms.Button();
            this.topmostStepTab = new System.Windows.Forms.TabPage();
            this.topmostStepButton = new System.Windows.Forms.Button();
            this.cityClinicsTab = new System.Windows.Forms.TabPage();
            this.cityClinicsButton = new System.Windows.Forms.Button();
            this.outputWindow = new System.Windows.Forms.TextBox();
            this.freeFormInput = new System.Windows.Forms.TextBox();
            this.freeFormPangramButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.sortedMergeTab.SuspendLayout();
            this.pangramTestTab.SuspendLayout();
            this.topmostStepTab.SuspendLayout();
            this.cityClinicsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sortedMergeTab);
            this.tabControl1.Controls.Add(this.pangramTestTab);
            this.tabControl1.Controls.Add(this.topmostStepTab);
            this.tabControl1.Controls.Add(this.cityClinicsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 218);
            this.tabControl1.TabIndex = 0;
            // 
            // sortedMergeTab
            // 
            this.sortedMergeTab.Controls.Add(this.sortedMergeButton);
            this.sortedMergeTab.Location = new System.Drawing.Point(8, 39);
            this.sortedMergeTab.Name = "sortedMergeTab";
            this.sortedMergeTab.Padding = new System.Windows.Forms.Padding(3);
            this.sortedMergeTab.Size = new System.Drawing.Size(692, 171);
            this.sortedMergeTab.TabIndex = 0;
            this.sortedMergeTab.Text = "Sorted Merge";
            this.sortedMergeTab.UseVisualStyleBackColor = true;
            // 
            // sortedMergeButton
            // 
            this.sortedMergeButton.Location = new System.Drawing.Point(20, 20);
            this.sortedMergeButton.Name = "sortedMergeButton";
            this.sortedMergeButton.Size = new System.Drawing.Size(239, 56);
            this.sortedMergeButton.TabIndex = 0;
            this.sortedMergeButton.Text = "Run Sorted Merge";
            this.sortedMergeButton.UseVisualStyleBackColor = true;
            this.sortedMergeButton.Click += new System.EventHandler(this.sortedMergeButton_Click);
            // 
            // pangramTestTab
            // 
            this.pangramTestTab.Controls.Add(this.freeFormPangramButton);
            this.pangramTestTab.Controls.Add(this.freeFormInput);
            this.pangramTestTab.Controls.Add(this.lstTestStrings);
            this.pangramTestTab.Controls.Add(this.pangramTestButton);
            this.pangramTestTab.Location = new System.Drawing.Point(8, 39);
            this.pangramTestTab.Name = "pangramTestTab";
            this.pangramTestTab.Padding = new System.Windows.Forms.Padding(3);
            this.pangramTestTab.Size = new System.Drawing.Size(770, 171);
            this.pangramTestTab.TabIndex = 1;
            this.pangramTestTab.Text = "Pangram Test";
            this.pangramTestTab.UseVisualStyleBackColor = true;
            // 
            // lstTestStrings
            // 
            this.lstTestStrings.FormattingEnabled = true;
            this.lstTestStrings.ItemHeight = 25;
            this.lstTestStrings.Items.AddRange(new object[] {
            "The quick brown fox jumps over the lazy dog",
            "We promptly judged antique ivory buckles for the next prize    ",
            "We promptly judged antique ivory buckles for the prize    "});
            this.lstTestStrings.Location = new System.Drawing.Point(13, 22);
            this.lstTestStrings.Name = "lstTestStrings";
            this.lstTestStrings.Size = new System.Drawing.Size(506, 29);
            this.lstTestStrings.TabIndex = 2;
            // 
            // pangramTestButton
            // 
            this.pangramTestButton.Location = new System.Drawing.Point(525, 6);
            this.pangramTestButton.Name = "pangramTestButton";
            this.pangramTestButton.Size = new System.Drawing.Size(239, 56);
            this.pangramTestButton.TabIndex = 1;
            this.pangramTestButton.Text = "Run Pangram Test";
            this.pangramTestButton.UseVisualStyleBackColor = true;
            this.pangramTestButton.Click += new System.EventHandler(this.pangramTestButton_Click);
            // 
            // topmostStepTab
            // 
            this.topmostStepTab.Controls.Add(this.topmostStepButton);
            this.topmostStepTab.Location = new System.Drawing.Point(8, 39);
            this.topmostStepTab.Name = "topmostStepTab";
            this.topmostStepTab.Size = new System.Drawing.Size(770, 171);
            this.topmostStepTab.TabIndex = 2;
            this.topmostStepTab.Text = "Topmost Step";
            this.topmostStepTab.UseVisualStyleBackColor = true;
            // 
            // topmostStepButton
            // 
            this.topmostStepButton.Location = new System.Drawing.Point(41, 34);
            this.topmostStepButton.Name = "topmostStepButton";
            this.topmostStepButton.Size = new System.Drawing.Size(279, 56);
            this.topmostStepButton.TabIndex = 2;
            this.topmostStepButton.Text = "Run Topmost Step Test";
            this.topmostStepButton.UseVisualStyleBackColor = true;
            this.topmostStepButton.Click += new System.EventHandler(this.topmostStepButton_Click);
            // 
            // cityClinicsTab
            // 
            this.cityClinicsTab.Controls.Add(this.cityClinicsButton);
            this.cityClinicsTab.Location = new System.Drawing.Point(8, 39);
            this.cityClinicsTab.Name = "cityClinicsTab";
            this.cityClinicsTab.Size = new System.Drawing.Size(770, 171);
            this.cityClinicsTab.TabIndex = 3;
            this.cityClinicsTab.Text = "City Clinics";
            this.cityClinicsTab.UseVisualStyleBackColor = true;
            // 
            // cityClinicsButton
            // 
            this.cityClinicsButton.Location = new System.Drawing.Point(26, 35);
            this.cityClinicsButton.Name = "cityClinicsButton";
            this.cityClinicsButton.Size = new System.Drawing.Size(239, 56);
            this.cityClinicsButton.TabIndex = 2;
            this.cityClinicsButton.Text = "Run City Clinics Test";
            this.cityClinicsButton.UseVisualStyleBackColor = true;
            this.cityClinicsButton.Click += new System.EventHandler(this.cityClinicsButton_Click);
            // 
            // outputWindow
            // 
            this.outputWindow.Location = new System.Drawing.Point(20, 236);
            this.outputWindow.Multiline = true;
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.Size = new System.Drawing.Size(770, 329);
            this.outputWindow.TabIndex = 1;
            // 
            // freeFormInput
            // 
            this.freeFormInput.Location = new System.Drawing.Point(10, 86);
            this.freeFormInput.Name = "freeFormInput";
            this.freeFormInput.Size = new System.Drawing.Size(508, 31);
            this.freeFormInput.TabIndex = 3;
            this.freeFormInput.Text = "FREE FORM ENTRY";
            // 
            // freeFormPangramButton
            // 
            this.freeFormPangramButton.Location = new System.Drawing.Point(525, 68);
            this.freeFormPangramButton.Name = "freeFormPangramButton";
            this.freeFormPangramButton.Size = new System.Drawing.Size(239, 56);
            this.freeFormPangramButton.TabIndex = 4;
            this.freeFormPangramButton.Text = "Run Pangram Test";
            this.freeFormPangramButton.UseVisualStyleBackColor = true;
            this.freeFormPangramButton.Click += new System.EventHandler(this.freeFormPangramButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 577);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.tabControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.sortedMergeTab.ResumeLayout(false);
            this.pangramTestTab.ResumeLayout(false);
            this.pangramTestTab.PerformLayout();
            this.topmostStepTab.ResumeLayout(false);
            this.cityClinicsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sortedMergeTab;
        private System.Windows.Forms.TabPage pangramTestTab;
        private System.Windows.Forms.TabPage topmostStepTab;
        private System.Windows.Forms.TabPage cityClinicsTab;
        private System.Windows.Forms.TextBox outputWindow;
        private System.Windows.Forms.Button sortedMergeButton;
        private System.Windows.Forms.Button pangramTestButton;
        private System.Windows.Forms.Button topmostStepButton;
        private System.Windows.Forms.Button cityClinicsButton;
        private System.Windows.Forms.ListBox lstTestStrings;
        private System.Windows.Forms.Button freeFormPangramButton;
        private System.Windows.Forms.TextBox freeFormInput;
    }
}