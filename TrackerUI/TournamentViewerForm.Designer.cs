namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.MatchupListbox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Gidole", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.HeaderLabel.Location = new System.Drawing.Point(37, 33);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(184, 38);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Gidole", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.TournamentName.Location = new System.Drawing.Point(227, 33);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(117, 38);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            this.TournamentName.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(40, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Round";
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.ItemHeight = 20;
            this.RoundDropdown.Location = new System.Drawing.Point(112, 103);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(286, 28);
            this.RoundDropdown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckbox
            // 
            this.UnplayedOnlyCheckbox.AutoSize = true;
            this.UnplayedOnlyCheckbox.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.UnplayedOnlyCheckbox.Location = new System.Drawing.Point(112, 155);
            this.UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            this.UnplayedOnlyCheckbox.Size = new System.Drawing.Size(126, 24);
            this.UnplayedOnlyCheckbox.TabIndex = 4;
            this.UnplayedOnlyCheckbox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // MatchupListbox
            // 
            this.MatchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListbox.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchupListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.MatchupListbox.FormattingEnabled = true;
            this.MatchupListbox.ItemHeight = 20;
            this.MatchupListbox.Location = new System.Drawing.Point(44, 215);
            this.MatchupListbox.Name = "MatchupListbox";
            this.MatchupListbox.Size = new System.Drawing.Size(354, 222);
            this.MatchupListbox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.TeamOneName.Location = new System.Drawing.Point(433, 215);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(113, 26);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(433, 256);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(61, 26);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreValue.Location = new System.Drawing.Point(500, 256);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(224, 28);
            this.TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(500, 397);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(224, 28);
            this.TeamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(433, 397);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(61, 26);
            this.TeamTwoScoreLabel.TabIndex = 10;
            this.TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.TeamTwoName.Location = new System.Drawing.Point(433, 356);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(114, 26);
            this.TeamTwoName.TabIndex = 9;
            this.TeamTwoName.Text = "<team two>";
            // 
            // ScoreButton
            // 
            this.ScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.ScoreButton.Location = new System.Drawing.Point(606, 317);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(118, 36);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchupListbox);
            this.Controls.Add(this.UnplayedOnlyCheckbox);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox MatchupListbox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.TextBox TeamTwoScoreValue;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label TeamTwoName;
        private System.Windows.Forms.Button ScoreButton;
    }
}

