namespace StudentGroupsLibrary.DataAccess
{
    public class StudentModel
    {
        /// <summary>
        /// The unique identifier for the student.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the student
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the student
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The primary email address of the student
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The primary cell phone of the student
        /// </summary>
        public string CellPhoneNumber { get; set; }
        /// <summary>
        /// The weighting percentage of the student mark
        /// </summary>
        public string Weighting { get; set; }
        /// <summary>
        /// The property to track which group the student is a member of
        /// </summary>
        public string AssignedGroup { get; set; }

        /// <summary>
        /// Creates a string that combines firstName and lastName to FullName
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
