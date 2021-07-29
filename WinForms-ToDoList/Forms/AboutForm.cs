using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace WinForms_ToDoList.Forms
{
    public partial class AboutForm : MaterialForm
    {
        public AboutForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        #region Переход в профиль на GitHub
        private void ProfileGitHubButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Cyclist-code/WinForms-ToDoList");
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
