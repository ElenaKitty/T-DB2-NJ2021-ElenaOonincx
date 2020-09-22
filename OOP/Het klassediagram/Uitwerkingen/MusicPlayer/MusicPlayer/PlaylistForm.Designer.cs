namespace MusicPlayer
{
    partial class PlaylistForm
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
            this.playlistNameBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.playlistLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playlistNameBox
            // 
            this.playlistNameBox.Location = new System.Drawing.Point(113, 22);
            this.playlistNameBox.Name = "playlistNameBox";
            this.playlistNameBox.Size = new System.Drawing.Size(110, 20);
            this.playlistNameBox.TabIndex = 0;
            // 
            // submitBtn
            // 
            this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitBtn.Location = new System.Drawing.Point(72, 64);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(110, 23);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Create playlist";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // playlistLbl
            // 
            this.playlistLbl.AutoSize = true;
            this.playlistLbl.Location = new System.Drawing.Point(33, 25);
            this.playlistLbl.Name = "playlistLbl";
            this.playlistLbl.Size = new System.Drawing.Size(74, 13);
            this.playlistLbl.TabIndex = 2;
            this.playlistLbl.Text = "Playlist name: ";
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 114);
            this.Controls.Add(this.playlistLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.playlistNameBox);
            this.Name = "PlaylistForm";
            this.Text = "playlistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playlistNameBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label playlistLbl;
    }
}