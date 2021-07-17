using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green100, Accent.Green700, TextShade.WHITE);

            PictureBoxGitHub.Image = Properties.Resources.github;
            PictureBoxEmail.Image = Properties.Resources.email;
        }

        #region Переход в профиль на GitHub
        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Cyclist-code");
        }
        #endregion
    }
}
