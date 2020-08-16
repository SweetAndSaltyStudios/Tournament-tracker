namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.TeamNameValueTextBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.AddTeamMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstNameValueTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameValueTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailValueTextBox = new System.Windows.Forms.TextBox();
            this.EmailValueLabel = new System.Windows.Forms.Label();
            this.PhoneValueTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedTeamMembersButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValueTextBox
            // 
            this.TeamNameValueTextBox.Location = new System.Drawing.Point(12, 72);
            this.TeamNameValueTextBox.Name = "TeamNameValueTextBox";
            this.TeamNameValueTextBox.Size = new System.Drawing.Size(362, 35);
            this.TeamNameValueTextBox.TabIndex = 12;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Location = new System.Drawing.Point(12, 39);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(134, 30);
            this.TeamNameLabel.TabIndex = 11;
            this.TeamNameLabel.Text = "TEAM NAME";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(176, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(150, 30);
            this.HeaderLabel.TabIndex = 13;
            this.HeaderLabel.Text = "CREATE TEAM:";
            // 
            // AddTeamMemberButton
            // 
            this.AddTeamMemberButton.Location = new System.Drawing.Point(91, 187);
            this.AddTeamMemberButton.Name = "AddTeamMemberButton";
            this.AddTeamMemberButton.Size = new System.Drawing.Size(210, 40);
            this.AddTeamMemberButton.TabIndex = 19;
            this.AddTeamMemberButton.Text = "ADD MEMBER";
            this.AddTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropdown
            // 
            this.SelectTeamMemberDropdown.FormattingEnabled = true;
            this.SelectTeamMemberDropdown.Location = new System.Drawing.Point(12, 143);
            this.SelectTeamMemberDropdown.Name = "SelectTeamMemberDropdown";
            this.SelectTeamMemberDropdown.Size = new System.Drawing.Size(362, 38);
            this.SelectTeamMemberDropdown.TabIndex = 18;
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(12, 110);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(232, 30);
            this.SelectTeamMemberLabel.TabIndex = 17;
            this.SelectTeamMemberLabel.Text = "SELECT TEAM MEMBER";
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberGroupBox.Controls.Add(this.PhoneValueTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.PhoneLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailValueTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailValueLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameValueTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameValueTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(12, 233);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(368, 284);
            this.AddNewMemberGroupBox.TabIndex = 20;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "ADD NEW MEMBER";
            // 
            // FirstNameValueTextBox
            // 
            this.FirstNameValueTextBox.Location = new System.Drawing.Point(142, 41);
            this.FirstNameValueTextBox.Name = "FirstNameValueTextBox";
            this.FirstNameValueTextBox.Size = new System.Drawing.Size(220, 35);
            this.FirstNameValueTextBox.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 44);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(130, 30);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "FIRST NAME";
            // 
            // LastNameValueTextBox
            // 
            this.LastNameValueTextBox.Location = new System.Drawing.Point(142, 88);
            this.LastNameValueTextBox.Name = "LastNameValueTextBox";
            this.LastNameValueTextBox.Size = new System.Drawing.Size(220, 35);
            this.LastNameValueTextBox.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(6, 91);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(126, 30);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "LAST NAME";
            // 
            // EmailValueTextBox
            // 
            this.EmailValueTextBox.Location = new System.Drawing.Point(142, 129);
            this.EmailValueTextBox.Name = "EmailValueTextBox";
            this.EmailValueTextBox.Size = new System.Drawing.Size(220, 35);
            this.EmailValueTextBox.TabIndex = 14;
            // 
            // EmailValueLabel
            // 
            this.EmailValueLabel.AutoSize = true;
            this.EmailValueLabel.Location = new System.Drawing.Point(6, 132);
            this.EmailValueLabel.Name = "EmailValueLabel";
            this.EmailValueLabel.Size = new System.Drawing.Size(73, 30);
            this.EmailValueLabel.TabIndex = 13;
            this.EmailValueLabel.Text = "EMAIL";
            // 
            // PhoneValueTextBox
            // 
            this.PhoneValueTextBox.Location = new System.Drawing.Point(142, 170);
            this.PhoneValueTextBox.Name = "PhoneValueTextBox";
            this.PhoneValueTextBox.Size = new System.Drawing.Size(220, 35);
            this.PhoneValueTextBox.TabIndex = 16;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(6, 173);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(83, 30);
            this.PhoneLabel.TabIndex = 15;
            this.PhoneLabel.Text = "PHONE";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.Location = new System.Drawing.Point(79, 238);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(210, 40);
            this.CreateMemberButton.TabIndex = 21;
            this.CreateMemberButton.Text = "CREATE MEMBER";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 30;
            this.TeamMembersListBox.Location = new System.Drawing.Point(408, 89);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(250, 422);
            this.TeamMembersListBox.TabIndex = 21;
            // 
            // DeleteSelectedTeamMembersButton
            // 
            this.DeleteSelectedTeamMembersButton.Location = new System.Drawing.Point(674, 265);
            this.DeleteSelectedTeamMembersButton.Name = "DeleteSelectedTeamMembersButton";
            this.DeleteSelectedTeamMembersButton.Size = new System.Drawing.Size(116, 70);
            this.DeleteSelectedTeamMembersButton.TabIndex = 22;
            this.DeleteSelectedTeamMembersButton.Text = "DELETE SELECTED";
            this.DeleteSelectedTeamMembersButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.Location = new System.Drawing.Point(263, 537);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(247, 76);
            this.CreateTeamButton.TabIndex = 25;
            this.CreateTeamButton.Text = "CREATE TEAM";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 621);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedTeamMembersButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.AddTeamMemberButton);
            this.Controls.Add(this.SelectTeamMemberDropdown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.TeamNameValueTextBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValueTextBox;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button AddTeamMemberButton;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropdown;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.GroupBox AddNewMemberGroupBox;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.TextBox PhoneValueTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox EmailValueTextBox;
        private System.Windows.Forms.Label EmailValueLabel;
        private System.Windows.Forms.TextBox LastNameValueTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameValueTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button DeleteSelectedTeamMembersButton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}