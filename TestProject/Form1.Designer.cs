namespace TestProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CourseListLabel = new System.Windows.Forms.Label();
            this.ShowCourseListRO = new System.Windows.Forms.Button();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.updateCourseButton = new System.Windows.Forms.Button();
            this.StudentFilter = new System.Windows.Forms.TextBox();
            this.courseFilter = new System.Windows.Forms.TextBox();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.MajorROLB = new System.Windows.Forms.Label();
            this.StudentMajorTextBox = new System.Windows.Forms.TextBox();
            this.NameROLB = new System.Windows.Forms.Label();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentlistBox = new System.Windows.Forms.ListBox();
            this.ShowStudentListButton = new System.Windows.Forms.Button();
            this.StudentListLabel = new System.Windows.Forms.Label();
            this.SectionlistBox = new System.Windows.Forms.ListBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterationListLabel = new System.Windows.Forms.Label();
            this.RegistrationListBox = new System.Windows.Forms.ListBox();
            this.DeleteRegistration = new System.Windows.Forms.Button();
            this.UpdateGradeButton = new System.Windows.Forms.Button();
            this.UpgradeGradetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CourseListLabel
            // 
            this.CourseListLabel.AutoSize = true;
            this.CourseListLabel.Location = new System.Drawing.Point(402, 65);
            this.CourseListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseListLabel.Name = "CourseListLabel";
            this.CourseListLabel.Size = new System.Drawing.Size(0, 25);
            this.CourseListLabel.TabIndex = 0;
            this.CourseListLabel.Click += new System.EventHandler(this.CourseListLabel_Click);
            // 
            // ShowCourseListRO
            // 
            this.ShowCourseListRO.Location = new System.Drawing.Point(402, 13);
            this.ShowCourseListRO.Margin = new System.Windows.Forms.Padding(4);
            this.ShowCourseListRO.Name = "ShowCourseListRO";
            this.ShowCourseListRO.Size = new System.Drawing.Size(158, 36);
            this.ShowCourseListRO.TabIndex = 1;
            this.ShowCourseListRO.Text = "Show Course List ";
            this.ShowCourseListRO.UseVisualStyleBackColor = true;
            this.ShowCourseListRO.Click += new System.EventHandler(this.button1_Click);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(925, 13);
            this.departmentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(273, 31);
            this.departmentTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(925, 54);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(273, 31);
            this.numberTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(782, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(925, 106);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(273, 31);
            this.nameTextBox.TabIndex = 6;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(879, 145);
            this.addCourseButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(118, 36);
            this.addCourseButton.TabIndex = 8;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 25;
            this.courseListBox.Location = new System.Drawing.Point(13, 32);
            this.courseListBox.Margin = new System.Windows.Forms.Padding(4);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(317, 154);
            this.courseListBox.TabIndex = 9;
            this.courseListBox.Click += new System.EventHandler(this.courseListBox_SelectedIndexChanged);
            // 
            // updateCourseButton
            // 
            this.updateCourseButton.Location = new System.Drawing.Point(1051, 145);
            this.updateCourseButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateCourseButton.Name = "updateCourseButton";
            this.updateCourseButton.Size = new System.Drawing.Size(158, 36);
            this.updateCourseButton.TabIndex = 10;
            this.updateCourseButton.Text = "Update Course";
            this.updateCourseButton.UseVisualStyleBackColor = true;
            this.updateCourseButton.Click += new System.EventHandler(this.updateCourseButton_Click);
            // 
            // StudentFilter
            // 
            this.StudentFilter.Location = new System.Drawing.Point(13, 194);
            this.StudentFilter.Margin = new System.Windows.Forms.Padding(4);
            this.StudentFilter.Name = "StudentFilter";
            this.StudentFilter.Size = new System.Drawing.Size(155, 31);
            this.StudentFilter.TabIndex = 11;
            // 
            // courseFilter
            // 
            this.courseFilter.Location = new System.Drawing.Point(13, 2);
            this.courseFilter.Margin = new System.Windows.Forms.Padding(4);
            this.courseFilter.Name = "courseFilter";
            this.courseFilter.Size = new System.Drawing.Size(155, 31);
            this.courseFilter.TabIndex = 12;
            this.courseFilter.Click += new System.EventHandler(this.courseFilter_TextChanged);
            this.courseFilter.TextChanged += new System.EventHandler(this.courseFilter_TextChanged_1);
            // 
            // updateStudentButton
            // 
            this.updateStudentButton.Location = new System.Drawing.Point(1051, 299);
            this.updateStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(158, 36);
            this.updateStudentButton.TabIndex = 20;
            this.updateStudentButton.Text = "Update Student";
            this.updateStudentButton.UseVisualStyleBackColor = true;
            this.updateStudentButton.Click += new System.EventHandler(this.UpdateStudentButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(879, 299);
            this.AddStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(137, 36);
            this.AddStudentButton.TabIndex = 19;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // MajorROLB
            // 
            this.MajorROLB.AutoSize = true;
            this.MajorROLB.Location = new System.Drawing.Point(782, 257);
            this.MajorROLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MajorROLB.Name = "MajorROLB";
            this.MajorROLB.Size = new System.Drawing.Size(58, 25);
            this.MajorROLB.TabIndex = 18;
            this.MajorROLB.Text = "Major";
            // 
            // StudentMajorTextBox
            // 
            this.StudentMajorTextBox.Location = new System.Drawing.Point(925, 251);
            this.StudentMajorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentMajorTextBox.Name = "StudentMajorTextBox";
            this.StudentMajorTextBox.Size = new System.Drawing.Size(273, 31);
            this.StudentMajorTextBox.TabIndex = 17;
            // 
            // NameROLB
            // 
            this.NameROLB.AutoSize = true;
            this.NameROLB.Location = new System.Drawing.Point(782, 205);
            this.NameROLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameROLB.Name = "NameROLB";
            this.NameROLB.Size = new System.Drawing.Size(59, 25);
            this.NameROLB.TabIndex = 16;
            this.NameROLB.Text = "Name";
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(925, 199);
            this.StudentNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(273, 31);
            this.StudentNameTextBox.TabIndex = 15;
            // 
            // StudentlistBox
            // 
            this.StudentlistBox.FormattingEnabled = true;
            this.StudentlistBox.ItemHeight = 25;
            this.StudentlistBox.Location = new System.Drawing.Point(13, 220);
            this.StudentlistBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentlistBox.Name = "StudentlistBox";
            this.StudentlistBox.Size = new System.Drawing.Size(317, 154);
            this.StudentlistBox.TabIndex = 21;
            this.StudentlistBox.SelectedIndexChanged += new System.EventHandler(this.StudentlistBox_SelectedIndexChanged);
            // 
            // ShowStudentListButton
            // 
            this.ShowStudentListButton.Location = new System.Drawing.Point(402, 192);
            this.ShowStudentListButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowStudentListButton.Name = "ShowStudentListButton";
            this.ShowStudentListButton.Size = new System.Drawing.Size(166, 36);
            this.ShowStudentListButton.TabIndex = 23;
            this.ShowStudentListButton.Text = "Show Student List ";
            this.ShowStudentListButton.UseVisualStyleBackColor = true;
            this.ShowStudentListButton.Click += new System.EventHandler(this.ShowStudentListButton_Click);
            // 
            // StudentListLabel
            // 
            this.StudentListLabel.AutoSize = true;
            this.StudentListLabel.Location = new System.Drawing.Point(402, 244);
            this.StudentListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentListLabel.Name = "StudentListLabel";
            this.StudentListLabel.Size = new System.Drawing.Size(0, 25);
            this.StudentListLabel.TabIndex = 22;
            this.StudentListLabel.Click += new System.EventHandler(this.StudentListLabel_Click);
            // 
            // SectionlistBox
            // 
            this.SectionlistBox.FormattingEnabled = true;
            this.SectionlistBox.ItemHeight = 25;
            this.SectionlistBox.Location = new System.Drawing.Point(13, 382);
            this.SectionlistBox.Margin = new System.Windows.Forms.Padding(4);
            this.SectionlistBox.Name = "SectionlistBox";
            this.SectionlistBox.Size = new System.Drawing.Size(511, 154);
            this.SectionlistBox.TabIndex = 24;
            this.SectionlistBox.SelectedIndexChanged += new System.EventHandler(this.SectionlistBox_SelectedIndexChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(606, 403);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(166, 36);
            this.RegisterButton.TabIndex = 25;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterationListLabel
            // 
            this.RegisterationListLabel.AutoSize = true;
            this.RegisterationListLabel.Location = new System.Drawing.Point(606, 455);
            this.RegisterationListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisterationListLabel.Name = "RegisterationListLabel";
            this.RegisterationListLabel.Size = new System.Drawing.Size(0, 25);
            this.RegisterationListLabel.TabIndex = 26;
            this.RegisterationListLabel.Click += new System.EventHandler(this.RegisterationList_Click);
            // 
            // RegistrationListBox
            // 
            this.RegistrationListBox.FormattingEnabled = true;
            this.RegistrationListBox.ItemHeight = 25;
            this.RegistrationListBox.Location = new System.Drawing.Point(13, 553);
            this.RegistrationListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrationListBox.Name = "RegistrationListBox";
            this.RegistrationListBox.Size = new System.Drawing.Size(511, 154);
            this.RegistrationListBox.TabIndex = 27;
            // 
            // DeleteRegistration
            // 
            this.DeleteRegistration.Location = new System.Drawing.Point(815, 403);
            this.DeleteRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteRegistration.Name = "DeleteRegistration";
            this.DeleteRegistration.Size = new System.Drawing.Size(201, 36);
            this.DeleteRegistration.TabIndex = 28;
            this.DeleteRegistration.Text = "Delete Registration";
            this.DeleteRegistration.UseVisualStyleBackColor = true;
            this.DeleteRegistration.Click += new System.EventHandler(this.DeleteRegistration_Click);
            // 
            // UpdateGradeButton
            // 
            this.UpdateGradeButton.Location = new System.Drawing.Point(1042, 449);
            this.UpdateGradeButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateGradeButton.Name = "UpdateGradeButton";
            this.UpdateGradeButton.Size = new System.Drawing.Size(167, 36);
            this.UpdateGradeButton.TabIndex = 29;
            this.UpdateGradeButton.Text = "Update Grade";
            this.UpdateGradeButton.UseVisualStyleBackColor = true;
            this.UpdateGradeButton.Click += new System.EventHandler(this.UpdateGradeButton_Click);
            // 
            // UpgradeGradetextBox
            // 
            this.UpgradeGradetextBox.Location = new System.Drawing.Point(1054, 410);
            this.UpgradeGradetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpgradeGradetextBox.Name = "UpgradeGradetextBox";
            this.UpgradeGradetextBox.Size = new System.Drawing.Size(155, 31);
            this.UpgradeGradetextBox.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 753);
            this.Controls.Add(this.UpgradeGradetextBox);
            this.Controls.Add(this.UpdateGradeButton);
            this.Controls.Add(this.DeleteRegistration);
            this.Controls.Add(this.RegistrationListBox);
            this.Controls.Add(this.RegisterationListLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SectionlistBox);
            this.Controls.Add(this.ShowStudentListButton);
            this.Controls.Add(this.StudentListLabel);
            this.Controls.Add(this.StudentlistBox);
            this.Controls.Add(this.updateStudentButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.MajorROLB);
            this.Controls.Add(this.StudentMajorTextBox);
            this.Controls.Add(this.NameROLB);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.courseFilter);
            this.Controls.Add(this.StudentFilter);
            this.Controls.Add(this.updateCourseButton);
            this.Controls.Add(this.courseListBox);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.ShowCourseListRO);
            this.Controls.Add(this.CourseListLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CourseListLabel;
        private Button ShowCourseListRO;
        private TextBox departmentTextBox;
        private Label label2;
        private Label label3;
        private TextBox numberTextBox;
        private Label label4;
        private TextBox nameTextBox;
        private Button addCourseButton;
        private ListBox courseListBox;
        private Button updateCourseButton;
        private TextBox StudentFilter;
        private TextBox courseFilter;
        private Button updateStudentButton;
        private Button AddStudentButton;
        private Label MajorROLB;
        private TextBox StudentMajorTextBox;
        private Label NameROLB;
        private TextBox StudentNameTextBox;
        private ListBox StudentlistBox;
        private Button ShowStudentListButton;
        private Label StudentListLabel;
        private ListBox SectionlistBox;
        private Button RegisterButton;
        private Label RegisterationListLabel;
        private ListBox RegistrationListBox;
        private Button DeleteRegistration;
        private Button UpdateGradeButton;
        private TextBox UpgradeGradetextBox;
    }
}