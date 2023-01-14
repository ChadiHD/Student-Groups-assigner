using StudentGroupsLibrary;
using StudentGroupsLibrary.DataAccess;
using StudentGroupsLibrary.DataAccess.TextCnnHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class GroupViewerForm : Form, IStudentRequester, IGroupRequester
    {
        private string studentFilePath = GlobalConfig.StudentsFile.FullFilePath();
        private string groupFilePath = GlobalConfig.GroupFile.FullFilePath();
        public GroupViewerForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            StudentsDataGridView.Rows.Clear();
            StudentsDataGridView.Columns.Clear();
            StudentsDataGridView.Refresh();
            ReadStudentCSV(studentFilePath, StudentsDataGridView);

            GroupsDataGridView.Rows.Clear();
            GroupsDataGridView.Columns.Clear();
            GroupsDataGridView.Refresh();
            ReadGroupCSV(groupFilePath, GroupsDataGridView);
        }

        public void ReadStudentCSV(string filePath, DataGridView dataGridView)
        {
            // Read the CSV file into a stream
            StreamReader streamReader = new StreamReader(filePath);

            // Set the separator character
            char[] separator = { ',' };

            // Read the first line (column headers)
            string[] headers = {
                "Id",
                "First Name",
                "Last Name",
                "Email Address",
                "Phone Number",
                "Weighting Mark",
                "Assigned Group" };

            // Add the headers to the DataGridView
            foreach (string header in headers)
            {
                dataGridView.Columns.Add(header, header);
            }

            // Read the rest of the lines (data rows)
            while (!streamReader.EndOfStream)
            {
                string[] rows = streamReader.ReadLine().Split(separator);

                dataGridView.Rows.Add(rows);
            }

            // Close the stream
            streamReader.Close();
        }

        public void ReadGroupCSV(string filePath, DataGridView dataGridView)
        {
            StreamReader streamReader = new StreamReader(filePath);

            char[] separator = { ',' };

            string[] headers = {
                "Id",
                "Group Name",
                "Group Members",
                "Group Mark"};

            foreach (string header in headers)
            {
                dataGridView.Columns.Add(header, header);
            }

            while (!streamReader.EndOfStream)
            {
                string[] rows = streamReader.ReadLine().Split(separator);

                dataGridView.Rows.Add(rows);
            }

            streamReader.Close();
        }

        private void CreateNewStudentButton_Click(object sender, EventArgs e)
        {
            // Call the CreatePrizeForm (IStudentRequester interface is needed)
            CreateStudentForm form = new CreateStudentForm(this);
            form.Show();
        }

        private List<StudentModel> selectedStudents = new List<StudentModel>();
        public void StudentComplete(StudentModel model)
        {
            // Get back from the form a StudentModel
            selectedStudents.Add(model);
            // Take that StudentModel and put it into our List<SelectedStudents>
            WireUpLists();
        }

        private void CreateNewGroupButton_Click(object sender, EventArgs e)
        {
            // Call the CreateGroupForm (IGroupRequester interface is needed)
            CreateGroupForm form = new CreateGroupForm(this);
            form.Show();
        }

        private List<GroupModel> selectedGroups = new List<GroupModel>();
        public void GroupComplete(GroupModel model)
        {
            selectedGroups.Add(model);
            WireUpLists();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private void BulkAssignButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure want to bulk assign all students ?",
                                     "Please Confirm!!",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                List<StudentModel> students = GlobalConfig.StudentsFile.FullFilePath().LoadFile().ConvertToStudentModels();
                List<GroupModel> groups = GlobalConfig.GroupFile.FullFilePath().LoadFile().ConvertToGroupModels();

                GroupingLogic.BulkAssignStudents(students, groups);

                WireUpLists();
            }
            else
            {
                return;
            }
        }

        private void StudentSearchButton_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchTerm = StudentSearchValue.Text.ToLower(); // Convert the search term to lowercase

            // Open the CSV file
            string[] lines = File.ReadAllLines(studentFilePath);

            // Search the file for the search term
            var results = from line in lines
                          let columns = line.Split(',')
                          where columns.Any(column => column.ToLower().Contains(searchTerm)) // Convert each column to lowercase before searching
                          select columns;

            // Clear the DataGridView
            StudentsDataGridView.Rows.Clear();

            // Add the results to the DataGridView
            foreach (string[] result in results)
            {
                StudentsDataGridView.Rows.Add(result);
            }
        }
    
        private void StudentSortButton_Click(object sender, EventArgs e)
        {
            // Read the CSV file into a list of strings
            List<StudentModel> students = GlobalConfig.StudentsFile.FullFilePath().LoadFile().ConvertToStudentModels();
            List<int> ids = new List<int>();

            // add the Id property of the StudentModel object to the ids list
            foreach (StudentModel student in students)
            {
                ids.Add(student.Id);
            }
            // Sort all ids using QuickSort
            List<int> sortedIds = GroupingLogic.QuickSort(ids);

            // Initializ an empty list of StudentModel objects.
            List<StudentModel> matchedStudents = new List<StudentModel>();

            foreach (int id in sortedIds)
            {
                //  Find the first StudentModel object in the students list whose
                //  Id property is equal to the current integer.
                StudentModel student = students.FirstOrDefault(s => s.Id == id);
                if (student != null)
                {
                    matchedStudents.Add(student);
                }
            }

            matchedStudents.SaveToStudentFile(GlobalConfig.StudentsFile);

            WireUpLists();
        }

        private void GroupSortButton_Click(object sender, EventArgs e)
        {
            // Read the CSV file into a list of strings
            List<GroupModel> groups = GlobalConfig.GroupFile.FullFilePath().LoadFile().ConvertToGroupModels();
            List<int> ids = new List<int>();

            // Split each line into fields and create a list of Group objects
            foreach (GroupModel group in groups)
            {
                ids.Add(group.Id);
            }

            List<int> sortedIds = GroupingLogic.QuickSort(ids);

            List<GroupModel> matchedGroups = new List<GroupModel>();

            foreach (int id in sortedIds)
            {
                GroupModel group = groups.FirstOrDefault(s => s.Id == id);
                if (group != null)
                {
                    matchedGroups.Add(group);
                }
            }

            matchedGroups.SaveToGroupFile(GlobalConfig.GroupFile);

            WireUpLists();
        }

        private void GroupSeachButton_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchTerm = GroupSearchValue.Text.ToLower(); // Convert the search term to lowercase

            // Open the CSV file
            string[] lines = File.ReadAllLines(groupFilePath);

            // Search the file for the search term
            var results = from line in lines
                          let columns = line.Split(',')
                          where columns.Any(column => column.ToLower().Contains(searchTerm)) // Convert each column to lowercase before searching
                          select columns;

            // Clear the DataGridView
            GroupsDataGridView.Rows.Clear();

            // Add the results to the DataGridView
            foreach (string[] result in results)
            {
                GroupsDataGridView.Rows.Add(result);
            }
        }

        private void GroupRefreshButton_Click(object sender, EventArgs e)
        {
            WireUpLists();
        }
    }
}
