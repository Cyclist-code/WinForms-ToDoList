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
        private readonly MaterialSkinManager skinManager = null;

        public AboutForm()
        {
            InitializeComponent();

            MainForm.ThemeSelect(skinManager, this);

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
