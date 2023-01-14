using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;

namespace StudentGroupsLibrary.DataAccess.TextCnnHelper
{
    public static class TextConnectorProcessor
    {
        // Must be static
        public static string FullFilePath(this string fileName) // exp: StudentsModel.csv
        {
            // Define the path in App.Config
            // C:\filePath....\StudentModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            // Load the text file
            if( !File.Exists(file) )
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        // Convert the text in to a list of StudentModel
        public static List<StudentModel> ConvertToStudentModels(this List<string> lines)
        {
            List<StudentModel> output = new List<StudentModel>();
            
            foreach(string line in lines)
            {
                // Split the value with comma
                string[] colums = line.Split(',');

                StudentModel s = new StudentModel();
                //Order sensitive
                s.Id = int.Parse(colums[0]);
                s.FirstName = colums[1];
                s.LastName = colums[2];
                s.EmailAddress = colums[3];
                s.CellPhoneNumber = colums[4];
                s.Weighting = colums[5];
                if (colums[6].Length == 0)
                {
                    s.AssignedGroup = string.Empty;
                }
                else
                {
                    s.AssignedGroup = colums[6];
                }
                output.Add(s);
            }
            // output: 10001,Chadi,Hammoud,c.Hammoud@gmail.com,072238,30,AA Group
            return output;
        }

        // Convert the StudentModels into a list<string>
        public static void SaveToStudentFile(this List<StudentModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (StudentModel s in models)
            {
                // Order sensitive
                lines.Add($"{s.Id}," +
                    $"{s.FirstName}," +
                    $"{s.LastName}," +
                    $"{s.EmailAddress}," +
                    $"{s.CellPhoneNumber}," +
                    $"{s.Weighting}," +
                    $"{s.AssignedGroup}");
            }
            // Save the list<string> to the text file
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<GroupModel> ConvertToGroupModels(this List<string> lines)
        {
            // id,Group Name,GroupMark,list of Ids speretaed by the pipe ('|')
            // 3,Chadi's Group,1|2|3,80
            List<GroupModel> output = new List<GroupModel>();
            List<StudentModel> students = GlobalConfig.StudentsFile.FullFilePath().LoadFile().ConvertToStudentModels();
            
            foreach (string line in lines)
            {
                string[] colums = line.Split(',');

                GroupModel g = new GroupModel();
                g.Id= int.Parse(colums[0]);
                g.GroupName= colums[1];
                string[] studentIds = colums[2].Split('|');
                
                foreach (string id in studentIds)
                {
                    // take the list of students in our text file, then search for it and filter where
                    // the id of the student in the list == the id from foreach loop
                    g.GroupMembers.Add(students.Where(x => x.Id == int.Parse(id)).First());
                }
                g.GroupMark = colums[3];

                output.Add(g);
            }
            return output;
        }

        public static void SaveToGroupFile(this List<GroupModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (GroupModel g in models)
            {
                lines.Add($"{g.Id}," +
                    $"{g.GroupName}," +
                    $"{ConvertStudentListToString(g.GroupMembers)}," +
                    $"{g.GroupMark}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static object ConvertStudentListToString(List<StudentModel> groupMembers)
        {
            string output = string.Empty;

            // Handle a bug incase no string is available
            if (groupMembers.Count == 0)
            {
                return string.Empty;
            }

            // Add all groupMembers fullname with ('|')
            foreach (StudentModel student in groupMembers)
            {
                output += $"{student.Id}|";
            }

            // Substring to remove the last ('|') character
            // it will look like this :  2|4
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static string ConvertGroupModelToString(GroupModel groupModel)
        {
            string output = string.Empty;
            if (groupModel == null)
            {
                return string.Empty;
            }

            output += $"{groupModel.Id}";

            return output;
        }
    }
}
