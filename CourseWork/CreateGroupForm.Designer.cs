namespace CourseWork
{
    partial class CreateGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroupForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.GroupNameLabel = new System.Windows.Forms.Label();
            this.GroupNameValue = new System.Windows.Forms.TextBox();
            this.SelectGroupMembers = new System.Windows.Forms.Label();
            this.GroupMembersListBox = new System.Windows.Forms.ListBox();
            this.SelectGroupMembersDropDown = new System.Windows.Forms.ComboBox();
            this.AddGroupMemberButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.CreateGroupButton = new System.Windows.Forms.Button();
            this.GroupMarkValue = new System.Windows.Forms.TextBox();
            this.GroupMarkLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(235, 45);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Create Group";
            // 
            // GroupNameLabel
            // 
            this.GroupNameLabel.AutoSize = true;
            this.GroupNameLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupNameLabel.Location = new System.Drawing.Point(31, 75);
            this.GroupNameLabel.Name = "GroupNameLabel";
            this.GroupNameLabel.Size = new System.Drawing.Size(165, 33);
            this.GroupNameLabel.TabIndex = 1;
            this.GroupNameLabel.Text = "Group Name";
            // 
            // GroupNameValue
            // 
            this.GroupNameValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupNameValue.Location = new System.Drawing.Point(37, 111);
            this.GroupNameValue.Name = "GroupNameValue";
            this.GroupNameValue.Size = new System.Drawing.Size(326, 30);
            this.GroupNameValue.TabIndex = 2;
            // 
            // SelectGroupMembers
            // 
            this.SelectGroupMembers.AutoSize = true;
            this.SelectGroupMembers.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectGroupMembers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectGroupMembers.Location = new System.Drawing.Point(31, 193);
            this.SelectGroupMembers.Name = "SelectGroupMembers";
            this.SelectGroupMembers.Size = new System.Drawing.Size(283, 33);
            this.SelectGroupMembers.TabIndex = 3;
            this.SelectGroupMembers.Text = "Select Group Members";
            // 
            // GroupMembersListBox
            // 
            this.GroupMembersListBox.FormattingEnabled = true;
            this.GroupMembersListBox.ItemHeight = 19;
            this.GroupMembersListBox.Location = new System.Drawing.Point(418, 111);
            this.GroupMembersListBox.Name = "GroupMembersListBox";
            this.GroupMembersListBox.Size = new System.Drawing.Size(394, 479);
            this.GroupMembersListBox.TabIndex = 4;
            // 
            // SelectGroupMembersDropDown
            // 
            this.SelectGroupMembersDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectGroupMembersDropDown.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SelectGroupMembersDropDown.FormattingEnabled = true;
            this.SelectGroupMembersDropDown.Location = new System.Drawing.Point(37, 230);
            this.SelectGroupMembersDropDown.Name = "SelectGroupMembersDropDown";
            this.SelectGroupMembersDropDown.Size = new System.Drawing.Size(375, 31);
            this.SelectGroupMembersDropDown.TabIndex = 5;
            // 
            // AddGroupMemberButton
            // 
            this.AddGroupMemberButton.BackColor = System.Drawing.Color.White;
            this.AddGroupMemberButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.AddGroupMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddGroupMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddGroupMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGroupMemberButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.AddGroupMemberButton.Location = new System.Drawing.Point(80, 277);
            this.AddGroupMemberButton.Name = "AddGroupMemberButton";
            this.AddGroupMemberButton.Size = new System.Drawing.Size(280, 55);
            this.AddGroupMemberButton.TabIndex = 6;
            this.AddGroupMemberButton.Text = "Add Member";
            this.AddGroupMemberButton.UseVisualStyleBackColor = false;
            this.AddGroupMemberButton.Click += new System.EventHandler(this.AddGroupMemberButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.BackColor = System.Drawing.Color.White;
            this.DeleteSelectedButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.DeleteSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DeleteSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.DeleteSelectedButton.Location = new System.Drawing.Point(818, 286);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(129, 91);
            this.DeleteSelectedButton.TabIndex = 21;
            this.DeleteSelectedButton.Text = "Delete Selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // CreateGroupButton
            // 
            this.CreateGroupButton.BackColor = System.Drawing.Color.White;
            this.CreateGroupButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.CreateGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateGroupButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.CreateGroupButton.Location = new System.Drawing.Point(257, 617);
            this.CreateGroupButton.Name = "CreateGroupButton";
            this.CreateGroupButton.Size = new System.Drawing.Size(436, 67);
            this.CreateGroupButton.TabIndex = 28;
            this.CreateGroupButton.Text = "Create Group";
            this.CreateGroupButton.UseVisualStyleBackColor = false;
            this.CreateGroupButton.Click += new System.EventHandler(this.CreateGroupButton_Click);
            // 
            // GroupMarkValue
            // 
            this.GroupMarkValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupMarkValue.Location = new System.Drawing.Point(83, 429);
            this.GroupMarkValue.Name = "GroupMarkValue";
            this.GroupMarkValue.Size = new System.Drawing.Size(210, 30);
            this.GroupMarkValue.TabIndex = 30;
            this.GroupMarkValue.Text = "0";
            // 
            // GroupMarkLabel
            // 
            this.GroupMarkLabel.AutoSize = true;
            this.GroupMarkLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupMarkLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupMarkLabel.Location = new System.Drawing.Point(77, 393);
            this.GroupMarkLabel.Name = "GroupMarkLabel";
            this.GroupMarkLabel.Size = new System.Drawing.Size(154, 33);
            this.GroupMarkLabel.TabIndex = 29;
            this.GroupMarkLabel.Text = "Group Mark";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumberLabel.Location = new System.Drawing.Point(290, 426);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(70, 33);
            this.NumberLabel.TabIndex = 31;
            this.NumberLabel.Text = "/100";
            // 
            // CreateGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 710);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.GroupMarkValue);
            this.Controls.Add(this.GroupMarkLabel);
            this.Controls.Add(this.CreateGroupButton);
            this.Controls.Add(this.DeleteSelectedButton);
            this.Controls.Add(this.AddGroupMemberButton);
            this.Controls.Add(this.SelectGroupMembersDropDown);
            this.Controls.Add(this.GroupMembersListBox);
            this.Controls.Add(this.SelectGroupMembers);
            this.Controls.Add(this.GroupNameValue);
            this.Controls.Add(this.GroupNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateGroupForm";
            this.Text = "Create Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label GroupNameLabel;
        private System.Windows.Forms.TextBox GroupNameValue;
        private System.Windows.Forms.Label SelectGroupMembers;
        private System.Windows.Forms.ListBox GroupMembersListBox;
        private System.Windows.Forms.ComboBox SelectGroupMembersDropDown;
        private System.Windows.Forms.Button AddGroupMemberButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button CreateGroupButton;
        private System.Windows.Forms.TextBox GroupMarkValue;
        private System.Windows.Forms.Label GroupMarkLabel;
        private System.Windows.Forms.Label NumberLabel;
    }
}