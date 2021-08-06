using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
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

        #region Переменная для отображения окон сообщений
        static MessageForm messageForm;
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
        public static void AddNewData(MaterialLabel DeadLineToDoLabel, MaterialSingleLineTextField ToDoText, MaterialSingleLineTextField DoneText, DataGridView dataGridView)
        {
            connection.Open();

            try
            {
                if (ToDoText.Text == "" || DoneText.Text == "")
                {
                    messageForm = new MessageForm("Вы не ввели данные в необходимые поля.", "Ошибка добавления данных", IconMessage.Error);
                    messageForm.ShowDialog();
                }
                else
                {
                    string insertData = "INSERT INTO ToDoTable (DateCompletion, ToDo, Done) VALUES ('" + DeadLineToDoLabel.Text + "','" + ToDoText.Text + "','" + DoneText.Text + "')";
                    command = new SQLiteCommand(insertData, connection);
                    command.ExecuteNonQuery();

                    DeadLineToDoLabel.Text = DateTime.Now.ToShortDateString();
                    ToDoText.Text = "";
                    DoneText.Text = "Нет";
                    LoadData(dataGridView);

                    messageForm = new MessageForm("Введённые данные успешно сохранены в базу данных.", "Добавления данных", IconMessage.Info);
                    messageForm.ShowDialog();
                }
            }
            catch
            {
                messageForm = new MessageForm("Произошла ошибка при добавлении данных.", "Ошибка добавления данных", IconMessage.Error);
                messageForm.ShowDialog();
            }

            connection.Close();
        }
        #endregion

        #region Редактирование существующих данных
        public static void EditData(DataGridView dataGridView, MaterialLabel DeadLineToDoLabel, MaterialSingleLineTextField ToDoText, MaterialSingleLineTextField DoneText)
        {
            connection.Open();

            try
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    string editData = "UPDATE ToDoTable SET DateCompletion = '" + DeadLineToDoLabel.Text + "', ToDo = '" + ToDoText.Text + "', Done = '" + DoneText.Text +
                        "' WHERE Id = '" + Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value) + "'";
                    command = new SQLiteCommand(editData, connection);
                    command.ExecuteNonQuery();

                    DeadLineToDoLabel.Text = DateTime.Now.ToShortDateString();
                    ToDoText.Text = "";
                    DoneText.Text = "Нет";
                    LoadData(dataGridView);

                    messageForm = new MessageForm("Сохранённые данные успешно отредактированы.", "Редактирование данных", IconMessage.Info);
                    messageForm.ShowDialog();
                }
            }
            catch
            {
                messageForm = new MessageForm("Произошла ошибка при редактировании данных.", "Ошибка редактирования данных", IconMessage.Error);
                messageForm.ShowDialog();
            }

            connection.Close();
        }
        #endregion

        #region Удаление данных
        public static void DeleteData(DataGridView dataGridView, MaterialLabel DeadLineToDoLabel, MaterialSingleLineTextField ToDoText, MaterialSingleLineTextField DoneText)
        {
            connection.Open();

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                string deleteData = "DELETE FROM ToDoTable WHERE Id = '" + Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value) + "'";
                command = new SQLiteCommand(deleteData, connection);
                command.ExecuteNonQuery();

                LoadData(dataGridView);
                DeadLineToDoLabel.Text = DateTime.Now.ToShortDateString();
                ToDoText.Text = "";
                DoneText.Text = "Нет";

                messageForm = new MessageForm("Данные успешно удалены из базы данных.", "Удаление данных", IconMessage.Info);
                messageForm.ShowDialog();
            }

            connection.Close();
        }
        #endregion

        #region Эспорт данных в Excel
        public static void ExportDataExcel(DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application excelFile = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelFile.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            worksheet = workbook.ActiveSheet;

            try
            {
                int k = 1;

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (dataGridView.Columns[j].Visible)
                        {
                            worksheet.Cells[1, k] = dataGridView.Columns[j].HeaderText;
                            worksheet.Cells[1, k].Font.Bold = true;
                            worksheet.Cells[i + 2, k] = dataGridView.Rows[i].Cells[j].Value;
                            k++;
                        }
                    }

                    k = 1;
                }

                worksheet.Columns.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Range ShtRange;
                ShtRange = worksheet.UsedRange;
                ShtRange.Borders.ColorIndex = 1;
                ShtRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                ShtRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            }
            catch
            {
                MessageForm messageForm = new MessageForm("Произошла ошибка при экспорте данных.", "Ошибка экспорта данных", IconMessage.Error);
                messageForm.ShowDialog();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Сохранение в Excel",
                Filter = "Документ Excel (*.xlsx)|*xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    MessageForm messageForm = new MessageForm("Документ Excel сохранён в директории: " + Environment.NewLine + saveFileDialog.FileName + ".xlsx", "Сохранение документа Excel", IconMessage.Info);
                    messageForm.ShowDialog();
                }
                catch
                {
                    MessageForm messageForm = new MessageForm("Произошла ошибка при сохранении файла.", "Ошибка сохранения файла", IconMessage.Error);
                    messageForm.ShowDialog();
                }
            }

            excelFile.Quit();
        }
        #endregion
    }
}
