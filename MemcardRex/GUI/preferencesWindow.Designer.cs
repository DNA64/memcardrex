﻿namespace MemcardRex
{
    partial class preferencesWindow
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.fontCombo = new System.Windows.Forms.ComboBox();
            this.fontLabel = new System.Windows.Forms.Label();
            this.gridCheckbox = new System.Windows.Forms.CheckBox();
            this.iconSizeLabel = new System.Windows.Forms.Label();
            this.iconSizeCombo = new System.Windows.Forms.ComboBox();
            this.interpolationCombo = new System.Windows.Forms.ComboBox();
            this.interpolationLabel = new System.Windows.Forms.Label();
            this.backupWarningCheckBox = new System.Windows.Forms.CheckBox();
            this.glassCheckbox = new System.Windows.Forms.CheckBox();
            this.backupCheckbox = new System.Windows.Forms.CheckBox();
            this.dexDriveCombo = new System.Windows.Forms.ComboBox();
            this.hardwarePortLabel = new System.Windows.Forms.Label();
            this.spacerLabel = new System.Windows.Forms.Label();
            this.restorePositionCheckbox = new System.Windows.Forms.CheckBox();
            this.formatCombo = new System.Windows.Forms.ComboBox();
            this.formatLabel = new System.Windows.Forms.Label();
            this.backgroundCombo = new System.Windows.Forms.ComboBox();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.fixCorruptedCardsCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remoteAddressBox = new System.Windows.Forms.TextBox();
            this.remotePortUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.remotePortUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(224, 246);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(76, 24);
            this.okButton.TabIndex = 99;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.Location = new System.Drawing.Point(304, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(76, 24);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.applyButton.Location = new System.Drawing.Point(384, 246);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(76, 24);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // fontCombo
            // 
            this.fontCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontCombo.FormattingEnabled = true;
            this.fontCombo.Location = new System.Drawing.Point(4, 20);
            this.fontCombo.Name = "fontCombo";
            this.fontCombo.Size = new System.Drawing.Size(236, 21);
            this.fontCombo.TabIndex = 3;
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(4, 4);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(75, 13);
            this.fontLabel.TabIndex = 3;
            this.fontLabel.Text = "Save title font:";
            // 
            // gridCheckbox
            // 
            this.gridCheckbox.AutoSize = true;
            this.gridCheckbox.Location = new System.Drawing.Point(248, 12);
            this.gridCheckbox.Name = "gridCheckbox";
            this.gridCheckbox.Size = new System.Drawing.Size(125, 17);
            this.gridCheckbox.TabIndex = 9;
            this.gridCheckbox.Text = "Show grid on slot list.";
            this.gridCheckbox.UseVisualStyleBackColor = true;
            // 
            // iconSizeLabel
            // 
            this.iconSizeLabel.AutoSize = true;
            this.iconSizeLabel.Location = new System.Drawing.Point(124, 48);
            this.iconSizeLabel.Name = "iconSizeLabel";
            this.iconSizeLabel.Size = new System.Drawing.Size(52, 13);
            this.iconSizeLabel.TabIndex = 5;
            this.iconSizeLabel.Text = "Icon size:";
            // 
            // iconSizeCombo
            // 
            this.iconSizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iconSizeCombo.FormattingEnabled = true;
            this.iconSizeCombo.Items.AddRange(new object[] {
            "Medium",
            "Large"});
            this.iconSizeCombo.Location = new System.Drawing.Point(124, 64);
            this.iconSizeCombo.Name = "iconSizeCombo";
            this.iconSizeCombo.Size = new System.Drawing.Size(116, 21);
            this.iconSizeCombo.TabIndex = 5;
            // 
            // interpolationCombo
            // 
            this.interpolationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interpolationCombo.FormattingEnabled = true;
            this.interpolationCombo.Items.AddRange(new object[] {
            "Nearest Neighbor",
            "Bilinear"});
            this.interpolationCombo.Location = new System.Drawing.Point(4, 64);
            this.interpolationCombo.Name = "interpolationCombo";
            this.interpolationCombo.Size = new System.Drawing.Size(116, 21);
            this.interpolationCombo.TabIndex = 4;
            // 
            // interpolationLabel
            // 
            this.interpolationLabel.AutoSize = true;
            this.interpolationLabel.Location = new System.Drawing.Point(4, 48);
            this.interpolationLabel.Name = "interpolationLabel";
            this.interpolationLabel.Size = new System.Drawing.Size(53, 13);
            this.interpolationLabel.TabIndex = 0;
            this.interpolationLabel.Text = "Icon filter:";
            // 
            // backupWarningCheckBox
            // 
            this.backupWarningCheckBox.AutoSize = true;
            this.backupWarningCheckBox.Location = new System.Drawing.Point(248, 60);
            this.backupWarningCheckBox.Name = "backupWarningCheckBox";
            this.backupWarningCheckBox.Size = new System.Drawing.Size(212, 17);
            this.backupWarningCheckBox.TabIndex = 11;
            this.backupWarningCheckBox.Text = "Show warning messages (save editing).";
            this.backupWarningCheckBox.UseVisualStyleBackColor = true;
            // 
            // glassCheckbox
            // 
            this.glassCheckbox.AutoSize = true;
            this.glassCheckbox.Location = new System.Drawing.Point(248, 84);
            this.glassCheckbox.Name = "glassCheckbox";
            this.glassCheckbox.Size = new System.Drawing.Size(101, 17);
            this.glassCheckbox.TabIndex = 12;
            this.glassCheckbox.Text = "Glass status bar";
            this.glassCheckbox.UseVisualStyleBackColor = true;
            // 
            // backupCheckbox
            // 
            this.backupCheckbox.AutoSize = true;
            this.backupCheckbox.Location = new System.Drawing.Point(248, 36);
            this.backupCheckbox.Name = "backupCheckbox";
            this.backupCheckbox.Size = new System.Drawing.Size(204, 17);
            this.backupCheckbox.TabIndex = 10;
            this.backupCheckbox.Text = "Backup Memory Cards upon opening.";
            this.backupCheckbox.UseVisualStyleBackColor = true;
            // 
            // dexDriveCombo
            // 
            this.dexDriveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dexDriveCombo.FormattingEnabled = true;
            this.dexDriveCombo.Location = new System.Drawing.Point(4, 152);
            this.dexDriveCombo.Name = "dexDriveCombo";
            this.dexDriveCombo.Size = new System.Drawing.Size(116, 21);
            this.dexDriveCombo.TabIndex = 7;
            this.dexDriveCombo.SelectedIndexChanged += new System.EventHandler(this.dexDriveCombo_SelectedIndexChanged);
            // 
            // hardwarePortLabel
            // 
            this.hardwarePortLabel.AutoSize = true;
            this.hardwarePortLabel.Location = new System.Drawing.Point(4, 136);
            this.hardwarePortLabel.Name = "hardwarePortLabel";
            this.hardwarePortLabel.Size = new System.Drawing.Size(103, 13);
            this.hardwarePortLabel.TabIndex = 6;
            this.hardwarePortLabel.Text = "Communication port:";
            // 
            // spacerLabel
            // 
            this.spacerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spacerLabel.Location = new System.Drawing.Point(4, 241);
            this.spacerLabel.Name = "spacerLabel";
            this.spacerLabel.Size = new System.Drawing.Size(456, 2);
            this.spacerLabel.TabIndex = 8;
            // 
            // restorePositionCheckbox
            // 
            this.restorePositionCheckbox.AutoSize = true;
            this.restorePositionCheckbox.Location = new System.Drawing.Point(248, 108);
            this.restorePositionCheckbox.Name = "restorePositionCheckbox";
            this.restorePositionCheckbox.Size = new System.Drawing.Size(191, 17);
            this.restorePositionCheckbox.TabIndex = 13;
            this.restorePositionCheckbox.Text = "Restore window position on startup";
            this.restorePositionCheckbox.UseVisualStyleBackColor = true;
            // 
            // formatCombo
            // 
            this.formatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatCombo.FormattingEnabled = true;
            this.formatCombo.Items.AddRange(new object[] {
            "Quick format",
            "Full format"});
            this.formatCombo.Location = new System.Drawing.Point(124, 152);
            this.formatCombo.Name = "formatCombo";
            this.formatCombo.Size = new System.Drawing.Size(116, 21);
            this.formatCombo.TabIndex = 8;
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(124, 136);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(111, 13);
            this.formatLabel.TabIndex = 101;
            this.formatLabel.Text = "Hardware format type:";
            // 
            // backgroundCombo
            // 
            this.backgroundCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backgroundCombo.FormattingEnabled = true;
            this.backgroundCombo.Items.AddRange(new object[] {
            "Transparent",
            "Black (Slim PS1 models)",
            "Gray (Older european PS1 models)",
            "Blue (Standard BIOS color)"});
            this.backgroundCombo.Location = new System.Drawing.Point(4, 108);
            this.backgroundCombo.Name = "backgroundCombo";
            this.backgroundCombo.Size = new System.Drawing.Size(236, 21);
            this.backgroundCombo.TabIndex = 6;
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(4, 92);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(117, 13);
            this.backgroundLabel.TabIndex = 102;
            this.backgroundLabel.Text = "Icon background color:";
            // 
            // fixCorruptedCardsCheckbox
            // 
            this.fixCorruptedCardsCheckbox.AutoSize = true;
            this.fixCorruptedCardsCheckbox.Location = new System.Drawing.Point(248, 132);
            this.fixCorruptedCardsCheckbox.Name = "fixCorruptedCardsCheckbox";
            this.fixCorruptedCardsCheckbox.Size = new System.Drawing.Size(184, 17);
            this.fixCorruptedCardsCheckbox.TabIndex = 103;
            this.fixCorruptedCardsCheckbox.Text = "Try to fix corrupted Memory Cards";
            this.fixCorruptedCardsCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Remote Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Remote Address:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // remoteAddressBox
            // 
            this.remoteAddressBox.Location = new System.Drawing.Point(7, 199);
            this.remoteAddressBox.Name = "remoteAddressBox";
            this.remoteAddressBox.Size = new System.Drawing.Size(113, 20);
            this.remoteAddressBox.TabIndex = 106;
            this.remoteAddressBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // remotePortUpDown
            // 
            this.remotePortUpDown.Location = new System.Drawing.Point(124, 199);
            this.remotePortUpDown.Name = "remotePortUpDown";
            this.remotePortUpDown.Size = new System.Drawing.Size(120, 20);
            this.remotePortUpDown.TabIndex = 107;
            // 
            // preferencesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 279);
            this.Controls.Add(this.remotePortUpDown);
            this.Controls.Add(this.remoteAddressBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fixCorruptedCardsCheckbox);
            this.Controls.Add(this.backgroundCombo);
            this.Controls.Add(this.backgroundLabel);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.formatCombo);
            this.Controls.Add(this.restorePositionCheckbox);
            this.Controls.Add(this.spacerLabel);
            this.Controls.Add(this.gridCheckbox);
            this.Controls.Add(this.glassCheckbox);
            this.Controls.Add(this.backupWarningCheckBox);
            this.Controls.Add(this.iconSizeLabel);
            this.Controls.Add(this.backupCheckbox);
            this.Controls.Add(this.iconSizeCombo);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.interpolationCombo);
            this.Controls.Add(this.dexDriveCombo);
            this.Controls.Add(this.interpolationLabel);
            this.Controls.Add(this.fontCombo);
            this.Controls.Add(this.hardwarePortLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "preferencesWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.remotePortUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox gridCheckbox;
        private System.Windows.Forms.ComboBox fontCombo;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.ComboBox interpolationCombo;
        private System.Windows.Forms.Label interpolationLabel;
        private System.Windows.Forms.CheckBox backupCheckbox;
        private System.Windows.Forms.CheckBox glassCheckbox;
        private System.Windows.Forms.CheckBox backupWarningCheckBox;
        private System.Windows.Forms.Label iconSizeLabel;
        private System.Windows.Forms.ComboBox iconSizeCombo;
        private System.Windows.Forms.ComboBox dexDriveCombo;
        private System.Windows.Forms.Label hardwarePortLabel;
        private System.Windows.Forms.Label spacerLabel;
        private System.Windows.Forms.CheckBox restorePositionCheckbox;
        private System.Windows.Forms.ComboBox formatCombo;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.ComboBox backgroundCombo;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.CheckBox fixCorruptedCardsCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox remoteAddressBox;
        private System.Windows.Forms.NumericUpDown remotePortUpDown;
    }
}