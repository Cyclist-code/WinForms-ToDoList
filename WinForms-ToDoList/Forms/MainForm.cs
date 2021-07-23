using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using WinForms_ToDoList.Forms;
using WinForms_ToDoList.Database;

namespace WinForms_ToDoList
{
    public partial class MainForm : MaterialForm
    {
        #region Глобальные переменные
        string theme;
        int openForm = 0;
        AboutForm aboutForm;

        SQLiteConnection connection = new SQLiteConnection(DbConnection.dbConnection);
        #endregion

        public MainForm()
        {
            InitializeComponent();

            #region Дефолтная тема
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            theme = Properties.Settings.Default.DarkTheme;
            if ((theme == "") || (theme == " ") || (theme == "0"))
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green100, Accent.Green700, TextShade.WHITE);
            }
            if (theme == "1")
            {
                DarkThemeCheckBox.Checked = true;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue400, TextShade.WHITE);
            }
            #endregion

            DeadLineToDoLabel.Text = DateTime.Now.ToShortDateString();
            DoneText.Text = "Нет";
        }       

        #region Выбор темы офрмления при установки галочки
        private void DarkThemeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkThemeCheckBox.Checked)
            {
                //Включение тёмной темы
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue400, TextShade.WHITE);
                Properties.Settings.Default.DarkTheme = "1";
                Properties.Settings.Default.Save();
            }
            if (!DarkThemeCheckBox.Checked)
            {
                //Включение дефолтной темы
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green100, Accent.Green700, TextShade.WHITE);
                Properties.Settings.Default.DarkTheme = "0";
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        #region Открытие окна с ифнормации о приложении с дополнительной проверкой
        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "AboutForm")
                    openForm = 1;
                else
                    openForm = 0;
            }
            if (openForm == 0)
            {
                aboutForm = new AboutForm();
                aboutForm.Show();
            }
        }
        #endregion

        #region Подтверждение закрытия приложения
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageExitForm exitForm = new MessageExitForm();
            exitForm.ShowDialog();

            if (exitForm.DialogResult == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        #endregion

        #region Выбор даты выполнения
        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DeadLineToDoLabel.Text = "";
            DeadLineToDoLabel.Text = e.Start.ToShortDateString();
        }
        #endregion

        #region Загрузка данных
        private void MainForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            DbController.LoadData(ToDoDataGridView);
            connection.Close();
        }
        #endregion

        #region Обработчики событий

        #region Добавление новой строки
        private void NewRowButton_Click(object sender, EventArgs e)
        {
            DbController.AddNewRow();
        }
        #endregion

        #region Добавление новых данных в базу
        private void AddDataButton_Click(object sender, EventArgs e)
        {
            DbController.AddNewData(DeadLineToDoLabel, ToDoText, DoneText, ToDoDataGridView);
        }
        #endregion

        #region Эспорт данных
        private void ExportDataButton_Click(object sender, EventArgs e)
        {
            DbController.ExportDataExcel(ToDoDataGridView);
        }

        #endregion

        #endregion

        #region Вывод сохранённых данных в поля
        private void ToDoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ToDoDataGridView.SelectedRows)
            {
                DeadLineToDoLabel.Text = ToDoDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                ToDoText.Text = ToDoDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                DoneText.Text = ToDoDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        #endregion

    }
}
