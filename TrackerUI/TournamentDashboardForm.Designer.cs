namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.LoadExistingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateNewTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Gidole", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.HeaderLabel.Location = new System.Drawing.Point(144, 51);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(329, 38);
            this.HeaderLabel.TabIndex = 13;
            this.HeaderLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentDropdown
            // 
            this.LoadExistingTournamentDropdown.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingTournamentDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.LoadExistingTournamentDropdown.FormattingEnabled = true;
            this.LoadExistingTournamentDropdown.ItemHeight = 20;
            this.LoadExistingTournamentDropdown.Location = new System.Drawing.Point(120, 177);
            this.LoadExistingTournamentDropdown.Name = "LoadExistingTournamentDropdown";
            this.LoadExistingTournamentDropdown.Size = new System.Drawing.Size(376, 28);
            this.LoadExistingTournamentDropdown.TabIndex = 20;
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(189, 139);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(238, 26);
            this.LoadExistingTournamentLabel.TabIndex = 19;
            this.LoadExistingTournamentLabel.Text = "Load Exisitng Tournament";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.LoadTournamentButton.Location = new System.Drawing.Point(120, 233);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(376, 43);
            this.LoadTournamentButton.TabIndex = 26;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateNewTournamentButton
            // 
            this.CreateNewTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateNewTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.CreateNewTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.CreateNewTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewTournamentButton.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.CreateNewTournamentButton.Location = new System.Drawing.Point(120, 296);
            this.CreateNewTournamentButton.Name = "CreateNewTournamentButton";
            this.CreateNewTournamentButton.Size = new System.Drawing.Size(376, 43);
            this.CreateNewTournamentButton.TabIndex = 27;
            this.CreateNewTournamentButton.Text = "Create  New Tournament";
            this.CreateNewTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 437);
            this.Controls.Add(this.CreateNewTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistingTournamentDropdown);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ComboBox LoadExistingTournamentDropdown;
        private System.Windows.Forms.Label LoadExistingTournamentLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateNewTournamentButton;
    }
}