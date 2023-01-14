using StudentGroupsLibrary.DataAccess;
using StudentGroupsLibrary.DataAccess.TextCnnHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace StudentGroupsLibrary
{
    public static class GroupingLogic
    {
        public static void AddStudentToGroup(GroupModel group, List<StudentModel> students)
        {
            foreach (StudentModel student in students)
            {
                // Assign the converted string groupID to the specific student
                string GroupID = TextConnectorProcessor.ConvertGroupModelToString(group);
                student.AssignedGroup = GroupID;
            }
            // Modify the csv files with the newly assigned groups
            UpdateStudentsFile(GlobalConfig.StudentsFile, students);
        }

        // TODO - change this method to accept list<students>
        private static void UpdateStudentsFile(string fileName, List<StudentModel> students)
        {
            // create a new list and populate it with strings that represent the updated student data
            List<string> alteredCSV = new List<string>();
            foreach (StudentModel s in students)
            {
                // separated by commas
                alteredCSV.Add(
                    $"{s.Id}," +
                    $"{s.FirstName}," +
                    $"{s.LastName}," +
                    $"{s.EmailAddress}," +
                    $"{s.CellPhoneNumber}," +
                    $"{s.Weighting}," +
                    $"{s.AssignedGroup}");
            }

            // Get all students file
            var fullFile = new List<string>(GlobalConfig.StudentsFile.FullFilePath().LoadFile());
            var RecordsToDelete = new List<string>();
            var Result = new List<string>();

            //Compare the data in the fullFile list with the data in the alteredCSV list
            //and identify any records that need to be updated or deleted
            foreach (string Line in fullFile)
            {
                string[] tValues = Line.Split(',');

                foreach (string field in alteredCSV)
                {
                    string[] fValues = field.Split(',');

                    if (!string.IsNullOrWhiteSpace(field))
                    {
                        if (tValues[0] == fValues[0])
                        {
                            RecordsToDelete.Add(Line.Trim());
                            Result.Add(field);
                        }
                    }
                }
            }
            // Delete records from the fullFile list that have been identified as needing to be deleted
            foreach (string Line in fullFile.ToList())
            {
                string[] tValues = Line.Split(',');
                foreach (string Record in RecordsToDelete)
                {
                    string[] rValues = Record.Split(',');
                    if (!string.IsNullOrWhiteSpace(Record))
                    {
                        int.TryParse(tValues[0], out int StudentId);
                        int.TryParse(rValues[0], out int DeleteId);
                        if (StudentId == DeleteId)
                        {
                            fullFile.Remove(Line);
                            break;
                        }
                    }
                }
            }
            // Add what's remaining to the Result list
            foreach (string Line in fullFile)
            {
                Result.Add(Line);
            }

            // Save all the data in csv file
            File.WriteAllLines(fileName.FullFilePath(), Result);
        }

        public static void BulkAssignStudents(List<StudentModel> students, List<GroupModel> groups)
        {
            //create a new list called sModel that contains only the students list where the AssignedGroup property is equal to "N/A"
            List<StudentModel> sModel = students.Where(s => s.AssignedGroup == "N/A").ToList();
            //count the number of elements in the students list where the AssignedGroup property is equal to "N/A"
            int StudentCount = students.Count(s => s.AssignedGroup == "N/A");
            // Error handling
            if (StudentCount <= 1)
                return;
            // Find the maximum ID
            int groupId = 1;
            if (groups.Count > 0)
            {
                // Add the new record with the new ID (max + 1)
                groupId = groups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            // Create a new group for each set of 2-4 students
            for (int i = 0; i < sModel.Count; i += 4)
            {
                int groupSize = Math.Min(4, sModel.Count - i);
                groupSize = Math.Max(2, groupSize);
                List<StudentModel> groupMembers = sModel.GetRange(i, groupSize);
                GroupModel group = new GroupModel
                {
                    Id = groupId,
                    GroupName = "Group " + groupId.ToString(),
                    GroupMembers = groupMembers,
                    GroupMark = new Random().Next(10, 100).ToString()
                };
                // Increment id for the next group
                groupId++;

                groups.Add(group);
                // Modify the csv files with newly created groups
                AddStudentToGroup(group, groupMembers);
            }
            //Save the Groups in the database
            groups.SaveToGroupFile(GlobalConfig.GroupFile);
        }

        public static List<int> QuickSort(List<int> list)
        {
            if (list.Count <= 1)
                return list;
            int pivotIndex = list.Count / 2;
            int pivot = list[pivotIndex];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (list[i] <= pivot)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<int> sorted = QuickSort(left);
            sorted.Add(pivot);
            sorted.AddRange(QuickSort(right));
            return sorted;
        }
    }
}
