namespace CourseWork
{
    partial class GroupViewerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupViewerForm));
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentsTabView = new System.Windows.Forms.TabControl();
            this.StudentsTab = new System.Windows.Forms.TabPage();
            this.StudentSortButton = new System.Windows.Forms.Button();
            this.BulkAssignButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.StudentSearchButton = new System.Windows.Forms.Button();
            this.StudentSearchValue = new System.Windows.Forms.TextBox();
            this.CreateNewStudentButton = new System.Windows.Forms.Button();
            this.StudentsViewerHeaderLabel = new System.Windows.Forms.Label();
            this.GroupsTab = new System.Windows.Forms.TabPage();
            this.GroupSortButton = new System.Windows.Forms.Button();
            this.GroupRefreshButton = new System.Windows.Forms.Button();
            this.GroupSeachButton = new System.Windows.Forms.Button();
            this.GroupSearchValue = new System.Windows.Forms.TextBox();
            this.GroupsViewerLabel = new System.Windows.Forms.Label();
            this.CreateNewGroupButton = new System.Windows.Forms.Button();
            this.GroupsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            this.StudentsTabView.SuspendLayout();
            this.StudentsTab.SuspendLayout();
            this.GroupsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.StudentsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.StudentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.StudentsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.StudentsDataGridView.Location = new System.Drawing.Point(3, 57);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.ReadOnly = true;
            this.StudentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsDataGridView.Size = new System.Drawing.Size(899, 467);
            this.StudentsDataGridView.TabIndex = 0;
            // 
            // StudentsTabView
            // 
            this.StudentsTabView.Controls.Add(this.StudentsTab);
            this.StudentsTabView.Controls.Add(this.GroupsTab);
            this.StudentsTabView.Location = new System.Drawing.Point(12, 12);
            this.StudentsTabView.Name = "StudentsTabView";
            this.StudentsTabView.SelectedIndex = 0;
            this.StudentsTabView.Size = new System.Drawing.Size(916, 634);
            this.StudentsTabView.TabIndex = 1;
            // 
            // StudentsTab
            // 
            this.StudentsTab.BackColor = System.Drawing.Color.White;
            this.StudentsTab.Controls.Add(this.StudentSortButton);
            this.StudentsTab.Controls.Add(this.BulkAssignButton);
            this.StudentsTab.Controls.Add(this.RefreshButton);
            this.StudentsTab.Controls.Add(this.StudentSearchButton);
            this.StudentsTab.Controls.Add(this.StudentSearchValue);
            this.StudentsTab.Controls.Add(this.CreateNewStudentButton);
            this.StudentsTab.Controls.Add(this.StudentsViewerHeaderLabel);
            this.StudentsTab.Controls.Add(this.StudentsDataGridView);
            this.StudentsTab.Location = new System.Drawing.Point(4, 28);
            this.StudentsTab.Name = "StudentsTab";
            this.StudentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsTab.Size = new System.Drawing.Size(908, 602);
            this.StudentsTab.TabIndex = 0;
            this.StudentsTab.Text = "Students";
            // 
            // StudentSortButton
            // 
            this.StudentSortButton.BackColor = System.Drawing.Color.White;
            this.StudentSortButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.StudentSortButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StudentSortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.StudentSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentSortButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.StudentSortButton.Location = new System.Drawing.Point(295, 18);
            this.StudentSortButton.Name = "StudentSortButton";
            this.StudentSortButton.Size = new System.Drawing.Size(97, 30);
            this.StudentSortButton.TabIndex = 35;
            this.StudentSortButton.Text = "Sort";
            this.StudentSortButton.UseVisualStyleBackColor = false;
            this.StudentSortButton.Click += new System.EventHandler(this.StudentSortButton_Click);
            // 
            // BulkAssignButton
            // 
            this.BulkAssignButton.BackColor = System.Drawing.Color.White;
            this.BulkAssignButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BulkAssignButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BulkAssignButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BulkAssignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BulkAssignButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.BulkAssignButton.Location = new System.Drawing.Point(720, 529);
            this.BulkAssignButton.Name = "BulkAssignButton";
            this.BulkAssignButton.Size = new System.Drawing.Size(129, 67);
            this.BulkAssignButton.TabIndex = 34;
            this.BulkAssignButton.Text = "Bulk Assign";
            this.BulkAssignButton.UseVisualStyleBackColor = false;
            this.BulkAssignButton.Click += new System.EventHandler(this.BulkAssignButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.White;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.RefreshButton.Location = new System.Drawing.Point(398, 18);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(97, 30);
            this.RefreshButton.TabIndex = 33;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // StudentSearchButton
            // 
            this.StudentSearchButton.BackColor = System.Drawing.Color.White;
            this.StudentSearchButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.StudentSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StudentSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.StudentSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentSearchButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.StudentSearchButton.Location = new System.Drawing.Point(501, 18);
            this.StudentSearchButton.Name = "StudentSearchButton";
            this.StudentSearchButton.Size = new System.Drawing.Size(97, 30);
            this.StudentSearchButton.TabIndex = 32;
            this.StudentSearchButton.Text = "Search";
            this.StudentSearchButton.UseVisualStyleBackColor = false;
            this.StudentSearchButton.Click += new System.EventHandler(this.StudentSearchButton_Click);
            // 
            // StudentSearchValue
            // 
            this.StudentSearchValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentSearchValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSearchValue.Location = new System.Drawing.Point(604, 18);
            this.StudentSearchValue.Name = "StudentSearchValue";
            this.StudentSearchValue.Size = new System.Drawing.Size(298, 30);
            this.StudentSearchValue.TabIndex = 30;
            // 
            // CreateNewStudentButton
            // 
            this.CreateNewStudentButton.BackColor = System.Drawing.Color.White;
            this.CreateNewStudentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.CreateNewStudentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateNewStudentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateNewStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewStudentButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.CreateNewStudentButton.Location = new System.Drawing.Point(239, 531);
            this.CreateNewStudentButton.Name = "CreateNewStudentButton";
            this.CreateNewStudentButton.Size = new System.Drawing.Size(436, 67);
            this.CreateNewStudentButton.TabIndex = 29;
            this.CreateNewStudentButton.Text = "Create New Student";
            this.CreateNewStudentButton.UseVisualStyleBackColor = false;
            this.CreateNewStudentButton.Click += new System.EventHandler(this.CreateNewStudentButton_Click);
            // 
            // StudentsViewerHeaderLabel
            // 
            this.StudentsViewerHeaderLabel.AutoSize = true;
            this.StudentsViewerHeaderLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsViewerHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StudentsViewerHeaderLabel.Location = new System.Drawing.Point(3, 3);
            this.StudentsViewerHeaderLabel.Name = "StudentsViewerHeaderLabel";
            this.StudentsViewerHeaderLabel.Size = new System.Drawing.Size(283, 45);
            this.StudentsViewerHeaderLabel.TabIndex = 2;
            this.StudentsViewerHeaderLabel.Text = "Students Viewer";
            // 
            // GroupsTab
            // 
            this.GroupsTab.BackColor = System.Drawing.Color.White;
            this.GroupsTab.Controls.Add(this.GroupSortButton);
            this.GroupsTab.Controls.Add(this.GroupRefreshButton);
            this.GroupsTab.Controls.Add(this.GroupSeachButton);
            this.GroupsTab.Controls.Add(this.GroupSearchValue);
            this.GroupsTab.Controls.Add(this.GroupsViewerLabel);
            this.GroupsTab.Controls.Add(this.CreateNewGroupButton);
            this.GroupsTab.Controls.Add(this.GroupsDataGridView);
            this.GroupsTab.Location = new System.Drawing.Point(4, 28);
            this.GroupsTab.Name = "GroupsTab";
            this.GroupsTab.Padding = new System.Windows.Forms.Padding(3);
            this.GroupsTab.Size = new System.Drawing.Size(908, 602);
            this.GroupsTab.TabIndex = 1;
            this.GroupsTab.Text = "Groups";
            // 
            // GroupSortButton
            // 
            this.GroupSortButton.BackColor = System.Drawing.Color.White;
            this.GroupSortButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.GroupSortButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GroupSortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupSortButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.GroupSortButton.Location = new System.Drawing.Point(295, 18);
            this.GroupSortButton.Name = "GroupSortButton";
            this.GroupSortButton.Size = new System.Drawing.Size(97, 30);
            this.GroupSortButton.TabIndex = 37;
            this.GroupSortButton.Text = "Sort";
            this.GroupSortButton.UseVisualStyleBackColor = false;
            this.GroupSortButton.Click += new System.EventHandler(this.GroupSortButton_Click);
            // 
            // GroupRefreshButton
            // 
            this.GroupRefreshButton.BackColor = System.Drawing.Color.White;
            this.GroupRefreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.GroupRefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GroupRefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupRefreshButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.GroupRefreshButton.Location = new System.Drawing.Point(398, 18);
            this.GroupRefreshButton.Name = "GroupRefreshButton";
            this.GroupRefreshButton.Size = new System.Drawing.Size(97, 30);
            this.GroupRefreshButton.TabIndex = 36;
            this.GroupRefreshButton.Text = "Refresh";
            this.GroupRefreshButton.UseVisualStyleBackColor = false;
            this.GroupRefreshButton.Click += new System.EventHandler(this.GroupRefreshButton_Click);
            // 
            // GroupSeachButton
            // 
            this.GroupSeachButton.BackColor = System.Drawing.Color.White;
            this.GroupSeachButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.GroupSeachButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GroupSeachButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupSeachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupSeachButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.GroupSeachButton.Location = new System.Drawing.Point(501, 18);
            this.GroupSeachButton.Name = "GroupSeachButton";
            this.GroupSeachButton.Size = new System.Drawing.Size(97, 30);
            this.GroupSeachButton.TabIndex = 33;
            this.GroupSeachButton.Text = "Search";
            this.GroupSeachButton.UseVisualStyleBackColor = false;
            this.GroupSeachButton.Click += new System.EventHandler(this.GroupSeachButton_Click);
            // 
            // GroupSearchValue
            // 
            this.GroupSearchValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupSearchValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupSearchValue.Location = new System.Drawing.Point(604, 18);
            this.GroupSearchValue.Name = "GroupSearchValue";
            this.GroupSearchValue.Size = new System.Drawing.Size(298, 30);
            this.GroupSearchValue.TabIndex = 32;
            // 
            // GroupsViewerLabel
            // 
            this.GroupsViewerLabel.AutoSize = true;
            this.GroupsViewerLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupsViewerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupsViewerLabel.Location = new System.Drawing.Point(6, 3);
            this.GroupsViewerLabel.Name = "GroupsViewerLabel";
            this.GroupsViewerLabel.Size = new System.Drawing.Size(256, 45);
            this.GroupsViewerLabel.TabIndex = 31;
            this.GroupsViewerLabel.Text = "Groups Viewer";
            this.GroupsViewerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateNewGroupButton
            // 
            this.CreateNewGroupButton.BackColor = System.Drawing.Color.White;
            this.CreateNewGroupButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.CreateNewGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateNewGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateNewGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewGroupButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.CreateNewGroupButton.Location = new System.Drawing.Point(239, 531);
            this.CreateNewGroupButton.Name = "CreateNewGroupButton";
            this.CreateNewGroupButton.Size = new System.Drawing.Size(436, 67);
            this.CreateNewGroupButton.TabIndex = 30;
            this.CreateNewGroupButton.Text = "Create New Group";
            this.CreateNewGroupButton.UseVisualStyleBackColor = false;
            this.CreateNewGroupButton.Click += new System.EventHandler(this.CreateNewGroupButton_Click);
            // 
            // GroupsDataGridView
            // 
            this.GroupsDataGridView.AllowUserToAddRows = false;
            this.GroupsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.GroupsDataGridView.Location = new System.Drawing.Point(3, 57);
            this.GroupsDataGridView.Name = "GroupsDataGridView";
            this.GroupsDataGridView.ReadOnly = true;
            this.GroupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GroupsDataGridView.Size = new System.Drawing.Size(899, 467);
            this.GroupsDataGridView.TabIndex = 1;
            // 
            // GroupViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 658);
            this.Controls.Add(this.StudentsTabView);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GroupViewerForm";
            this.Text = "Group Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            this.StudentsTabView.ResumeLayout(false);
            this.StudentsTab.ResumeLayout(false);
            this.StudentsTab.PerformLayout();
            this.GroupsTab.ResumeLayout(false);
            this.GroupsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDataGridView;
        private System.Windows.Forms.TabControl StudentsTabView;
        private System.Windows.Forms.TabPage StudentsTab;
        private System.Windows.Forms.TabPage GroupsTab;
        private System.Windows.Forms.DataGridView GroupsDataGridView;
        private System.Windows.Forms.Button CreateNewStudentButton;
        private System.Windows.Forms.Label StudentsViewerHeaderLabel;
        private System.Windows.Forms.Button CreateNewGroupButton;
        private System.Windows.Forms.TextBox StudentSearchValue;
        private System.Windows.Forms.Label GroupsViewerLabel;
        private System.Windows.Forms.Button StudentSearchButton;
        private System.Windows.Forms.TextBox GroupSearchValue;
        private System.Windows.Forms.Button GroupSeachButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button BulkAssignButton;
        private System.Windows.Forms.Button StudentSortButton;
        private System.Windows.Forms.Button GroupSortButton;
        private System.Windows.Forms.Button GroupRefreshButton;
    }
}