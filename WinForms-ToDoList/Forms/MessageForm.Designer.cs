
namespace WinForms_ToDoList.Forms
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.CloseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MessageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Depth = 0;
            this.CloseButton.Location = new System.Drawing.Point(288, 120);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Primary = true;
            this.CloseButton.Size = new System.Drawing.Size(70, 28);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "ОК";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.Depth = 0;
            this.MessageLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MessageLabel.Location = new System.Drawing.Point(68, 74);
            this.MessageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(301, 40);
            this.MessageLabel.TabIndex = 5;
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Location = new System.Drawing.Point(12, 74);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxIcon.TabIndex = 6;
            this.PictureBoxIcon.TabStop = false;
            // 
            // MessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(370, 160);
            this.Controls.Add(this.PictureBoxIcon);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.CloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton CloseButton;
        private MaterialSkin.Controls.MaterialLabel MessageLabel;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
    }
}