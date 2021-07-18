using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace WinForms_ToDoList.Forms
{
    public partial class AboutForm : MaterialForm
    {
        private readonly MaterialSkinManager skinManager = null;

        public AboutForm()
        {
            InitializeComponent();

            MainForm.ThemeSelect(skinManager, this);
        }

        #region Переход в профиль на GitHub
        private void ProfileGitHubButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Cyclist-code");
        }

        #endregion

        #region Копирование электронной почты
        private void CopyEmailButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cyclistcode@gmail.com");
        }
        #endregion

    }
}
