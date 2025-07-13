namespace RainaN_Assign2
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
            this.SchoolListBox = new System.Windows.Forms.ListBox();
            this.loadSchoolData = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.GroupBox();
            this.updateData = new System.Windows.Forms.GroupBox();
            this.desenOrderOfTotalFunds = new System.Windows.Forms.Button();
            this.delSelectedSchool = new System.Windows.Forms.Button();
            this.updateNumStudsJoining = new System.Windows.Forms.Button();
            this.NumStudsJoiningTextBox = new System.Windows.Forms.TextBox();
            this.numOfStudsJoining = new System.Windows.Forms.Label();
            this.updateNumStudsLeaving = new System.Windows.Forms.Button();
            this.NumStudsLeavingTextBox = new System.Windows.Forms.TextBox();
            this.numOfStudsLeaving = new System.Windows.Forms.Label();
            this.saveData = new System.Windows.Forms.GroupBox();
            this.writeFundsRequestInfo = new System.Windows.Forms.Button();
            this.writeEnrollExceedData = new System.Windows.Forms.Button();
            this.writeOutputData = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.schoolName = new System.Windows.Forms.Label();
            this.loadData.SuspendLayout();
            this.updateData.SuspendLayout();
            this.saveData.SuspendLayout();
            this.SuspendLayout();
            // 
            // SchoolListBox
            // 
            this.SchoolListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolListBox.FormattingEnabled = true;
            this.SchoolListBox.Location = new System.Drawing.Point(32, 85);
            this.SchoolListBox.Name = "SchoolListBox";
            this.SchoolListBox.Size = new System.Drawing.Size(1471, 238);
            this.SchoolListBox.TabIndex = 0;
            this.SchoolListBox.SelectedIndexChanged += new System.EventHandler(this.SchoolListBox_SelectedIndexChanged);
            // 
            // loadSchoolData
            // 
            this.loadSchoolData.AutoSize = true;
            this.loadSchoolData.Location = new System.Drawing.Point(51, 56);
            this.loadSchoolData.Name = "loadSchoolData";
            this.loadSchoolData.Size = new System.Drawing.Size(166, 33);
            this.loadSchoolData.TabIndex = 1;
            this.loadSchoolData.Text = "Load School Data";
            this.loadSchoolData.UseVisualStyleBackColor = true;
            this.loadSchoolData.Click += new System.EventHandler(this.loadSchoolData_Click);
            // 
            // loadData
            // 
            this.loadData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadData.Controls.Add(this.loadSchoolData);
            this.loadData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadData.Location = new System.Drawing.Point(60, 396);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(288, 145);
            this.loadData.TabIndex = 2;
            this.loadData.TabStop = false;
            this.loadData.Text = "Load Data";
            // 
            // updateData
            // 
            this.updateData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateData.Controls.Add(this.desenOrderOfTotalFunds);
            this.updateData.Controls.Add(this.delSelectedSchool);
            this.updateData.Controls.Add(this.updateNumStudsJoining);
            this.updateData.Controls.Add(this.NumStudsJoiningTextBox);
            this.updateData.Controls.Add(this.numOfStudsJoining);
            this.updateData.Controls.Add(this.updateNumStudsLeaving);
            this.updateData.Controls.Add(this.NumStudsLeavingTextBox);
            this.updateData.Controls.Add(this.numOfStudsLeaving);
            this.updateData.Location = new System.Drawing.Point(407, 344);
            this.updateData.Name = "updateData";
            this.updateData.Size = new System.Drawing.Size(606, 235);
            this.updateData.TabIndex = 3;
            this.updateData.TabStop = false;
            this.updateData.Text = "Update Data";
            // 
            // desenOrderOfTotalFunds
            // 
            this.desenOrderOfTotalFunds.AutoSize = true;
            this.desenOrderOfTotalFunds.Location = new System.Drawing.Point(331, 140);
            this.desenOrderOfTotalFunds.Name = "desenOrderOfTotalFunds";
            this.desenOrderOfTotalFunds.Size = new System.Drawing.Size(252, 60);
            this.desenOrderOfTotalFunds.TabIndex = 7;
            this.desenOrderOfTotalFunds.Text = "Sort Schools By Descending Order of Total Funds";
            this.desenOrderOfTotalFunds.UseVisualStyleBackColor = true;
            this.desenOrderOfTotalFunds.Click += new System.EventHandler(this.desenOrderOfTotalFunds_Click);
            // 
            // delSelectedSchool
            // 
            this.delSelectedSchool.AutoSize = true;
            this.delSelectedSchool.Location = new System.Drawing.Point(86, 140);
            this.delSelectedSchool.Name = "delSelectedSchool";
            this.delSelectedSchool.Size = new System.Drawing.Size(144, 60);
            this.delSelectedSchool.TabIndex = 6;
            this.delSelectedSchool.Text = "Delete Selected School";
            this.delSelectedSchool.UseVisualStyleBackColor = true;
            this.delSelectedSchool.Click += new System.EventHandler(this.delSelectedSchool_Click);
            // 
            // updateNumStudsJoining
            // 
            this.updateNumStudsJoining.AutoSize = true;
            this.updateNumStudsJoining.Location = new System.Drawing.Point(381, 52);
            this.updateNumStudsJoining.Name = "updateNumStudsJoining";
            this.updateNumStudsJoining.Size = new System.Drawing.Size(158, 34);
            this.updateNumStudsJoining.TabIndex = 5;
            this.updateNumStudsJoining.Text = "Update Num Students Joining";
            this.updateNumStudsJoining.UseVisualStyleBackColor = true;
            this.updateNumStudsJoining.Click += new System.EventHandler(this.updateNumStudsJoining_Click);
            // 
            // NumStudsJoiningTextBox
            // 
            this.NumStudsJoiningTextBox.Location = new System.Drawing.Point(456, 26);
            this.NumStudsJoiningTextBox.Name = "NumStudsJoiningTextBox";
            this.NumStudsJoiningTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumStudsJoiningTextBox.TabIndex = 4;
            // 
            // numOfStudsJoining
            // 
            this.numOfStudsJoining.AutoSize = true;
            this.numOfStudsJoining.Location = new System.Drawing.Point(328, 29);
            this.numOfStudsJoining.Name = "numOfStudsJoining";
            this.numOfStudsJoining.Size = new System.Drawing.Size(125, 13);
            this.numOfStudsJoining.TabIndex = 3;
            this.numOfStudsJoining.Text = "Number of Studs Joining:";
            // 
            // updateNumStudsLeaving
            // 
            this.updateNumStudsLeaving.AutoSize = true;
            this.updateNumStudsLeaving.Location = new System.Drawing.Point(67, 52);
            this.updateNumStudsLeaving.Name = "updateNumStudsLeaving";
            this.updateNumStudsLeaving.Size = new System.Drawing.Size(163, 34);
            this.updateNumStudsLeaving.TabIndex = 2;
            this.updateNumStudsLeaving.Text = "Update Num Students Leaving";
            this.updateNumStudsLeaving.UseVisualStyleBackColor = true;
            this.updateNumStudsLeaving.Click += new System.EventHandler(this.updateNumStudsLeaving_Click);
            // 
            // NumStudsLeavingTextBox
            // 
            this.NumStudsLeavingTextBox.Location = new System.Drawing.Point(149, 26);
            this.NumStudsLeavingTextBox.Name = "NumStudsLeavingTextBox";
            this.NumStudsLeavingTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumStudsLeavingTextBox.TabIndex = 1;
            // 
            // numOfStudsLeaving
            // 
            this.numOfStudsLeaving.AutoSize = true;
            this.numOfStudsLeaving.Location = new System.Drawing.Point(16, 29);
            this.numOfStudsLeaving.Name = "numOfStudsLeaving";
            this.numOfStudsLeaving.Size = new System.Drawing.Size(130, 13);
            this.numOfStudsLeaving.TabIndex = 0;
            this.numOfStudsLeaving.Text = "Number of Studs Leaving:";
            // 
            // saveData
            // 
            this.saveData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveData.Controls.Add(this.writeFundsRequestInfo);
            this.saveData.Controls.Add(this.writeEnrollExceedData);
            this.saveData.Controls.Add(this.writeOutputData);
            this.saveData.Location = new System.Drawing.Point(1094, 344);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(314, 235);
            this.saveData.TabIndex = 4;
            this.saveData.TabStop = false;
            this.saveData.Text = "Save Data";
            // 
            // writeFundsRequestInfo
            // 
            this.writeFundsRequestInfo.AutoSize = true;
            this.writeFundsRequestInfo.Location = new System.Drawing.Point(59, 157);
            this.writeFundsRequestInfo.Name = "writeFundsRequestInfo";
            this.writeFundsRequestInfo.Size = new System.Drawing.Size(216, 43);
            this.writeFundsRequestInfo.TabIndex = 2;
            this.writeFundsRequestInfo.Text = "Write Funds Requested Data";
            this.writeFundsRequestInfo.UseVisualStyleBackColor = true;
            this.writeFundsRequestInfo.Click += new System.EventHandler(this.writeFundsRequestInfo_Click);
            // 
            // writeEnrollExceedData
            // 
            this.writeEnrollExceedData.AutoSize = true;
            this.writeEnrollExceedData.Location = new System.Drawing.Point(59, 102);
            this.writeEnrollExceedData.Name = "writeEnrollExceedData";
            this.writeEnrollExceedData.Size = new System.Drawing.Size(216, 44);
            this.writeEnrollExceedData.TabIndex = 1;
            this.writeEnrollExceedData.Text = "Write Enrollment Exceeded School Data";
            this.writeEnrollExceedData.UseVisualStyleBackColor = true;
            this.writeEnrollExceedData.Click += new System.EventHandler(this.writeEnrollExceedData_Click);
            // 
            // writeOutputData
            // 
            this.writeOutputData.AutoSize = true;
            this.writeOutputData.Location = new System.Drawing.Point(59, 51);
            this.writeOutputData.Name = "writeOutputData";
            this.writeOutputData.Size = new System.Drawing.Size(216, 45);
            this.writeOutputData.TabIndex = 0;
            this.writeOutputData.Text = "Write School Output Data";
            this.writeOutputData.UseVisualStyleBackColor = true;
            this.writeOutputData.Click += new System.EventHandler(this.writeOutputData_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(173, 594);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(1062, 48);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status is Displayed here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // schoolName
            // 
            this.schoolName.BackColor = System.Drawing.Color.RosyBrown;
            this.schoolName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolName.Location = new System.Drawing.Point(372, 9);
            this.schoolName.Name = "schoolName";
            this.schoolName.Size = new System.Drawing.Size(800, 62);
            this.schoolName.TabIndex = 6;
            this.schoolName.Text = "Vancouver School Board Enrollment and Funds Management Software";
            this.schoolName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 651);
            this.Controls.Add(this.schoolName);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.updateData);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.SchoolListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loadData.ResumeLayout(false);
            this.loadData.PerformLayout();
            this.updateData.ResumeLayout(false);
            this.updateData.PerformLayout();
            this.saveData.ResumeLayout(false);
            this.saveData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SchoolListBox;
        private System.Windows.Forms.Button loadSchoolData;
        private System.Windows.Forms.GroupBox loadData;
        private System.Windows.Forms.GroupBox updateData;
        private System.Windows.Forms.TextBox NumStudsLeavingTextBox;
        private System.Windows.Forms.Label numOfStudsLeaving;
        private System.Windows.Forms.GroupBox saveData;
        private System.Windows.Forms.TextBox NumStudsJoiningTextBox;
        private System.Windows.Forms.Label numOfStudsJoining;
        private System.Windows.Forms.Button updateNumStudsLeaving;
        private System.Windows.Forms.Button updateNumStudsJoining;
        private System.Windows.Forms.Button desenOrderOfTotalFunds;
        private System.Windows.Forms.Button delSelectedSchool;
        private System.Windows.Forms.Button writeEnrollExceedData;
        private System.Windows.Forms.Button writeOutputData;
        private System.Windows.Forms.Button writeFundsRequestInfo;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label schoolName;
    }
}

