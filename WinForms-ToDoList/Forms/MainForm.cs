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
        }

        #region Переменные
        int openForm = 0;
        AboutForm aboutForm;
        #endregion

        #region Открытие ифнормации о приложении с проверкой
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
    }
}
