using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WinForms_ToDoList.Forms;

namespace WinForms_ToDoList
{
    public partial class MainForm : MaterialForm
    {
        #region Глобальные переменные
        private readonly MaterialSkinManager skinManager = null;
        public static bool themeSelected = false;

        int openForm = 0;
        AboutForm aboutForm;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            ThemeSelect(skinManager, this);

            DeadLineToDoLabel.Text = DateTime.Now.ToShortDateString();
        }

        #region Метод выбора темы офрмления
        public static void ThemeSelect(MaterialSkinManager skinManager, MaterialForm form)
        {
            if (themeSelected == true)
            {
                skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(form);
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                skinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue400, TextShade.WHITE);
            }
            else
            {
                skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(form);
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                skinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green100, Accent.Green700, TextShade.WHITE);
            }
        }
        #endregion

        #region Выбор темы офрмления при установки галочки
        private void DarkThemeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            themeSelected = DarkThemeCheckBox.Checked;
            ThemeSelect(skinManager, this);
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
       
    }
}
