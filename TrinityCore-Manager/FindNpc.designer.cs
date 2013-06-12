﻿namespace TrinityCore_Manager
{
    partial class FindNpc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindNpc));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.findNpcListView = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.findNpcIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.findNpcNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchLabel = new DevComponents.DotNetBar.LabelX();
            this.itemFindDisplayIdTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(206, 495);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(287, 495);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 14;
            this.okButton.Text = "Ok";
            // 
            // findNpcListView
            // 
            this.findNpcListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.findNpcListView.Border.Class = "ListViewBorder";
            this.findNpcListView.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.findNpcListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.findNpcIdColumnHeader,
            this.findNpcNameColumnHeader});
            this.findNpcListView.ForeColor = System.Drawing.Color.White;
            this.findNpcListView.Location = new System.Drawing.Point(1, 43);
            this.findNpcListView.Name = "findNpcListView";
            this.findNpcListView.Size = new System.Drawing.Size(361, 446);
            this.findNpcListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.findNpcListView.TabIndex = 13;
            this.findNpcListView.UseCompatibleStateImageBehavior = false;
            this.findNpcListView.View = System.Windows.Forms.View.Details;
            // 
            // findNpcIdColumnHeader
            // 
            this.findNpcIdColumnHeader.Text = "NPC ID";
            this.findNpcIdColumnHeader.Width = 92;
            // 
            // findNpcNameColumnHeader
            // 
            this.findNpcNameColumnHeader.Text = "NPC Name";
            this.findNpcNameColumnHeader.Width = 265;
            // 
            // searchLabel
            // 
            // 
            // 
            // 
            this.searchLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchLabel.Location = new System.Drawing.Point(1, -4);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(53, 20);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Search";
            // 
            // itemFindDisplayIdTextBox
            // 
            this.itemFindDisplayIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.itemFindDisplayIdTextBox.Border.Class = "TextBoxBorder";
            this.itemFindDisplayIdTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemFindDisplayIdTextBox.ForeColor = System.Drawing.Color.White;
            this.itemFindDisplayIdTextBox.Location = new System.Drawing.Point(1, 17);
            this.itemFindDisplayIdTextBox.Name = "itemFindDisplayIdTextBox";
            this.itemFindDisplayIdTextBox.Size = new System.Drawing.Size(361, 20);
            this.itemFindDisplayIdTextBox.TabIndex = 11;
            // 
            // FindNpc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 522);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.findNpcListView);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.itemFindDisplayIdTextBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindNpc";
            this.Text = "Find NPC";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ListViewEx findNpcListView;
        private System.Windows.Forms.ColumnHeader findNpcIdColumnHeader;
        private System.Windows.Forms.ColumnHeader findNpcNameColumnHeader;
        private DevComponents.DotNetBar.LabelX searchLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX itemFindDisplayIdTextBox;
    }
}