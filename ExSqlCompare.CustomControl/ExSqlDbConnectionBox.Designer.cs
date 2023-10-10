namespace ExSqlCompare.CustomControl
{
    partial class ExSqlDbConnectionBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            serverNameLabel = new Label();
            serverComboBox = new ComboBox();
            serverRefreshButton = new Button();
            logonGroupBox = new GroupBox();
            radioButton1 = new RadioButton();
            serverWindowsAuthenticationRadioButton = new RadioButton();
            serverTableLayoutPanel = new TableLayoutPanel();
            serverHeaderPanel = new Panel();
            panel1 = new Panel();
            logonGroupBox.SuspendLayout();
            serverTableLayoutPanel.SuspendLayout();
            serverHeaderPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // serverNameLabel
            // 
            serverNameLabel.AutoSize = true;
            serverNameLabel.FlatStyle = FlatStyle.System;
            serverNameLabel.Location = new Point(4, 4);
            serverNameLabel.Margin = new Padding(0);
            serverNameLabel.Name = "serverNameLabel";
            serverNameLabel.Size = new Size(94, 20);
            serverNameLabel.TabIndex = 0;
            serverNameLabel.Text = "S&erver name:";
            // 
            // serverComboBox
            // 
            serverComboBox.FormattingEnabled = true;
            serverComboBox.Location = new Point(3, 3);
            serverComboBox.Name = "serverComboBox";
            serverComboBox.Size = new Size(429, 28);
            serverComboBox.TabIndex = 1;
            // 
            // serverRefreshButton
            // 
            serverRefreshButton.Location = new Point(439, 3);
            serverRefreshButton.Name = "serverRefreshButton";
            serverRefreshButton.Size = new Size(148, 29);
            serverRefreshButton.TabIndex = 2;
            serverRefreshButton.Text = "&Refresh";
            serverRefreshButton.UseVisualStyleBackColor = true;
            // 
            // logonGroupBox
            // 
            logonGroupBox.Controls.Add(radioButton1);
            logonGroupBox.Controls.Add(serverWindowsAuthenticationRadioButton);
            logonGroupBox.FlatStyle = FlatStyle.System;
            logonGroupBox.Location = new Point(4, 4);
            logonGroupBox.Margin = new Padding(0, 4, 0, 4);
            logonGroupBox.Name = "logonGroupBox";
            logonGroupBox.Padding = new Padding(4);
            logonGroupBox.Size = new Size(575, 226);
            logonGroupBox.TabIndex = 3;
            logonGroupBox.TabStop = false;
            logonGroupBox.Text = "Log on to the server";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.FlatStyle = FlatStyle.System;
            radioButton1.Location = new Point(7, 55);
            radioButton1.Margin = new Padding(12, 4, 12, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(239, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Use S&QL Server Authentication";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // serverWindowsAuthenticationRadioButton
            // 
            serverWindowsAuthenticationRadioButton.AutoSize = true;
            serverWindowsAuthenticationRadioButton.FlatStyle = FlatStyle.System;
            serverWindowsAuthenticationRadioButton.Location = new Point(7, 28);
            serverWindowsAuthenticationRadioButton.Margin = new Padding(12, 11, 12, 0);
            serverWindowsAuthenticationRadioButton.Name = "serverWindowsAuthenticationRadioButton";
            serverWindowsAuthenticationRadioButton.Size = new Size(229, 25);
            serverWindowsAuthenticationRadioButton.TabIndex = 0;
            serverWindowsAuthenticationRadioButton.TabStop = true;
            serverWindowsAuthenticationRadioButton.Text = "Use &Windows Authentication";
            serverWindowsAuthenticationRadioButton.UseVisualStyleBackColor = true;
            // 
            // serverTableLayoutPanel
            // 
            serverTableLayoutPanel.AutoSize = true;
            serverTableLayoutPanel.ColumnCount = 2;
            serverTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            serverTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 154F));
            serverTableLayoutPanel.Controls.Add(serverComboBox, 0, 0);
            serverTableLayoutPanel.Controls.Add(serverRefreshButton, 1, 0);
            serverTableLayoutPanel.Location = new Point(4, 24);
            serverTableLayoutPanel.Margin = new Padding(0, 4, 0, 4);
            serverTableLayoutPanel.Name = "serverTableLayoutPanel";
            serverTableLayoutPanel.RowCount = 1;
            serverTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            serverTableLayoutPanel.Size = new Size(590, 35);
            serverTableLayoutPanel.TabIndex = 1;
            // 
            // serverHeaderPanel
            // 
            serverHeaderPanel.AutoSize = true;
            serverHeaderPanel.Controls.Add(serverNameLabel);
            serverHeaderPanel.Controls.Add(serverTableLayoutPanel);
            serverHeaderPanel.Dock = DockStyle.Top;
            serverHeaderPanel.Location = new Point(0, 0);
            serverHeaderPanel.Margin = new Padding(0);
            serverHeaderPanel.Name = "serverHeaderPanel";
            serverHeaderPanel.Padding = new Padding(4);
            serverHeaderPanel.Size = new Size(590, 67);
            serverHeaderPanel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(logonGroupBox);
            panel1.Location = new Point(0, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 389);
            panel1.TabIndex = 5;
            // 
            // ExSqlDbConnectionBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(serverHeaderPanel);
            Name = "ExSqlDbConnectionBox";
            Size = new Size(590, 948);
            logonGroupBox.ResumeLayout(false);
            logonGroupBox.PerformLayout();
            serverTableLayoutPanel.ResumeLayout(false);
            serverHeaderPanel.ResumeLayout(false);
            serverHeaderPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label serverNameLabel;
        private ComboBox serverComboBox;
        private Button serverRefreshButton;
        private GroupBox logonGroupBox;
        private TableLayoutPanel serverTableLayoutPanel;
        private RadioButton serverWindowsAuthenticationRadioButton;
        private RadioButton radioButton1;
        private Panel serverHeaderPanel;
        private Panel panel1;
    }
}
