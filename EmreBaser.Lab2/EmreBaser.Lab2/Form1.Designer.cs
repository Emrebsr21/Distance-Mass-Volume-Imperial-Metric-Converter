namespace EmreBaser.Lab2
{
    partial class Form1
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.areaRadio = new System.Windows.Forms.RadioButton();
            this.massRadio = new System.Windows.Forms.RadioButton();
            this.distanceRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.roundDownButton = new System.Windows.Forms.Button();
            this.roundUpButton = new System.Windows.Forms.Button();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.resetButton = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualButton = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox.Controls.Add(this.areaRadio);
            this.groupBox.Controls.Add(this.massRadio);
            this.groupBox.Controls.Add(this.distanceRadio);
            this.groupBox.Location = new System.Drawing.Point(53, 98);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 243);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Select Units =>";
            // 
            // areaRadio
            // 
            this.areaRadio.AutoSize = true;
            this.areaRadio.Location = new System.Drawing.Point(36, 143);
            this.areaRadio.Name = "areaRadio";
            this.areaRadio.Size = new System.Drawing.Size(57, 20);
            this.areaRadio.TabIndex = 2;
            this.areaRadio.Text = "Area";
            this.areaRadio.UseVisualStyleBackColor = true;
            // 
            // massRadio
            // 
            this.massRadio.AutoSize = true;
            this.massRadio.Location = new System.Drawing.Point(36, 97);
            this.massRadio.Name = "massRadio";
            this.massRadio.Size = new System.Drawing.Size(61, 20);
            this.massRadio.TabIndex = 1;
            this.massRadio.Text = "Mass";
            this.massRadio.UseVisualStyleBackColor = true;
            // 
            // distanceRadio
            // 
            this.distanceRadio.AutoSize = true;
            this.distanceRadio.Checked = true;
            this.distanceRadio.Location = new System.Drawing.Point(36, 50);
            this.distanceRadio.Name = "distanceRadio";
            this.distanceRadio.Size = new System.Drawing.Size(81, 20);
            this.distanceRadio.TabIndex = 0;
            this.distanceRadio.TabStop = true;
            this.distanceRadio.Text = "Distance";
            this.distanceRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox2.Controls.Add(this.inputText);
            this.groupBox2.Controls.Add(this.fromComboBox);
            this.groupBox2.Location = new System.Drawing.Point(330, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert FROM";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(258, 49);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(119, 22);
            this.inputText.TabIndex = 2;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // fromComboBox
            // 
            this.fromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Items.AddRange(new object[] {
            "Please Select Units"});
            this.fromComboBox.Location = new System.Drawing.Point(31, 46);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(186, 24);
            this.fromComboBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox3.Controls.Add(this.roundDownButton);
            this.groupBox3.Controls.Add(this.roundUpButton);
            this.groupBox3.Controls.Add(this.outputTextbox);
            this.groupBox3.Controls.Add(this.toComboBox);
            this.groupBox3.Location = new System.Drawing.Point(330, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 129);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Convert TO";
            // 
            // roundDownButton
            // 
            this.roundDownButton.Location = new System.Drawing.Point(31, 98);
            this.roundDownButton.Name = "roundDownButton";
            this.roundDownButton.Size = new System.Drawing.Size(127, 25);
            this.roundDownButton.TabIndex = 5;
            this.roundDownButton.Text = "Round Down";
            this.roundDownButton.UseVisualStyleBackColor = true;
            // 
            // roundUpButton
            // 
            this.roundUpButton.Location = new System.Drawing.Point(31, 67);
            this.roundUpButton.Name = "roundUpButton";
            this.roundUpButton.Size = new System.Drawing.Size(127, 25);
            this.roundUpButton.TabIndex = 4;
            this.roundUpButton.Text = "Round Up";
            this.roundUpButton.UseVisualStyleBackColor = true;
            this.roundUpButton.Click += new System.EventHandler(this.roundUpButton_Click);
            // 
            // outputTextbox
            // 
            this.outputTextbox.Enabled = false;
            this.outputTextbox.Location = new System.Drawing.Point(258, 37);
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.Size = new System.Drawing.Size(119, 22);
            this.outputTextbox.TabIndex = 3;
            // 
            // toComboBox
            // 
            this.toComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Items.AddRange(new object[] {
            "Please Select Units"});
            this.toComboBox.Location = new System.Drawing.Point(31, 35);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(186, 24);
            this.toComboBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitButton,
            this.resetButton,
            this.userManualButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(47, 24);
            this.exitButton.Text = "Exit";
            // 
            // resetButton
            // 
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(59, 24);
            this.resetButton.Text = "Reset";
            // 
            // userManualButton
            // 
            this.userManualButton.Name = "userManualButton";
            this.userManualButton.Size = new System.Drawing.Size(105, 24);
            this.userManualButton.Text = "User Manual";
            this.userManualButton.Click += new System.EventHandler(this.userManualButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Metric-Imperial Unit Converter";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton areaRadio;
        private System.Windows.Forms.RadioButton massRadio;
        private System.Windows.Forms.RadioButton distanceRadio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripMenuItem resetButton;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.Button roundDownButton;
        private System.Windows.Forms.Button roundUpButton;
        private System.Windows.Forms.ToolStripMenuItem userManualButton;
    }
}

