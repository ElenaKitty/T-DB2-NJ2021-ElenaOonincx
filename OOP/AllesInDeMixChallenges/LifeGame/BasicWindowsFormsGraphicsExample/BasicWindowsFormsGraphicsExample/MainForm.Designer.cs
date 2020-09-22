namespace BasicWindowsFormsGraphicsExample
{
    partial class MainForm
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
            this.gamePictureBox = new System.Windows.Forms.PictureBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.faceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePictureBox
            // 
            this.gamePictureBox.BackColor = System.Drawing.Color.OliveDrab;
            this.gamePictureBox.Location = new System.Drawing.Point(12, 12);
            this.gamePictureBox.Name = "gamePictureBox";
            this.gamePictureBox.Size = new System.Drawing.Size(599, 426);
            this.gamePictureBox.TabIndex = 0;
            this.gamePictureBox.TabStop = false;
            this.gamePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePictureBox_Paint);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(632, 12);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(156, 95);
            this.moveButton.TabIndex = 1;
            this.moveButton.Text = "And... Action!";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // faceButton
            // 
            this.faceButton.Location = new System.Drawing.Point(632, 128);
            this.faceButton.Name = "faceButton";
            this.faceButton.Size = new System.Drawing.Size(156, 77);
            this.faceButton.TabIndex = 2;
            this.faceButton.Text = "show/hide face";
            this.faceButton.UseVisualStyleBackColor = true;
            this.faceButton.Click += new System.EventHandler(this.faceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.faceButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.gamePictureBox);
            this.Name = "MainForm";
            this.Text = "Put a nice name over here";
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gamePictureBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button faceButton;
    }
}

