using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WinForms_ToDoList.Forms;

namespace WinForms_ToDoList
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green100, Accent.Green700, TextShade.WHITE);

            DeadLineToDoLabel.Text = DateTime.Now.ToShortDateString();
        }

        #region Переменные
        int openForm = 0;
        AboutForm aboutForm;
        #endregion

        #region Открытие окна с ифнормации о приложении с дополнительной проверкой
        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
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
    }
}
