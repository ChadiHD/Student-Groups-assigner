using System.Collections.Generic;

namespace StudentGroupsLibrary.DataAccess
{
    public class GroupModel
    {
        /// <summary>
        /// Unique Identifier for the Group
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name reperesenting the specific Group
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// List of the students that were assigned to the specific group
        /// </summary>
        public List<StudentModel> GroupMembers { get; set; } = new List<StudentModel>();
        /// <summary>
        /// Group Mark for the selected students
        /// </summary>
        public string GroupMark { get; set; }
    }
}
