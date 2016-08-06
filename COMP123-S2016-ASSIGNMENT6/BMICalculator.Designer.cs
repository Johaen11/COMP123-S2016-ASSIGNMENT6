namespace COMP123_S2016_ASSIGNMENT6
{
    partial class BMICalculator
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BMITableLabel = new System.Windows.Forms.Label();
            this.ImperialUnitsRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricUnitsRadioButton = new System.Windows.Forms.RadioButton();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.BMIButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BMICalculatorTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BMITableLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BMITableLabel
            // 
            this.BMITableLabel.AutoSize = true;
            this.BMITableLabel.Location = new System.Drawing.Point(4, 1);
            this.BMITableLabel.Name = "BMITableLabel";
            this.BMITableLabel.Size = new System.Drawing.Size(82, 17);
            this.BMITableLabel.TabIndex = 0;
            this.BMITableLabel.Text = "BMI Scale";
            this.BMITableLabel.Click += new System.EventHandler(this.BMITableLabel_Click);
            // 
            // ImperialUnitsRadioButton
            // 
            this.ImperialUnitsRadioButton.AutoSize = true;
            this.ImperialUnitsRadioButton.Location = new System.Drawing.Point(9, 118);
            this.ImperialUnitsRadioButton.Name = "ImperialUnitsRadioButton";
            this.ImperialUnitsRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialUnitsRadioButton.TabIndex = 1;
            this.ImperialUnitsRadioButton.TabStop = true;
            this.ImperialUnitsRadioButton.Text = "Imperial";
            this.ImperialUnitsRadioButton.UseVisualStyleBackColor = true;
            this.ImperialUnitsRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // MetricUnitsRadioButton
            // 
            this.MetricUnitsRadioButton.AutoSize = true;
            this.MetricUnitsRadioButton.Location = new System.Drawing.Point(159, 118);
            this.MetricUnitsRadioButton.Name = "MetricUnitsRadioButton";
            this.MetricUnitsRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricUnitsRadioButton.TabIndex = 2;
            this.MetricUnitsRadioButton.TabStop = true;
            this.MetricUnitsRadioButton.Text = "Metric";
            this.MetricUnitsRadioButton.UseVisualStyleBackColor = true;
            this.MetricUnitsRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(1, 237);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(141, 31);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(159, 237);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(56, 38);
            this.WeightTextBox.TabIndex = 4;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(159, 173);
            this.HeightTextBox.MaxLength = 4;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(56, 38);
            this.HeightTextBox.TabIndex = 5;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(1, 173);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(136, 31);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "My Height";
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BMITextBox.Location = new System.Drawing.Point(159, 289);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(100, 38);
            this.BMITextBox.TabIndex = 7;
            // 
            // BMIButton
            // 
            this.BMIButton.Location = new System.Drawing.Point(-4, 271);
            this.BMIButton.Name = "BMIButton";
            this.BMIButton.Size = new System.Drawing.Size(146, 73);
            this.BMIButton.TabIndex = 8;
            this.BMIButton.Text = "Calculate BMI";
            this.BMIButton.UseVisualStyleBackColor = true;
            this.BMIButton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(136, 350);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(171, 58);
            this.ResultsTextBox.TabIndex = 9;
            this.ResultsTextBox.TextChanged += new System.EventHandler(this.ResultsTextBox_TextChanged);
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.HeightUnitLabel.Location = new System.Drawing.Point(221, 176);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(208, 31);
            this.HeightUnitLabel.TabIndex = 10;
            this.HeightUnitLabel.Text = "HeightUnitLabel";
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Location = new System.Drawing.Point(221, 237);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(86, 31);
            this.WeightUnitLabel.TabIndex = 11;
            this.WeightUnitLabel.Text = "label2";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 368);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(106, 40);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(136, 414);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(164, 23);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // BMICalculatorTimer
            // 
            this.BMICalculatorTimer.Enabled = true;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 441);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.WeightUnitLabel);
            this.Controls.Add(this.HeightUnitLabel);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.BMIButton);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.MetricUnitsRadioButton);
            this.Controls.Add(this.ImperialUnitsRadioButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialUnitsRadioButton;
        private System.Windows.Forms.RadioButton MetricUnitsRadioButton;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button BMIButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label BMITableLabel;
        private System.Windows.Forms.Timer BMICalculatorTimer;
    }
}

