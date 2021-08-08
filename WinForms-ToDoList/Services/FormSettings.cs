using MaterialSkin;
using MaterialSkin.Controls;

namespace WinForms_ToDoList.Services
{
    public static class FormSettings
    {
        #region Установка дефолтной темы
        public static void InstallingDefaultTheme(MaterialForm materialForm, MaterialCheckBox DarkThemeCheckBox)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(materialForm);
            string theme = Properties.Settings.Default.DarkTheme;

            if ((theme == "") || (theme == " ") || (theme == "0"))
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
            }
            if (theme == "1")
            {
                DarkThemeCheckBox.Checked = true;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
            }
        }
        #endregion

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
