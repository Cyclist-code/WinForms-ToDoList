
namespace WinForms_ToDoList
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AboutProgramButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExportDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ToDoText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.AddDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ToDoDGV = new System.Windows.Forms.DataGridView();
            this.DateCompletionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DeadLineToDoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DarkThemeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.Depth = 0;
            this.AboutProgramButton.Location = new System.Drawing.Point(559, 358);
            this.AboutProgramButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Primary = true;
            this.AboutProgramButton.Size = new System.Drawing.Size(130, 35);
            this.AboutProgramButton.TabIndex = 0;
            this.AboutProgramButton.Text = "О приложении";
            this.AboutProgramButton.UseVisualStyleBackColor = true;
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            // 
            // ExportDataButton
            // 
            this.ExportDataButton.Depth = 0;
            this.ExportDataButton.Location = new System.Drawing.Point(413, 358);
            this.ExportDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportDataButton.Name = "ExportDataButton";
            this.ExportDataButton.Primary = true;
            this.ExportDataButton.Size = new System.Drawing.Size(140, 35);
            this.ExportDataButton.TabIndex = 1;
            this.ExportDataButton.Text = "Экспортировать";
            this.ExportDataButton.UseVisualStyleBackColor = true;
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Depth = 0;
            this.DeleteDataButton.Location = new System.Drawing.Point(297, 358);
            this.DeleteDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Primary = true;
            this.DeleteDataButton.Size = new System.Drawing.Size(110, 35);
            this.DeleteDataButton.TabIndex = 2;
            this.DeleteDataButton.Text = "Удалить";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            // 
            // ToDoText
            // 
            this.ToDoText.Depth = 0;
            this.ToDoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDoText.Hint = "";
            this.ToDoText.Location = new System.Drawing.Point(12, 102);
            this.ToDoText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ToDoText.Name = "ToDoText";
            this.ToDoText.PasswordChar = '\0';
            this.ToDoText.SelectedText = "";
            this.ToDoText.SelectionLength = 0;
            this.ToDoText.SelectionStart = 0;
            this.ToDoText.Size = new System.Drawing.Size(160, 23);
            this.ToDoText.TabIndex = 3;
            this.ToDoText.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(164, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Необходимо сделать:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 138);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Дата выполнения:";
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(8, 187);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 6;
            this.MonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
            // 
            // AddDataButton
            // 
            this.AddDataButton.Depth = 0;
            this.AddDataButton.Location = new System.Drawing.Point(184, 358);
            this.AddDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Primary = true;
            this.AddDataButton.Size = new System.Drawing.Size(107, 35);
            this.AddDataButton.TabIndex = 7;
            this.AddDataButton.Text = "Добавить";
            this.AddDataButton.UseVisualStyleBackColor = true;
            // 
            // ToDoDGV
            // 
            this.ToDoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCompletionColumn,
            this.ToDoColumn,
            this.StatusColumn});
            this.ToDoDGV.Location = new System.Drawing.Point(184, 79);
            this.ToDoDGV.Name = "ToDoDGV";
            this.ToDoDGV.Size = new System.Drawing.Size(505, 270);
            this.ToDoDGV.TabIndex = 8;
            // 
            // DateCompletionColumn
            // 
            this.DateCompletionColumn.HeaderText = "Дата выполнения";
            this.DateCompletionColumn.Name = "DateCompletionColumn";
            this.DateCompletionColumn.Width = 140;
            // 
            // ToDoColumn
            // 
            this.ToDoColumn.HeaderText = "Сделать";
            this.ToDoColumn.Name = "ToDoColumn";
            this.ToDoColumn.Width = 222;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // DeadLineToDoLabel
            // 
            this.DeadLineToDoLabel.AutoSize = true;
            this.DeadLineToDoLabel.Depth = 0;
            this.DeadLineToDoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.DeadLineToDoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeadLineToDoLabel.Location = new System.Drawing.Point(8, 162);
            this.DeadLineToDoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeadLineToDoLabel.Name = "DeadLineToDoLabel";
            this.DeadLineToDoLabel.Size = new System.Drawing.Size(0, 19);
            this.DeadLineToDoLabel.TabIndex = 9;
            // 
            // DarkThemeCheckBox
            // 
            this.DarkThemeCheckBox.Depth = 0;
            this.DarkThemeCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.DarkThemeCheckBox.Location = new System.Drawing.Point(8, 361);
            this.DarkThemeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.DarkThemeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DarkThemeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkThemeCheckBox.Name = "DarkThemeCheckBox";
            this.DarkThemeCheckBox.Ripple = true;
            this.DarkThemeCheckBox.Size = new System.Drawing.Size(140, 30);
            this.DarkThemeCheckBox.TabIndex = 10;
            this.DarkThemeCheckBox.Text = "Тёмная тема";
            this.DarkThemeCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(701, 405);
            this.Controls.Add(this.DarkThemeCheckBox);
            this.Controls.Add(this.DeadLineToDoLabel);
            this.Controls.Add(this.ToDoDGV);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.MonthCalendar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ToDoText);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.ExportDataButton);
            this.Controls.Add(this.AboutProgramButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton AboutProgramButton;
        private MaterialSkin.Controls.MaterialRaisedButton ExportDataButton;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteDataButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField ToDoText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private MaterialSkin.Controls.MaterialRaisedButton AddDataButton;
        private System.Windows.Forms.DataGridView ToDoDGV;
        private MaterialSkin.Controls.MaterialLabel DeadLineToDoLabel;
        private MaterialSkin.Controls.MaterialCheckBox DarkThemeCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCompletionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDoColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StatusColumn;
    }
}

