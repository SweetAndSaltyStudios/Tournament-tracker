namespace TrackerUI
{
    partial class CreateTournamentForm
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameValueTextBox = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewlinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePriceButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayersLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.DeleteSelectedPriceButton = new System.Windows.Forms.Button();
            this.PricesLabel = new System.Windows.Forms.Label();
            this.PricesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(235, 30);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "CREATE TOURNAMENT:";
            // 
            // TournamentNameValueTextBox
            // 
            this.TournamentNameValueTextBox.Location = new System.Drawing.Point(17, 89);
            this.TournamentNameValueTextBox.Name = "TournamentNameValueTextBox";
            this.TournamentNameValueTextBox.Size = new System.Drawing.Size(247, 35);
            this.TournamentNameValueTextBox.TabIndex = 10;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Location = new System.Drawing.Point(12, 56);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(219, 30);
            this.TournamentNameLabel.TabIndex = 9;
            this.TournamentNameLabel.Text = "TOURNAMENT NAME";
            // 
            // TeamOneScoreValueTextBox
            // 
            this.TeamOneScoreValueTextBox.Location = new System.Drawing.Point(132, 143);
            this.TeamOneScoreValueTextBox.Name = "TeamOneScoreValueTextBox";
            this.TeamOneScoreValueTextBox.Size = new System.Drawing.Size(132, 35);
            this.TeamOneScoreValueTextBox.TabIndex = 12;
            this.TeamOneScoreValueTextBox.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Location = new System.Drawing.Point(12, 143);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(114, 30);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "ENTRY FEE";
            // 
            // SelectTeamDropdown
            // 
            this.SelectTeamDropdown.FormattingEnabled = true;
            this.SelectTeamDropdown.Location = new System.Drawing.Point(17, 227);
            this.SelectTeamDropdown.Name = "SelectTeamDropdown";
            this.SelectTeamDropdown.Size = new System.Drawing.Size(247, 38);
            this.SelectTeamDropdown.TabIndex = 14;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Location = new System.Drawing.Point(12, 194);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(141, 30);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "SELECT TEAM";
            // 
            // CreateNewlinkLabel
            // 
            this.CreateNewlinkLabel.AutoSize = true;
            this.CreateNewlinkLabel.Location = new System.Drawing.Point(159, 194);
            this.CreateNewlinkLabel.Name = "CreateNewlinkLabel";
            this.CreateNewlinkLabel.Size = new System.Drawing.Size(114, 30);
            this.CreateNewlinkLabel.TabIndex = 15;
            this.CreateNewlinkLabel.TabStop = true;
            this.CreateNewlinkLabel.Text = "create new";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Location = new System.Drawing.Point(37, 285);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(210, 48);
            this.AddTeamButton.TabIndex = 16;
            this.AddTeamButton.Text = "ADD TEAM";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePriceButton
            // 
            this.CreatePriceButton.Location = new System.Drawing.Point(37, 339);
            this.CreatePriceButton.Name = "CreatePriceButton";
            this.CreatePriceButton.Size = new System.Drawing.Size(210, 48);
            this.CreatePriceButton.TabIndex = 17;
            this.CreatePriceButton.Text = "CREATE PRICE";
            this.CreatePriceButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 30;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(270, 89);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(250, 182);
            this.TournamentPlayersListBox.TabIndex = 18;
            // 
            // TournamentPlayersLabel
            // 
            this.TournamentPlayersLabel.AutoSize = true;
            this.TournamentPlayersLabel.Location = new System.Drawing.Point(297, 56);
            this.TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            this.TournamentPlayersLabel.Size = new System.Drawing.Size(171, 30);
            this.TournamentPlayersLabel.TabIndex = 19;
            this.TournamentPlayersLabel.Text = "TEAM / PLAYERS";
            // 
            // DeleteSelectedPlayersButton
            // 
            this.DeleteSelectedPlayersButton.Location = new System.Drawing.Point(526, 145);
            this.DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            this.DeleteSelectedPlayersButton.Size = new System.Drawing.Size(116, 70);
            this.DeleteSelectedPlayersButton.TabIndex = 20;
            this.DeleteSelectedPlayersButton.Text = "DELETE SELECTED";
            this.DeleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPriceButton
            // 
            this.DeleteSelectedPriceButton.Location = new System.Drawing.Point(526, 395);
            this.DeleteSelectedPriceButton.Name = "DeleteSelectedPriceButton";
            this.DeleteSelectedPriceButton.Size = new System.Drawing.Size(116, 70);
            this.DeleteSelectedPriceButton.TabIndex = 23;
            this.DeleteSelectedPriceButton.Text = "DELETE SELECTED";
            this.DeleteSelectedPriceButton.UseVisualStyleBackColor = true;
            // 
            // PricesLabel
            // 
            this.PricesLabel.AutoSize = true;
            this.PricesLabel.Location = new System.Drawing.Point(297, 306);
            this.PricesLabel.Name = "PricesLabel";
            this.PricesLabel.Size = new System.Drawing.Size(79, 30);
            this.PricesLabel.TabIndex = 22;
            this.PricesLabel.Text = "PRICES";
            // 
            // PricesListBox
            // 
            this.PricesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PricesListBox.FormattingEnabled = true;
            this.PricesListBox.ItemHeight = 30;
            this.PricesListBox.Location = new System.Drawing.Point(270, 339);
            this.PricesListBox.Name = "PricesListBox";
            this.PricesListBox.Size = new System.Drawing.Size(250, 182);
            this.PricesListBox.TabIndex = 21;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.Location = new System.Drawing.Point(221, 533);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(247, 76);
            this.CreateTournamentButton.TabIndex = 24;
            this.CreateTournamentButton.Text = "CREATE TOURNAMENT";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 621);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedPriceButton);
            this.Controls.Add(this.PricesLabel);
            this.Controls.Add(this.PricesListBox);
            this.Controls.Add(this.DeleteSelectedPlayersButton);
            this.Controls.Add(this.TournamentPlayersLabel);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.CreatePriceButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewlinkLabel);
            this.Controls.Add(this.SelectTeamDropdown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.TeamOneScoreValueTextBox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValueTextBox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TournamentNameValueTextBox;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox TeamOneScoreValueTextBox;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropdown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateNewlinkLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePriceButton;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        private System.Windows.Forms.Label TournamentPlayersLabel;
        private System.Windows.Forms.Button DeleteSelectedPlayersButton;
        private System.Windows.Forms.Button DeleteSelectedPriceButton;
        private System.Windows.Forms.Label PricesLabel;
        private System.Windows.Forms.ListBox PricesListBox;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}