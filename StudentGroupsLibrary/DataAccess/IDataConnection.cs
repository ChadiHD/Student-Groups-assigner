using System.Collections.Generic;

namespace StudentGroupsLibrary.DataAccess
{
    public interface IDataConnection
    {
        StudentModel CreateStudent(StudentModel model);
        GroupModel CreateGroup(GroupModel model);
        List<StudentModel> GetStudents_All();
        List<GroupModel> GetGroups_All();
    }
}
