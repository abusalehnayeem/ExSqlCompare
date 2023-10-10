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
            serverMiddlePanel = new Panel();
            serverFooterPanel = new Panel();
            databaseGroupBox = new GroupBox();
            selectDatabaseComboBox = new ComboBox();
            selectDatabaseRadioButton = new RadioButton();
            serverLoginTableLayoutPanel = new TableLayoutPanel();
            label1 = new Label();
            logonGroupBox.SuspendLayout();
            serverTableLayoutPanel.SuspendLayout();
            serverHeaderPanel.SuspendLayout();
            serverMiddlePanel.SuspendLayout();
            serverFooterPanel.SuspendLayout();
            databaseGroupBox.SuspendLayout();
            serverLoginTableLayoutPanel.SuspendLayout();
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
            serverComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            serverComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            logonGroupBox.Controls.Add(serverLoginTableLayoutPanel);
            logonGroupBox.Controls.Add(radioButton1);
            logonGroupBox.Controls.Add(serverWindowsAuthenticationRadioButton);
            logonGroupBox.FlatStyle = FlatStyle.System;
            logonGroupBox.Location = new Point(4, 4);
            logonGroupBox.Margin = new Padding(0, 4, 0, 4);
            logonGroupBox.Name = "logonGroupBox";
            logonGroupBox.Padding = new Padding(4);
            logonGroupBox.Size = new Size(575, 261);
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
            // serverMiddlePanel
            // 
            serverMiddlePanel.Controls.Add(logonGroupBox);
            serverMiddlePanel.Dock = DockStyle.Top;
            serverMiddlePanel.Location = new Point(0, 67);
            serverMiddlePanel.Name = "serverMiddlePanel";
            serverMiddlePanel.Size = new Size(590, 269);
            serverMiddlePanel.TabIndex = 5;
            // 
            // serverFooterPanel
            // 
            serverFooterPanel.AutoSize = true;
            serverFooterPanel.Controls.Add(databaseGroupBox);
            serverFooterPanel.Dock = DockStyle.Top;
            serverFooterPanel.Location = new Point(0, 336);
            serverFooterPanel.Margin = new Padding(12, 0, 36, 4);
            serverFooterPanel.Name = "serverFooterPanel";
            serverFooterPanel.Padding = new Padding(0, 4, 0, 0);
            serverFooterPanel.Size = new Size(590, 122);
            serverFooterPanel.TabIndex = 6;
            // 
            // databaseGroupBox
            // 
            databaseGroupBox.AutoSize = true;
            databaseGroupBox.Controls.Add(selectDatabaseComboBox);
            databaseGroupBox.Controls.Add(selectDatabaseRadioButton);
            databaseGroupBox.Dock = DockStyle.Top;
            databaseGroupBox.FlatStyle = FlatStyle.System;
            databaseGroupBox.Location = new Point(0, 4);
            databaseGroupBox.Name = "databaseGroupBox";
            databaseGroupBox.Padding = new Padding(4);
            databaseGroupBox.Size = new Size(590, 118);
            databaseGroupBox.TabIndex = 0;
            databaseGroupBox.TabStop = false;
            databaseGroupBox.Text = "Connect to a database";
            // 
            // selectDatabaseComboBox
            // 
            selectDatabaseComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectDatabaseComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            selectDatabaseComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            selectDatabaseComboBox.FlatStyle = FlatStyle.System;
            selectDatabaseComboBox.FormattingEnabled = true;
            selectDatabaseComboBox.Location = new Point(34, 62);
            selectDatabaseComboBox.Margin = new Padding(36, 0, 12, 4);
            selectDatabaseComboBox.Name = "selectDatabaseComboBox";
            selectDatabaseComboBox.Size = new Size(531, 28);
            selectDatabaseComboBox.TabIndex = 2;
            // 
            // selectDatabaseRadioButton
            // 
            selectDatabaseRadioButton.AutoSize = true;
            selectDatabaseRadioButton.FlatStyle = FlatStyle.System;
            selectDatabaseRadioButton.Location = new Point(11, 35);
            selectDatabaseRadioButton.Margin = new Padding(12, 11, 12, 0);
            selectDatabaseRadioButton.Name = "selectDatabaseRadioButton";
            selectDatabaseRadioButton.Size = new Size(256, 25);
            selectDatabaseRadioButton.TabIndex = 1;
            selectDatabaseRadioButton.TabStop = true;
            selectDatabaseRadioButton.Text = "Select or enter a &database name:";
            selectDatabaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // serverLoginTableLayoutPanel
            // 
            serverLoginTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            serverLoginTableLayoutPanel.ColumnCount = 2;
            serverLoginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            serverLoginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            serverLoginTableLayoutPanel.Controls.Add(label1, 0, 0);
            serverLoginTableLayoutPanel.Location = new Point(7, 103);
            serverLoginTableLayoutPanel.Name = "serverLoginTableLayoutPanel";
            serverLoginTableLayoutPanel.RowCount = 3;
            serverLoginTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            serverLoginTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            serverLoginTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            serverLoginTableLayoutPanel.Size = new Size(554, 125);
            serverLoginTableLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // ExSqlDbConnectionBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(serverFooterPanel);
            Controls.Add(serverMiddlePanel);
            Controls.Add(serverHeaderPanel);
            Name = "ExSqlDbConnectionBox";
            Size = new Size(590, 462);
            logonGroupBox.ResumeLayout(false);
            logonGroupBox.PerformLayout();
            serverTableLayoutPanel.ResumeLayout(false);
            serverHeaderPanel.ResumeLayout(false);
            serverHeaderPanel.PerformLayout();
            serverMiddlePanel.ResumeLayout(false);
            serverFooterPanel.ResumeLayout(false);
            serverFooterPanel.PerformLayout();
            databaseGroupBox.ResumeLayout(false);
            databaseGroupBox.PerformLayout();
            serverLoginTableLayoutPanel.ResumeLayout(false);
            serverLoginTableLayoutPanel.PerformLayout();
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
        private Panel serverMiddlePanel;
        private Panel serverFooterPanel;
        private GroupBox databaseGroupBox;
        private RadioButton selectDatabaseRadioButton;
        private ComboBox selectDatabaseComboBox;
        private TableLayoutPanel serverLoginTableLayoutPanel;
        private Label label1;
    }
}
