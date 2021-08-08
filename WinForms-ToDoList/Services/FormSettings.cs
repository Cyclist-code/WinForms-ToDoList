using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_ToDoList.Services
{
    public static class FormSettings
    {
        #region Выбор темы приложения
        public static void ChoosingAppTheme(MaterialCheckBox DarkThemeCheckBox)
        {
            if (DarkThemeCheckBox.Checked)
            {
                //Включение тёмной темы
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                Properties.Settings.Default.DarkTheme = "1";
                Properties.Settings.Default.Save();
            }
            if (!DarkThemeCheckBox.Checked)
            {
                //Включение дефолтной темы
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                Properties.Settings.Default.DarkTheme = "0";
                Properties.Settings.Default.Save();
            }
        }
        #endregion
    }
}
