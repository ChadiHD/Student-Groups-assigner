using StudentGroupsLibrary.DataAccess.TextCnnHelper;
using System.Collections.Generic;
using System.Linq;

namespace StudentGroupsLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // Wire up the CreateStudent for text files
        public StudentModel CreateStudent(StudentModel model)
        {
            // Load the text file and
            // Convert the text to list<StudentModel>
            List<StudentModel> students = GlobalConfig.StudentsFile.FullFilePath().LoadFile().ConvertToStudentModels();
            // Find the maximum ID
            int currentId = 1;
            if (students.Count > 0)
            {
                // Add the new record with the new ID (max + 1)
                currentId = students.OrderByDescending(x => x.Id).First().Id + 1;
            }
            // Convert the Students to list<string>
            model.Id = currentId;
            students.Add(model);
            // Save the list<string> to the text file
            students.SaveToStudentFile(GlobalConfig.StudentsFile);

            return model;
        }

        public GroupModel CreateGroup(GroupModel model)
        {
            List<GroupModel> groups = GlobalConfig.GroupFile.FullFilePath().LoadFile().ConvertToGroupModels();
            List<StudentModel> students = GlobalConfig.StudentsFile.FullFilePath().LoadFile().ConvertToStudentModels();

            int currentId = 1;
            if(groups.Count > 0)
            {
                currentId = groups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            
            groups.Add(model);
            
            groups.SaveToGroupFile(GlobalConfig.GroupFile);

            return model;
        }

        // Load the text file of all stored groups
        public List<GroupModel> GetGroups_All()
        {
            return GlobalConfig.GroupFile.FullFilePath().LoadFile().ConvertToGroupModels();
        }

        // Get the text file of all stored students
        public List<StudentModel> GetStudents_All()
        {
            return GlobalConfig.StudentsFile.FullFilePath().LoadFile().ConvertToStudentModels();
        }
    }
}
