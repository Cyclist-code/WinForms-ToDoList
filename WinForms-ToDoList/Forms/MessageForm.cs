using System;
using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WinForms_ToDoList.Forms
{
    public partial class MessageForm : MaterialForm
    {
        public MessageForm(string message, string caption, Image image)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

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
