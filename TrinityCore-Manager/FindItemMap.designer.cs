﻿namespace TrinityCore_Manager
{
    partial class FindItemMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindItemMap));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.itemFindMapListView = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.itemMapIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemAreaNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchLabel = new DevComponents.DotNetBar.LabelX();
            this.itemFindDisplayIdTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(208, 496);
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
            this.okButton.Location = new System.Drawing.Point(289, 496);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 14;
            this.okButton.Text = "Ok";
            // 
            // itemFindMapListView
            // 
            this.itemFindMapListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.itemFindMapListView.Border.Class = "ListViewBorder";
            this.itemFindMapListView.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemFindMapListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemMapIdColumnHeader,
            this.itemAreaNameColumnHeader});
            this.itemFindMapListView.ForeColor = System.Drawing.Color.White;
            this.itemFindMapListView.Location = new System.Drawing.Point(3, 44);
            this.itemFindMapListView.Name = "itemFindMapListView";
            this.itemFindMapListView.Size = new System.Drawing.Size(361, 446);
            this.itemFindMapListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.itemFindMapListView.TabIndex = 13;
            this.itemFindMapListView.UseCompatibleStateImageBehavior = false;
            this.itemFindMapListView.View = System.Windows.Forms.View.Details;
            // 
            // itemMapIdColumnHeader
            // 
            this.itemMapIdColumnHeader.Text = "Map ID";
            this.itemMapIdColumnHeader.Width = 76;
            // 
            // itemAreaNameColumnHeader
            // 
            this.itemAreaNameColumnHeader.Text = "Map Name";
            this.itemAreaNameColumnHeader.Width = 275;
            // 
            // searchLabel
            // 
            // 
            // 
            // 
            this.searchLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchLabel.Location = new System.Drawing.Point(3, -3);
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
            this.itemFindDisplayIdTextBox.Location = new System.Drawing.Point(3, 18);
            this.itemFindDisplayIdTextBox.Name = "itemFindDisplayIdTextBox";
            this.itemFindDisplayIdTextBox.Size = new System.Drawing.Size(361, 20);
            this.itemFindDisplayIdTextBox.TabIndex = 11;
            // 
            // FindItemMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 522);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.itemFindMapListView);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.itemFindDisplayIdTextBox);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 560);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 560);
            this.Name = "FindItemMap";
            this.Text = "Find Item Map";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ListViewEx itemFindMapListView;
        private System.Windows.Forms.ColumnHeader itemMapIdColumnHeader;
        private System.Windows.Forms.ColumnHeader itemAreaNameColumnHeader;
        private DevComponents.DotNetBar.LabelX searchLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX itemFindDisplayIdTextBox;
    }
}