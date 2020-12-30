namespace TrackerUI
{
    partial class TournamentViewer
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyChkBx = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.Team1scoreLabel = new System.Windows.Forms.Label();
            this.Team1scoreValue = new System.Windows.Forms.TextBox();
            this.Team2scoretxt = new System.Windows.Forms.TextBox();
            this.Team2scoreLabel = new System.Windows.Forms.Label();
            this.Team2Name = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(214, 50);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // TournamentLabel
            // 
            this.TournamentLabel.AutoSize = true;
            this.TournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentLabel.Location = new System.Drawing.Point(232, 9);
            this.TournamentLabel.Name = "TournamentLabel";
            this.TournamentLabel.Size = new System.Drawing.Size(150, 50);
            this.TournamentLabel.TabIndex = 1;
            this.TournamentLabel.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.RoundLabel.Location = new System.Drawing.Point(16, 81);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(94, 37);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.Location = new System.Drawing.Point(117, 81);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(265, 38);
            this.RoundDropdown.TabIndex = 3;
            // 
            // UnplayedOnlyChkBx
            // 
            this.UnplayedOnlyChkBx.AutoSize = true;
            this.UnplayedOnlyChkBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyChkBx.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyChkBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UnplayedOnlyChkBx.Location = new System.Drawing.Point(117, 148);
            this.UnplayedOnlyChkBx.Name = "UnplayedOnlyChkBx";
            this.UnplayedOnlyChkBx.Size = new System.Drawing.Size(209, 41);
            this.UnplayedOnlyChkBx.TabIndex = 4;
            this.UnplayedOnlyChkBx.Text = "Unplayed Only";
            this.UnplayedOnlyChkBx.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 30;
            this.MatchupListBox.Location = new System.Drawing.Point(23, 200);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(359, 332);
            this.MatchupListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.TeamOneName.Location = new System.Drawing.Point(457, 200);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(171, 37);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<Team One>";
            // 
            // Team1scoreLabel
            // 
            this.Team1scoreLabel.AutoSize = true;
            this.Team1scoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.Team1scoreLabel.Location = new System.Drawing.Point(457, 246);
            this.Team1scoreLabel.Name = "Team1scoreLabel";
            this.Team1scoreLabel.Size = new System.Drawing.Size(82, 37);
            this.Team1scoreLabel.TabIndex = 7;
            this.Team1scoreLabel.Text = "Score";
            // 
            // Team1scoreValue
            // 
            this.Team1scoreValue.Location = new System.Drawing.Point(545, 249);
            this.Team1scoreValue.Name = "Team1scoreValue";
            this.Team1scoreValue.Size = new System.Drawing.Size(100, 35);
            this.Team1scoreValue.TabIndex = 8;
            // 
            // Team2scoretxt
            // 
            this.Team2scoretxt.Location = new System.Drawing.Point(545, 433);
            this.Team2scoretxt.Name = "Team2scoretxt";
            this.Team2scoretxt.Size = new System.Drawing.Size(100, 35);
            this.Team2scoretxt.TabIndex = 11;
            // 
            // Team2scoreLabel
            // 
            this.Team2scoreLabel.AutoSize = true;
            this.Team2scoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.Team2scoreLabel.Location = new System.Drawing.Point(457, 430);
            this.Team2scoreLabel.Name = "Team2scoreLabel";
            this.Team2scoreLabel.Size = new System.Drawing.Size(82, 37);
            this.Team2scoreLabel.TabIndex = 10;
            this.Team2scoreLabel.Text = "Score";
            // 
            // Team2Name
            // 
            this.Team2Name.AutoSize = true;
            this.Team2Name.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.Team2Name.Location = new System.Drawing.Point(457, 384);
            this.Team2Name.Name = "Team2Name";
            this.Team2Name.Size = new System.Drawing.Size(167, 37);
            this.Team2Name.TabIndex = 9;
            this.Team2Name.Text = "<Team two>";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.VersusLabel.Location = new System.Drawing.Point(538, 317);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(70, 37);
            this.VersusLabel.TabIndex = 12;
            this.VersusLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ScoreButton.Location = new System.Drawing.Point(653, 308);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(117, 60);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 572);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.Team2scoretxt);
            this.Controls.Add(this.Team2scoreLabel);
            this.Controls.Add(this.Team2Name);
            this.Controls.Add(this.Team1scoreValue);
            this.Controls.Add(this.Team1scoreLabel);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.UnplayedOnlyChkBx);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.CheckBox UnplayedOnlyChkBx;
        private System.Windows.Forms.ListBox MatchupListBox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label Team1scoreLabel;
        private System.Windows.Forms.TextBox Team1scoreValue;
        private System.Windows.Forms.TextBox Team2scoretxt;
        private System.Windows.Forms.Label Team2scoreLabel;
        private System.Windows.Forms.Label Team2Name;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

