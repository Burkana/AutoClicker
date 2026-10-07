namespace AutoClicker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelInterval = new Label();
            numInterval = new NumericUpDown();
            labelButton = new Label();
            comboClickType = new ComboBox();
            lblStatus = new Label();
            btnToggle = new Button();
            lblFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            SuspendLayout();
            // 
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Location = new Point(20, 20);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new Size(76, 15);
            labelInterval.TabIndex = 5;
            labelInterval.Text = "Interval (ms):";
            // 
            // numInterval
            // 
            numInterval.Location = new Point(130, 18);
            numInterval.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            numInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(120, 23);
            numInterval.TabIndex = 4;
            numInterval.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelButton
            // 
            labelButton.AutoSize = true;
            labelButton.Location = new Point(20, 55);
            labelButton.Name = "labelButton";
            labelButton.Size = new Size(85, 15);
            labelButton.TabIndex = 3;
            labelButton.Text = "Mouse Button:";
            // 
            // comboClickType
            // 
            comboClickType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboClickType.FormattingEnabled = true;
            comboClickType.Items.AddRange(new object[] { "Left Click", "Right Click", "Middle Click" });
            comboClickType.Location = new Point(130, 52);
            comboClickType.Name = "comboClickType";
            comboClickType.Size = new Size(120, 23);
            comboClickType.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(20, 95);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(118, 19);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status: STOPPED";
            // 
            // btnToggle
            // 
            btnToggle.Location = new Point(31, 130);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(230, 40);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "Start (F6)";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += btnToggle_Click;
            // 
            // lblFooter
            // 
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(0, 202);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(286, 20);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Made by Kamen :)";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 222);
            Controls.Add(lblFooter);
            Controls.Add(btnToggle);
            Controls.Add(lblStatus);
            Controls.Add(comboClickType);
            Controls.Add(labelButton);
            Controls.Add(numInterval);
            Controls.Add(labelInterval);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Clicker";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInterval;
        private NumericUpDown numInterval;
        private Label labelButton;
        private ComboBox comboClickType;
        private Label lblStatus;
        private Button btnToggle;

        private Label lblFooter;
    }
}