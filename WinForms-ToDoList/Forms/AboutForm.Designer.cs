
namespace WinForms_ToDoList.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ProfileGitHubButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CopyEmailButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(31, 209);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(143, 57);
            this.materialLabel2.TabIndex = 45;
            this.materialLabel2.Text = "ToDoList App\r\nАвтор: Cyclist-code\r\nВерсия: 1.2.0821";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileGitHubButton
            // 
            this.ProfileGitHubButton.Depth = 0;
            this.ProfileGitHubButton.Location = new System.Drawing.Point(12, 279);
            this.ProfileGitHubButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProfileGitHubButton.Name = "ProfileGitHubButton";
            this.ProfileGitHubButton.Primary = true;
            this.ProfileGitHubButton.Size = new System.Drawing.Size(85, 35);
            this.ProfileGitHubButton.TabIndex = 47;
            this.ProfileGitHubButton.Text = "GitHub";
            this.ProfileGitHubButton.UseVisualStyleBackColor = true;
            this.ProfileGitHubButton.Click += new System.EventHandler(this.ProfileGitHubButton_Click);
            // 
            // CopyEmailButton
            // 
            this.CopyEmailButton.Depth = 0;
            this.CopyEmailButton.Location = new System.Drawing.Point(108, 279);
            this.CopyEmailButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CopyEmailButton.Name = "CopyEmailButton";
            this.CopyEmailButton.Primary = true;
            this.CopyEmailButton.Size = new System.Drawing.Size(85, 35);
            this.CopyEmailButton.TabIndex = 48;
            this.CopyEmailButton.Text = "Email";
            this.CopyEmailButton.UseVisualStyleBackColor = true;
            this.CopyEmailButton.Click += new System.EventHandler(this.CopyEmailButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForms_ToDoList.Properties.Resources.to_do_list;
            this.pictureBox1.Location = new System.Drawing.Point(42, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(205, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CopyEmailButton);
            this.Controls.Add(this.ProfileGitHubButton);
            this.Controls.Add(this.materialLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О приложении";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton ProfileGitHubButton;
        private MaterialSkin.Controls.MaterialRaisedButton CopyEmailButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}