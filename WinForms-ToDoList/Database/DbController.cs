using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace WinForms_ToDoList.Database
{
    public static class DbController
    {
        #region Переменные для работы с базой данных

        static SQLiteConnection connection = new SQLiteConnection(DbConnection.dbConnection);
        static SQLiteCommand command;
        static DataTable tableToDo;

        #endregion

        #region Загрузка данных из базы
        public static void LoadData(DataGridView dataGridView)
        {
            string loadData = "SELECT * FROM ToDoTable";
            command = new SQLiteCommand(loadData, connection);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
            tableToDo = new DataTable();
            dataAdapter.Fill(tableToDo);

            dataGridView.DataSource = tableToDo;
        }
        #endregion
    }
}
