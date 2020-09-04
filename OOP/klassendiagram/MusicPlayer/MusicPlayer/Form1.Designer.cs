namespace MusicPlayer
{
    partial class Form1
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
            this.playBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.playListBox = new System.Windows.Forms.ListBox();
            this.currentLbl = new System.Windows.Forms.Label();
            this.songLbl = new System.Windows.Forms.Label();
            this.songListBox = new System.Windows.Forms.ListBox();
            this.addSongBtn = new System.Windows.Forms.Button();
            this.addPlaylistBtn = new System.Windows.Forms.Button();
            this.removePlaylistBtn = new System.Windows.Forms.Button();
            this.removeSongBtn = new System.Windows.Forms.Button();
            this.playlistLbl = new System.Windows.Forms.Label();
            this.songListLbl = new System.Windows.Forms.Label();
            this.artistListBox = new System.Windows.Forms.ListBox();
            this.artistLbl = new System.Windows.Forms.Label();
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(271, 373);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(140, 53);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(428, 373);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(140, 53);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // playListBox
            // 
            this.playListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.playListBox.FormattingEnabled = true;
            this.playListBox.ItemHeight = 12;
            this.playListBox.Location = new System.Drawing.Point(574, 32);
            this.playListBox.Name = "playListBox";
            this.playListBox.Size = new System.Drawing.Size(214, 208);
            this.playListBox.TabIndex = 2;
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLbl.Location = new System.Drawing.Point(356, 32);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(108, 20);
            this.currentLbl.TabIndex = 3;
            this.currentLbl.Text = "Current Song:";
            // 
            // songLbl
            // 
            this.songLbl.AutoSize = true;
            this.songLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLbl.Location = new System.Drawing.Point(292, 67);
            this.songLbl.Name = "songLbl";
            this.songLbl.Size = new System.Drawing.Size(119, 20);
            this.songLbl.TabIndex = 4;
            this.songLbl.Text = "no song playing";
            // 
            // songListBox
            // 
            this.songListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songListBox.FormattingEnabled = true;
            this.songListBox.ItemHeight = 12;
            this.songListBox.Location = new System.Drawing.Point(12, 32);
            this.songListBox.Name = "songListBox";
            this.songListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.songListBox.Size = new System.Drawing.Size(253, 400);
            this.songListBox.TabIndex = 5;
            // 
            // addSongBtn
            // 
            this.addSongBtn.Location = new System.Drawing.Point(271, 199);
            this.addSongBtn.Name = "addSongBtn";
            this.addSongBtn.Size = new System.Drawing.Size(140, 53);
            this.addSongBtn.TabIndex = 6;
            this.addSongBtn.Text = "addSong";
            this.addSongBtn.UseVisualStyleBackColor = true;
            this.addSongBtn.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // addPlaylistBtn
            // 
            this.addPlaylistBtn.Location = new System.Drawing.Point(428, 199);
            this.addPlaylistBtn.Name = "addPlaylistBtn";
            this.addPlaylistBtn.Size = new System.Drawing.Size(140, 53);
            this.addPlaylistBtn.TabIndex = 7;
            this.addPlaylistBtn.Text = "addPlaylist";
            this.addPlaylistBtn.UseVisualStyleBackColor = true;
            this.addPlaylistBtn.Click += new System.EventHandler(this.addPlaylistBtn_Click);
            // 
            // removePlaylistBtn
            // 
            this.removePlaylistBtn.Location = new System.Drawing.Point(428, 258);
            this.removePlaylistBtn.Name = "removePlaylistBtn";
            this.removePlaylistBtn.Size = new System.Drawing.Size(140, 53);
            this.removePlaylistBtn.TabIndex = 8;
            this.removePlaylistBtn.Text = "removePlaylist";
            this.removePlaylistBtn.UseVisualStyleBackColor = true;
            this.removePlaylistBtn.Click += new System.EventHandler(this.removePlaylistBtn_Click);
            // 
            // removeSongBtn
            // 
            this.removeSongBtn.Location = new System.Drawing.Point(271, 258);
            this.removeSongBtn.Name = "removeSongBtn";
            this.removeSongBtn.Size = new System.Drawing.Size(140, 53);
            this.removeSongBtn.TabIndex = 9;
            this.removeSongBtn.Text = "removeSong";
            this.removeSongBtn.UseVisualStyleBackColor = true;
            this.removeSongBtn.Click += new System.EventHandler(this.removeSongBtn_Click);
            // 
            // playlistLbl
            // 
            this.playlistLbl.AutoSize = true;
            this.playlistLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.playlistLbl.Location = new System.Drawing.Point(656, 12);
            this.playlistLbl.Name = "playlistLbl";
            this.playlistLbl.Size = new System.Drawing.Size(52, 17);
            this.playlistLbl.TabIndex = 10;
            this.playlistLbl.Text = "Playlist";
            // 
            // songListLbl
            // 
            this.songListLbl.AutoSize = true;
            this.songListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.songListLbl.Location = new System.Drawing.Point(103, 12);
            this.songListLbl.Name = "songListLbl";
            this.songListLbl.Size = new System.Drawing.Size(48, 17);
            this.songListLbl.TabIndex = 11;
            this.songListLbl.Text = "Songs";
            // 
            // artistListBox
            // 
            this.artistListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.artistListBox.FormattingEnabled = true;
            this.artistListBox.ItemHeight = 12;
            this.artistListBox.Location = new System.Drawing.Point(574, 294);
            this.artistListBox.Name = "artistListBox";
            this.artistListBox.Size = new System.Drawing.Size(214, 160);
            this.artistListBox.TabIndex = 12;
            // 
            // artistLbl
            // 
            this.artistLbl.AutoSize = true;
            this.artistLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.artistLbl.Location = new System.Drawing.Point(656, 276);
            this.artistLbl.Name = "artistLbl";
            this.artistLbl.Size = new System.Drawing.Size(47, 17);
            this.artistLbl.TabIndex = 13;
            this.artistLbl.Text = "Artists";
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.Location = new System.Drawing.Point(360, 314);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(140, 53);
            this.shuffleBtn.TabIndex = 14;
            this.shuffleBtn.Text = "Shuffle";
            this.shuffleBtn.UseVisualStyleBackColor = true;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shuffleBtn);
            this.Controls.Add(this.artistLbl);
            this.Controls.Add(this.artistListBox);
            this.Controls.Add(this.songListLbl);
            this.Controls.Add(this.playlistLbl);
            this.Controls.Add(this.removeSongBtn);
            this.Controls.Add(this.removePlaylistBtn);
            this.Controls.Add(this.addPlaylistBtn);
            this.Controls.Add(this.addSongBtn);
            this.Controls.Add(this.songListBox);
            this.Controls.Add(this.songLbl);
            this.Controls.Add(this.currentLbl);
            this.Controls.Add(this.playListBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.ListBox playListBox;
        private System.Windows.Forms.Label currentLbl;
        private System.Windows.Forms.Label songLbl;
        private System.Windows.Forms.ListBox songListBox;
        private System.Windows.Forms.Button addSongBtn;
        private System.Windows.Forms.Button addPlaylistBtn;
        private System.Windows.Forms.Button removePlaylistBtn;
        private System.Windows.Forms.Button removeSongBtn;
        private System.Windows.Forms.Label playlistLbl;
        private System.Windows.Forms.Label songListLbl;
        private System.Windows.Forms.ListBox artistListBox;
        private System.Windows.Forms.Label artistLbl;
        private System.Windows.Forms.Button shuffleBtn;
    }
}

