using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WinForms_ToDoList.Forms;

namespace WinForms_ToDoList.Database
{
    public static class DbController
    {
        #region Переменные для работы с базой данных
        static SQLiteConnection connection = new SQLiteConnection(DbConnection.dbConnection);
        static SQLiteCommand command;
        static DataTable tableToDo;
        #endregion

        #region Переменные для отображения окон сообщений
        static MessageForm messageForm;
        static Image imageIconError = Properties.Resources.error;
        static Image imageIconInfo = Properties.Resources.info;
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

        #region Добавление новых данных
        public static void AddNewData(MaterialSingleLineTextField textField, MaterialLabel label, DataGridView dataGridView)
        {
            try
            {
                connection.Open();

                if (textField.Text == "")
                {
                    messageForm = new MessageForm("Вы не ввели в поле то, что необходимо сделать.", "Ошибка добавления данных", imageIconError);
                    messageForm.ShowDialog();
                }
                else
                {
                    string insertData = "INSERT INTO ToDoList (DateCompletion, ToDo, Done) VALUES ('" + textField.Text + "','" + label.Text + "','Нет')";
                    command = new SQLiteCommand(insertData, connection);
                    command.ExecuteNonQuery();

                    textField.Text = "";
                    LoadData(dataGridView);

                    messageForm = new MessageForm("Данные успешно сохранены.", "Добавления данных", imageIconInfo);
                    messageForm.ShowDialog();
                }

                connection.Close();
            }
            catch
            {
                messageForm = new MessageForm("Произошла ошибки при добавлении данных.", "Ошибка добавления данных", imageIconError);
                messageForm.ShowDialog();
            }
        }
        #endregion
    }
}
