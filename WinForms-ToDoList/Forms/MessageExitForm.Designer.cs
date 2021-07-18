
namespace WinForms_ToDoList.Forms
{
    partial class MessageExitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageExitForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ExitAppButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CancelExitAppButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите выйти из приложения?";
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Depth = 0;
            this.ExitAppButton.Location = new System.Drawing.Point(212, 120);
            this.ExitAppButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Primary = true;
            this.ExitAppButton.Size = new System.Drawing.Size(70, 28);
            this.ExitAppButton.TabIndex = 1;
            this.ExitAppButton.Text = "Да";
            this.ExitAppButton.UseVisualStyleBackColor = true;
            this.ExitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // CancelExitAppButton
            // 
            this.CancelExitAppButton.Depth = 0;
            this.CancelExitAppButton.Location = new System.Drawing.Point(288, 120);
            this.CancelExitAppButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelExitAppButton.Name = "CancelExitAppButton";
            this.CancelExitAppButton.Primary = true;
            this.CancelExitAppButton.Size = new System.Drawing.Size(70, 28);
            this.CancelExitAppButton.TabIndex = 2;
            this.CancelExitAppButton.Text = "Нет";
            this.CancelExitAppButton.UseVisualStyleBackColor = true;
            this.CancelExitAppButton.Click += new System.EventHandler(this.CancelExitAppButton_Click);
            // 
            // MessageExitForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(370, 160);
            this.Controls.Add(this.CancelExitAppButton);
            this.Controls.Add(this.ExitAppButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageExitForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выход из приложения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton ExitAppButton;
        private MaterialSkin.Controls.MaterialRaisedButton CancelExitAppButton;
    }
}