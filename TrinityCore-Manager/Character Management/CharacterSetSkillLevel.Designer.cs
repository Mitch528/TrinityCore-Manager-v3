﻿namespace TrinityCore_Manager
{
    partial class CharacterSetSkillLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSetSkillLevel));
            this.label1 = new DevComponents.DotNetBar.LabelX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new DevComponents.DotNetBar.LabelX();
            this.skillComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label3 = new DevComponents.DotNetBar.LabelX();
            this.label4 = new DevComponents.DotNetBar.LabelX();
            this.skillIntegerInput = new DevComponents.Editors.IntegerInput();
            this.characterLabel = new DevComponents.DotNetBar.LabelX();
            this.currentSkillLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.skillIntegerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(136, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character:";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 232);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 35);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(396, 232);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // label2
            // 
            // 
            // 
            // 
            this.label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(171, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Skill:";
            // 
            // skillComboBox
            // 
            this.skillComboBox.DisplayMember = "Text";
            this.skillComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skillComboBox.ForeColor = System.Drawing.Color.White;
            this.skillComboBox.FormattingEnabled = true;
            this.skillComboBox.ItemHeight = 14;
            this.skillComboBox.Location = new System.Drawing.Point(213, 73);
            this.skillComboBox.Name = "skillComboBox";
            this.skillComboBox.Size = new System.Drawing.Size(219, 20);
            this.skillComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.skillComboBox.TabIndex = 9;
            // 
            // label3
            // 
            // 
            // 
            // 
            this.label3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(80, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Current Skill Level:";
            // 
            // label4
            // 
            // 
            // 
            // 
            this.label4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(106, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Set Skill Level:";
            // 
            // skillIntegerInput
            // 
            // 
            // 
            // 
            this.skillIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.skillIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.skillIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.skillIntegerInput.Location = new System.Drawing.Point(213, 177);
            this.skillIntegerInput.Name = "skillIntegerInput";
            this.skillIntegerInput.ShowUpDown = true;
            this.skillIntegerInput.Size = new System.Drawing.Size(104, 20);
            this.skillIntegerInput.TabIndex = 12;
            // 
            // characterLabel
            // 
            // 
            // 
            // 
            this.characterLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.characterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.characterLabel.Location = new System.Drawing.Point(213, 26);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(219, 23);
            this.characterLabel.TabIndex = 13;
            // 
            // currentSkillLabel
            // 
            // 
            // 
            // 
            this.currentSkillLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.currentSkillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.currentSkillLabel.Location = new System.Drawing.Point(213, 119);
            this.currentSkillLabel.Name = "currentSkillLabel";
            this.currentSkillLabel.Size = new System.Drawing.Size(104, 23);
            this.currentSkillLabel.TabIndex = 14;
            // 
            // CharacterSetSkillLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 279);
            this.Controls.Add(this.currentSkillLabel);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.skillIntegerInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skillComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 317);
            this.Name = "CharacterSetSkillLevel";
            this.Text = "Character Set Skill Level";
            ((System.ComponentModel.ISupportInitialize)(this.skillIntegerInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX label1;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.LabelX label2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx skillComboBox;
        private DevComponents.DotNetBar.LabelX label3;
        private DevComponents.DotNetBar.LabelX label4;
        private DevComponents.Editors.IntegerInput skillIntegerInput;
        private DevComponents.DotNetBar.LabelX characterLabel;
        private DevComponents.DotNetBar.LabelX currentSkillLabel;
    }
}