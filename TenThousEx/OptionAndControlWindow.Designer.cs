namespace TenThousEx
{
    partial class OptionAndControlWindow
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
            this.produceFileOutputButton = new System.Windows.Forms.Button();
            this.selectInclusiveExclusiveOptionComboBox = new System.Windows.Forms.ComboBox();
            this.selectStartingNumberOfRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.selectEndingNumberOfRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelSelectStartingNumberOfRange = new System.Windows.Forms.Label();
            this.labelSelectEndingNumberOfRange = new System.Windows.Forms.Label();
            this.labelSelectInclusiveExclusiveOption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectStartingNumberOfRangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEndingNumberOfRangeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // produceFileOutputButton
            // 
            this.produceFileOutputButton.Location = new System.Drawing.Point(65, 197);
            this.produceFileOutputButton.Name = "produceFileOutputButton";
            this.produceFileOutputButton.Size = new System.Drawing.Size(151, 40);
            this.produceFileOutputButton.TabIndex = 0;
            this.produceFileOutputButton.Text = "Create List";
            this.produceFileOutputButton.UseVisualStyleBackColor = true;
            this.produceFileOutputButton.Click += new System.EventHandler(this.produceFileOutputButton_Click);
            // 
            // selectInclusiveExclusiveOptionComboBox
            // 
            this.selectInclusiveExclusiveOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectInclusiveExclusiveOptionComboBox.FormattingEnabled = true;
            this.selectInclusiveExclusiveOptionComboBox.Items.AddRange(new object[] {
            "INCLUSIVE",
            "EXCLUSIVE"});
            this.selectInclusiveExclusiveOptionComboBox.Location = new System.Drawing.Point(95, 87);
            this.selectInclusiveExclusiveOptionComboBox.MaxDropDownItems = 2;
            this.selectInclusiveExclusiveOptionComboBox.Name = "selectInclusiveExclusiveOptionComboBox";
            this.selectInclusiveExclusiveOptionComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectInclusiveExclusiveOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.selectInclusiveExclusiveOptionComboBox_SelectedIndexChanged);
            this.selectInclusiveExclusiveOptionComboBox.TabIndex = 0;
            this.selectInclusiveExclusiveOptionComboBox.SelectedIndex = 0;
            // 
            // selectStartingNumberOfRangeNumericUpDown
            // 
            this.selectStartingNumberOfRangeNumericUpDown.Location = new System.Drawing.Point(95, 35);
            this.selectStartingNumberOfRangeNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.selectStartingNumberOfRangeNumericUpDown.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.selectStartingNumberOfRangeNumericUpDown.Name = "selectStartingNumberOfRangeNumericUpDown";
            this.selectStartingNumberOfRangeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.selectStartingNumberOfRangeNumericUpDown.TabIndex = 3;
            this.selectStartingNumberOfRangeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectStartingNumberOfRangeNumericUpDown.ValueChanged += new System.EventHandler(this.selectStartingNumberOfRangeNumericUpDown_ValueChanged);
            // 
            // selectEndingNumberOfRangeNumericUpDown
            // 
            this.selectEndingNumberOfRangeNumericUpDown.Location = new System.Drawing.Point(95, 61);
            this.selectEndingNumberOfRangeNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.selectEndingNumberOfRangeNumericUpDown.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.selectEndingNumberOfRangeNumericUpDown.Name = "selectEndingNumberOfRangeNumericUpDown";
            this.selectEndingNumberOfRangeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.selectEndingNumberOfRangeNumericUpDown.TabIndex = 4;
            this.selectEndingNumberOfRangeNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.selectEndingNumberOfRangeNumericUpDown.ValueChanged += new System.EventHandler(this.selectEndingNumberOfRangeNumericUpDown_ValueChanged);
            // 
            // labelSelectStartingNumberOfRange
            // 
            this.labelSelectStartingNumberOfRange.AutoSize = true;
            this.labelSelectStartingNumberOfRange.Location = new System.Drawing.Point(12, 37);
            this.labelSelectStartingNumberOfRange.Name = "labelSelectStartingNumberOfRange";
            this.labelSelectStartingNumberOfRange.Size = new System.Drawing.Size(69, 13);
            this.labelSelectStartingNumberOfRange.TabIndex = 5;
            this.labelSelectStartingNumberOfRange.Text = "Start Number";
            // 
            // labelSelectEndingNumberOfRange
            // 
            this.labelSelectEndingNumberOfRange.AutoSize = true;
            this.labelSelectEndingNumberOfRange.Location = new System.Drawing.Point(12, 63);
            this.labelSelectEndingNumberOfRange.Name = "labelSelectEndingNumberOfRange";
            this.labelSelectEndingNumberOfRange.Size = new System.Drawing.Size(80, 13);
            this.labelSelectEndingNumberOfRange.TabIndex = 6;
            this.labelSelectEndingNumberOfRange.Text = "Ending Number";
            // 
            // labelSelectInclusiveExclusiveOption
            // 
            this.labelSelectInclusiveExclusiveOption.AutoSize = true;
            this.labelSelectInclusiveExclusiveOption.Location = new System.Drawing.Point(12, 90);
            this.labelSelectInclusiveExclusiveOption.Name = "labelSelectInclusiveExclusiveOption";
            this.labelSelectInclusiveExclusiveOption.Size = new System.Drawing.Size(51, 13);
            this.labelSelectInclusiveExclusiveOption.TabIndex = 7;
            this.labelSelectInclusiveExclusiveOption.Text = "Inc / Exc";
            // 
            // OptionAndControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelSelectInclusiveExclusiveOption);
            this.Controls.Add(this.labelSelectEndingNumberOfRange);
            this.Controls.Add(this.labelSelectStartingNumberOfRange);
            this.Controls.Add(this.selectEndingNumberOfRangeNumericUpDown);
            this.Controls.Add(this.selectStartingNumberOfRangeNumericUpDown);
            this.Controls.Add(this.selectInclusiveExclusiveOptionComboBox);
            this.Controls.Add(this.produceFileOutputButton);
            this.Name = "OptionAndControlWindow";
            this.Text = "OptionAndControlWindow";
            ((System.ComponentModel.ISupportInitialize)(this.selectStartingNumberOfRangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEndingNumberOfRangeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button produceFileOutputButton;
        private System.Windows.Forms.ComboBox selectInclusiveExclusiveOptionComboBox;
        private System.Windows.Forms.NumericUpDown selectStartingNumberOfRangeNumericUpDown;
        private System.Windows.Forms.NumericUpDown selectEndingNumberOfRangeNumericUpDown;
        private System.Windows.Forms.Label labelSelectStartingNumberOfRange;
        private System.Windows.Forms.Label labelSelectEndingNumberOfRange;
        private System.Windows.Forms.Label labelSelectInclusiveExclusiveOption;
    }
}