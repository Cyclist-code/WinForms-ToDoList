using System.IO;

namespace WinForms_ToDoList.Database
{
    class DbConnection
    {
        public static string dbConnection = "Data Source=" + Path.GetFullPath("Database/ToDoList.db") + ";Version=3";
    }
}
