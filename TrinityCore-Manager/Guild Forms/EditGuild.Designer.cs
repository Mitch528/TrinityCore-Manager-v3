﻿namespace TrinityCore_Manager
{
    partial class EditGuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGuild));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.guildLeaderComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.leaderNameLabel = new DevComponents.DotNetBar.LabelX();
            this.guildNameLabel = new DevComponents.DotNetBar.LabelX();
            this.guildNameComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.guildListView = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.guildRankColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guildMemberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inviteButton = new DevComponents.DotNetBar.ButtonX();
            this.uninviteButton = new DevComponents.DotNetBar.ButtonX();
            this.playerListLabel = new DevComponents.DotNetBar.LabelX();
            this.playerListComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ranksComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 548);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(461, 548);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(85, 33);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Ok";
            this.okButton.TextColor = System.Drawing.Color.Chartreuse;
            // 
            // guildLeaderComboBox
            // 
            this.guildLeaderComboBox.DisplayMember = "Text";
            this.guildLeaderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guildLeaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guildLeaderComboBox.ForeColor = System.Drawing.Color.White;
            this.guildLeaderComboBox.FormattingEnabled = true;
            this.guildLeaderComboBox.ItemHeight = 14;
            this.guildLeaderComboBox.Location = new System.Drawing.Point(205, 48);
            this.guildLeaderComboBox.Name = "guildLeaderComboBox";
            this.guildLeaderComboBox.Size = new System.Drawing.Size(177, 20);
            this.guildLeaderComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.guildLeaderComboBox.TabIndex = 7;
            this.guildLeaderComboBox.SelectedIndexChanged += new System.EventHandler(this.guildLeaderComboBox_SelectedIndexChanged);
            // 
            // leaderNameLabel
            // 
            // 
            // 
            // 
            this.leaderNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.leaderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.leaderNameLabel.Location = new System.Drawing.Point(107, 44);
            this.leaderNameLabel.Name = "leaderNameLabel";
            this.leaderNameLabel.Size = new System.Drawing.Size(92, 23);
            this.leaderNameLabel.TabIndex = 6;
            this.leaderNameLabel.Text = "Guild Master:";
            // 
            // guildNameLabel
            // 
            // 
            // 
            // 
            this.guildNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.guildNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.guildNameLabel.Location = new System.Drawing.Point(156, 9);
            this.guildNameLabel.Name = "guildNameLabel";
            this.guildNameLabel.Size = new System.Drawing.Size(43, 23);
            this.guildNameLabel.TabIndex = 10;
            this.guildNameLabel.Text = "Guild:";
            // 
            // guildNameComboBox
            // 
            this.guildNameComboBox.DisplayMember = "Text";
            this.guildNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guildNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guildNameComboBox.ForeColor = System.Drawing.Color.White;
            this.guildNameComboBox.FormattingEnabled = true;
            this.guildNameComboBox.ItemHeight = 14;
            this.guildNameComboBox.Location = new System.Drawing.Point(205, 12);
            this.guildNameComboBox.Name = "guildNameComboBox";
            this.guildNameComboBox.Size = new System.Drawing.Size(177, 20);
            this.guildNameComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.guildNameComboBox.TabIndex = 11;
            this.guildNameComboBox.SelectedIndexChanged += new System.EventHandler(this.guildNameComboBox_SelectedIndexChanged);
            // 
            // guildListView
            // 
            this.guildListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.guildListView.Border.Class = "ListViewBorder";
            this.guildListView.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.guildListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.guildRankColumnHeader,
            this.guildMemberColumnHeader});
            this.guildListView.ForeColor = System.Drawing.Color.White;
            this.guildListView.FullRowSelect = true;
            this.guildListView.Location = new System.Drawing.Point(12, 157);
            this.guildListView.Name = "guildListView";
            this.guildListView.Size = new System.Drawing.Size(534, 369);
            this.guildListView.TabIndex = 12;
            this.guildListView.UseCompatibleStateImageBehavior = false;
            this.guildListView.View = System.Windows.Forms.View.Details;
            // 
            // guildRankColumnHeader
            // 
            this.guildRankColumnHeader.Text = "Guild Rank";
            this.guildRankColumnHeader.Width = 129;
            // 
            // guildMemberColumnHeader
            // 
            this.guildMemberColumnHeader.Text = "Member";
            this.guildMemberColumnHeader.Width = 397;
            // 
            // inviteButton
            // 
            this.inviteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.inviteButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.inviteButton.Location = new System.Drawing.Point(391, 83);
            this.inviteButton.Name = "inviteButton";
            this.inviteButton.Size = new System.Drawing.Size(78, 65);
            this.inviteButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.inviteButton.TabIndex = 13;
            this.inviteButton.Text = "Invite";
            this.inviteButton.Click += new System.EventHandler(this.inviteButton_Click);
            // 
            // uninviteButton
            // 
            this.uninviteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.uninviteButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.uninviteButton.Location = new System.Drawing.Point(219, 532);
            this.uninviteButton.Name = "uninviteButton";
            this.uninviteButton.Size = new System.Drawing.Size(85, 33);
            this.uninviteButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.uninviteButton.TabIndex = 14;
            this.uninviteButton.Text = "Uninvite from guild";
            this.uninviteButton.Click += new System.EventHandler(this.uninviteButton_Click);
            // 
            // playerListLabel
            // 
            // 
            // 
            // 
            this.playerListLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.playerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.playerListLabel.Location = new System.Drawing.Point(30, 83);
            this.playerListLabel.Name = "playerListLabel";
            this.playerListLabel.Size = new System.Drawing.Size(169, 23);
            this.playerListLabel.TabIndex = 15;
            this.playerListLabel.Text = "Invite new player to guild:";
            // 
            // playerListComboBox
            // 
            this.playerListComboBox.DisplayMember = "Text";
            this.playerListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.playerListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerListComboBox.ForeColor = System.Drawing.Color.White;
            this.playerListComboBox.FormattingEnabled = true;
            this.playerListComboBox.ItemHeight = 14;
            this.playerListComboBox.Location = new System.Drawing.Point(205, 86);
            this.playerListComboBox.Name = "playerListComboBox";
            this.playerListComboBox.Size = new System.Drawing.Size(177, 20);
            this.playerListComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.playerListComboBox.TabIndex = 16;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(154, 125);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(45, 23);
            this.labelX1.TabIndex = 17;
            this.labelX1.Text = "Rank:";
            // 
            // ranksComboBox
            // 
            this.ranksComboBox.DisplayMember = "Text";
            this.ranksComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ranksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ranksComboBox.ForeColor = System.Drawing.Color.White;
            this.ranksComboBox.FormattingEnabled = true;
            this.ranksComboBox.ItemHeight = 14;
            this.ranksComboBox.Location = new System.Drawing.Point(205, 128);
            this.ranksComboBox.Name = "ranksComboBox";
            this.ranksComboBox.Size = new System.Drawing.Size(177, 20);
            this.ranksComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ranksComboBox.TabIndex = 18;
            // 
            // EditGuild
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(554, 589);
            this.Controls.Add(this.ranksComboBox);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.playerListComboBox);
            this.Controls.Add(this.playerListLabel);
            this.Controls.Add(this.uninviteButton);
            this.Controls.Add(this.inviteButton);
            this.Controls.Add(this.guildListView);
            this.Controls.Add(this.guildNameComboBox);
            this.Controls.Add(this.guildNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.guildLeaderComboBox);
            this.Controls.Add(this.leaderNameLabel);
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 631);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 631);
            this.Name = "EditGuild";
            this.Text = "Edit Guild";
            this.Load += new System.EventHandler(this.EditGuild_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx guildLeaderComboBox;
        private DevComponents.DotNetBar.LabelX leaderNameLabel;
        private DevComponents.DotNetBar.LabelX guildNameLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx guildNameComboBox;
        private DevComponents.DotNetBar.Controls.ListViewEx guildListView;
        private System.Windows.Forms.ColumnHeader guildRankColumnHeader;
        private System.Windows.Forms.ColumnHeader guildMemberColumnHeader;
        private DevComponents.DotNetBar.ButtonX inviteButton;
        private DevComponents.DotNetBar.ButtonX uninviteButton;
        private DevComponents.DotNetBar.LabelX playerListLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx playerListComboBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ranksComboBox;
    }
}