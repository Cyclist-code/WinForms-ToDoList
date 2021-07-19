using System;
using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WinForms_ToDoList.Forms
{
    public partial class MessageForm : MaterialForm
    {
        private readonly MaterialSkinManager skinManager = null;

        public MessageForm(string message, string caption, Image image)
        {
            InitializeComponent();

            MainForm.ThemeSelect(skinManager, this);

            MessageLabel.Text = message;
            this.Text = caption;
            PictureBoxIcon.Image = image;
        }

        #region Закрытие окна сообщения
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
