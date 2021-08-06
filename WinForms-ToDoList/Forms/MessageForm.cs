using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WinForms_ToDoList.Forms
{
    public enum IconMessage
    {
        Error,
        Info,
        Warning
    }

    public partial class MessageForm : MaterialForm
    {      
        public MessageForm(string message, string caption, IconMessage icon)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            MessageLabel.Text = message;
            this.Text = caption;

            switch (icon)
            {
                case IconMessage.Error:
                    PictureBoxIcon.Image = Properties.Resources.error;
                    break;

                case IconMessage.Info:
                    PictureBoxIcon.Image = Properties.Resources.info;
                    break;

                case IconMessage.Warning:
                    PictureBoxIcon.Image = Properties.Resources.warning;
                    break;

            }
        }

        #region Закрытие окна сообщения
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
