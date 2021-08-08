
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
            this.ExitAppButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CancelExitAppButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Depth = 0;
            this.ExitAppButton.Location = new System.Drawing.Point(192, 120);
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
            this.CancelExitAppButton.Location = new System.Drawing.Point(268, 120);
            this.CancelExitAppButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelExitAppButton.Name = "CancelExitAppButton";
            this.CancelExitAppButton.Primary = true;
            this.CancelExitAppButton.Size = new System.Drawing.Size(70, 28);
            this.CancelExitAppButton.TabIndex = 2;
            this.CancelExitAppButton.Text = "Нет";
            this.CancelExitAppButton.UseVisualStyleBackColor = true;
            this.CancelExitAppButton.Click += new System.EventHandler(this.CancelExitAppButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(68, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(281, 40);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Вы действительно хотите выйти из приложения?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForms_ToDoList.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MessageExitForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 160);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CancelExitAppButton);
            this.Controls.Add(this.ExitAppButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageExitForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выход из приложения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton ExitAppButton;
        private MaterialSkin.Controls.MaterialRaisedButton CancelExitAppButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}