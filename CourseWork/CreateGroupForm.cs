using StudentGroupsLibrary;
using StudentGroupsLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class CreateGroupForm : Form, IStudentRequester
    {
        private List<StudentModel> availableStudents = GlobalConfig.Connection.GetStudents_All();
        private List<StudentModel> selectedStudents = new List<StudentModel>();
        private IGroupRequester callingForm;
        public CreateGroupForm(IGroupRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpList();
        }

        private void WireUpList()
        {
            // Force a refresh with null
            SelectGroupMembersDropDown.DataSource = null;
            // Show available students in the dropdown
            SelectGroupMembersDropDown.DataSource = availableStudents;
            // Display Student fullname in the dropdown
            SelectGroupMembersDropDown.DisplayMember = nameof(StudentModel.FullName);

            GroupMembersListBox.DataSource = null;
            // Show the selected students in listbox
            GroupMembersListBox.DataSource = selectedStudents;
            // Display students fullname in listbox
            GroupMembersListBox.DisplayMember = nameof(StudentModel.FullName);
        }

        public void StudentComplete(StudentModel model)
        {
            // Get back from the form a StudentModel
            selectedStudents.Add(model);
            // Take that StudentModel and put it into our List<selectedStudents>
            WireUpList();
        }

        private void AddGroupMemberButton_Click(object sender, EventArgs e)
        {
            // Cast the selected Student in SelectGroupMembersDropDown and store as StudentModel
            StudentModel sModel = (StudentModel)SelectGroupMembersDropDown.SelectedItem;
            // if statement fixes data leaks
            if (sModel != null)
            {
                // remove selected student from the dropdown
                availableStudents.Remove(sModel);
                // Add it to selected students ListBox
                selectedStudents.Add(sModel);

                WireUpList();
            }
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            StudentModel sModel = (StudentModel)GroupMembersListBox.SelectedItem;
            if (sModel != null)
            {
                selectedStudents.Remove(sModel);
                availableStudents.Add(sModel);

                WireUpList();
            }
        }

        private void CreateGroupButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                GroupModel gModel = new GroupModel();
                    gModel.GroupName = GroupNameValue.Text;
                    gModel.GroupMembers = selectedStudents;
                    gModel.GroupMark = GroupMarkValue.Text;

                //Save the Model in the database
                GlobalConfig.Connection.CreateGroup(gModel);

                // Modify the student csv file with the new Assigned group column
                GroupingLogic.AddStudentToGroup(gModel, selectedStudents);

                // Passing the fully completed model back to GroupViewer form
                callingForm.GroupComplete(gModel);
                
                // Close the window
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        // Group validation
        private bool ValidateForm()
        {
            bool output = true;
            
            if (GroupNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (selectedStudents.Count > 4 || selectedStudents.Count < 2)
            {
                MessageBox.Show("A Group can only have minimum of 2 members and maximum of 4 members.",
                    "Invalid Group Members number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            bool markAcceptable = int.TryParse(GroupMarkValue.Text, out int mark);
            if (!markAcceptable)
            {
                MessageBox.Show("You need to enter a valid Group Mark.",
                    "Invalid Group Mark",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }
            if (mark < 10 || mark > 100)
            {
                MessageBox.Show("The Group mark can only have minimum of 10 and maximum of 100.",
                    "Invalid Group Mark",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            foreach (StudentModel student in selectedStudents)
            {
                if (student.AssignedGroup != "N/A")
                {
                    MessageBox.Show($"({student.FullName}) is already a member of a group.",
                        "Invalid Group Member",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    output = false;
                }

                if (!selectedStudents.Contains(student))
                {
                    MessageBox.Show($"({student.FullName}) is not a member of this group.",
                        "Invalid Group Member",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    output = false;
                }

                // Check that the total weighting of all group members is still 100% after the new weighting is set
                int totalWeighting = selectedStudents.Sum(x => int.Parse(x.Weighting));

                if (totalWeighting > 100)
                {
                    MessageBox.Show("The total weighting of all group members must not exceed 100%.",
                        "Invalid Group Weighting percentage",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    output = false;
                }
            }
            return output;
        }
    }
}
