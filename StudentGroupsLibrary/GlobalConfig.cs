using StudentGroupsLibrary.DataAccess;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentGroupsLibrary
{
    /// <summary>
    /// Global connection interface class
    /// uses static specifier because it only views the data globaly
    /// identifies which types of classes to insert in that list
    /// </summary>
    public static class GlobalConfig
    {
        // The name string will never change so its const
        public const string StudentsFile = "StudentModels.csv";
        public const string GroupFile = "GroupModels.csv";
        
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DataType TextFile)
        {
            TextConnector text = new TextConnector();
            Connection = text;
        }
    }
}
