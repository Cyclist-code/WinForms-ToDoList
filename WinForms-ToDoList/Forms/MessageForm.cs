using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WinForms_ToDoList.Forms
{
    public partial class MessageForm : MaterialForm
    {
        private readonly MaterialSkinManager skinManager = null;

        public MessageForm()
        {
            InitializeComponent();

            MainForm.ThemeSelect(skinManager, this);
        }

        #region Закрытие окна сообщения
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
