using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            updateDataSourceForCourseListBox();
            updateDataSourceForStudentListBox();
            updateDataSourceForSectionListBox();
            updateDataSourceForRegistrationListBox();
            updateCourseButton.Enabled = false;
            StudentNameTextBox.Text = string.Empty;
            StudentMajorTextBox.Text = string.Empty;
        }

        private void updateDataSourceForCourseListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Course> courses;
                if (courseFilter.Text.IsNullOrEmpty())
                {
                    courses = database.Courses.ToList();
                }
                else
                {
                    courses = database.Courses.ToList().Where(c => c.FullDescription.Contains(courseFilter.Text)).ToList();
                }


                courseListBox.DataSource = courses;
                courseListBox.DisplayMember = "FullDescription";
                courseListBox.ClearSelected();
            }
        }

        private void updateDataSourceForStudentListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Student> student;
                if (StudentFilter.Text.IsNullOrEmpty())
                {
                    student = database.Students.ToList();
                }
                else
                {
                    student = database.Students.ToList().Where(c => c.FullDescriptionforStudents.Contains(StudentFilter.Text)).ToList();
                }


                StudentlistBox.DataSource = student;
                StudentlistBox.DisplayMember = "FullDescription";
                StudentlistBox.ClearSelected();
            }
        }

        private void updateDataSourceForSectionListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Section> section;
                //if (StudentFilter.Text.IsNullOrEmpty())
                //{
                //    student = database.Students.ToList();
                //}
                //else
                {
                    section = database.Sections.ToList();
                }


                SectionlistBox.DataSource = section;
                SectionlistBox.DisplayMember = "FullDescription";
                SectionlistBox.ClearSelected();
            }
        }

        private void updateDataSourceForRegistrationListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Registration> registrations;
                
                
                    registrations = database.Registrations.ToList();



                RegistrationListBox.DataSource = registrations;
                RegistrationListBox.DisplayMember = "FullDescription";
                RegistrationListBox.ClearSelected();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseListLabel.Text = "";
            using (var database = new Database1MdfContext())
            {
                foreach (var course in database.Courses)
                {
                    CourseListLabel.Text += $"{course}" + Environment.NewLine;
                }

            }

        }

        // chat gpt
        // "how do you bind an entity framework core table to a list box in .net core forms"
        // "how do i handle clicking on an item in the list box"

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            // TODO - check for valid input
            Course course = new Course()
            {
                Name = nameTextBox.Text,
                Number = numberTextBox.Text,
                Department = departmentTextBox.Text
            };

            using (var database = new Database1MdfContext())
            {
                if (database.Courses.Any(c => c.Name == course.Name && c.Number == course.Number && c.Department == course.Department))
                {
                    CourseListLabel.Text = "Duplicate course found! Try again!";
                    return;
                }


                database.Courses.Add(course);
                // the nice thing to do is to use async not lock the UI
                database.SaveChanges();
                nameTextBox.Text = "";
                numberTextBox.Text = "";
                departmentTextBox.Text = "";
            }

            updateDataSourceForCourseListBox();
        }

        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem != null)
            {
                Course selectedCourse = (Course)courseListBox.SelectedItem;
                nameTextBox.Text = selectedCourse.Name;
                numberTextBox.Text = selectedCourse.Number;
                departmentTextBox.Text = selectedCourse.Department;
                updateCourseButton.Enabled = true;
            }
        }

        private void updateCourseButton_Click(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem != null)
            {
                Course selectedCourse = (Course)courseListBox.SelectedItem;

                selectedCourse.Name = nameTextBox.Text;
                selectedCourse.Department = departmentTextBox.Text;
                selectedCourse.Number = numberTextBox.Text;

                using (var database = new Database1MdfContext())
                {
                    database.Courses.Update(selectedCourse);
                    database.SaveChanges();
                }

                updateCourseButton.Enabled = false;
                courseListBox.ClearSelected();
                updateDataSourceForCourseListBox();
            }
        }

        private void courseFilter_TextChanged(object sender, EventArgs e)
        {
            updateDataSourceForCourseListBox();
        }

        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentlistBox.SelectedItem != null)
            {
                Student selectedStudent = (Student)StudentlistBox.SelectedItem;

                selectedStudent.Name = StudentNameTextBox.Text;
                selectedStudent.Major = StudentMajorTextBox.Text;


                using (var database = new Database1MdfContext())
                {
                    database.Students.Update(selectedStudent);
                    database.SaveChanges();
                }

                StudentMajorTextBox.Text = "";
                StudentNameTextBox.Text = "";
                updateCourseButton.Enabled = false;
                StudentlistBox.ClearSelected();
                updateDataSourceForStudentListBox();
            }
        }

        private void courseFilter_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void StudentlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentlistBox.SelectedItem != null)
            {
                Student selectedStudent = (Student)StudentlistBox.SelectedItem;
                StudentNameTextBox.Text = selectedStudent.Name;
                StudentMajorTextBox.Text = selectedStudent.Major;

                updateStudentButton.Enabled = true;
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            // TODO - check for valid input
            Student student = new Student()
            {
                Name = StudentNameTextBox.Text,
                Major = StudentMajorTextBox.Text
            };

            using (var database = new Database1MdfContext())
            {
                if (database.Students.Any(c => c.Name == student.Name && c.Major == student.Major))
                {
                    StudentListLabel.Text = "Duplicate course found! Try again!";
                    return;
                }


                database.Students.Add(student);
                // the nice thing to do is to use async not lock the UI
                database.SaveChanges();
                StudentNameTextBox.Text = "";
                StudentMajorTextBox.Text = "";

            }
            //change this
            updateDataSourceForStudentListBox();
        }

        private void ShowStudentListButton_Click(object sender, EventArgs e)
        {
            StudentListLabel.Text = "";
            using (var database = new Database1MdfContext())
            {
                foreach (var student in database.Students)
                {
                    StudentListLabel.Text += $"{student}" + Environment.NewLine;
                }

            }

        }

        private void SectionlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectionlistBox.SelectedItem != null)
            {
                Section selectedSection = (Section)SectionlistBox.SelectedItem;

               


            }
        }
        
        // Note: When you register it automatically assigns the grade 'U'.
        //To Update the grade, select the registration, insert the grade, and click the "Upgrade grade" button 

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
            Registration registration;
            int CourseSelectedItemId = -1;
            int SectionSelectedItemId = -1;
            int StudentSelectedItemId = -1;
            string grade;


           
                if (StudentlistBox.SelectedIndex != -1 && SectionlistBox.SelectedIndex != -1)
                {


                    Section selectedItemForSection = (Section)SectionlistBox.SelectedItem;
                    SectionSelectedItemId = selectedItemForSection.Id;

                    Student selectedItemForStudent = (Student)StudentlistBox.SelectedItem;
                    StudentSelectedItemId = selectedItemForStudent.Id;

                    grade = "U";


                    registration = new Registration()
                    {

                        SectionId = SectionSelectedItemId,//selected section id 
                        StudentId = StudentSelectedItemId,//selected student id 

                        Grade = grade
                    };
                    using (var database = new Database1MdfContext())
                    {

                        database.Registrations.Add(registration);
                        database.SaveChanges();


                    }


                    RegisterationListLabel.Text = "";
                    using (var database = new Database1MdfContext())
                    {
                        foreach (var registrations in database.Registrations)
                        {

                            RegisterationListLabel.Text += $"{registrations}" + Environment.NewLine;
                        }

                    }


                }

            updateDataSourceForRegistrationListBox();



        }

        private void RegisterationList_Click(object sender, EventArgs e)
        {

        }

        private void CourseListLabel_Click(object sender, EventArgs e)
        {

        }

        private void StudentListLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeleteRegistration_Click(object sender, EventArgs e)
        {
            if (RegistrationListBox.SelectedItem != null)
            {
                Registration selectedRegistration = (Registration)RegistrationListBox.SelectedItem;

               

                using (var database = new Database1MdfContext())
                {

                    database.Registrations.Remove(selectedRegistration);

                    database.SaveChanges();
                }

                RegisterationListLabel.Text = "";
                using (var database = new Database1MdfContext())
                {
                    foreach (var registrations in database.Registrations)
                    {

                        RegisterationListLabel.Text += $"{registrations}" + Environment.NewLine;
                    }

                }
                

                RegistrationListBox.ClearSelected();
                updateDataSourceForRegistrationListBox();
            }
        }

        private void UpdateGradeButton_Click(object sender, EventArgs e)
        {
            if (RegistrationListBox.SelectedItem != null)
            {
                Registration selectedRegistration = (Registration)RegistrationListBox.SelectedItem;
                
                selectedRegistration.Grade = UpgradeGradetextBox.Text;
                
                using (var database = new Database1MdfContext())
                {
                    database.Registrations.Update(selectedRegistration);
                    database.SaveChanges();
                }

                UpdateGradeButton.Enabled = false;
                RegistrationListBox.ClearSelected();
                updateDataSourceForRegistrationListBox();

                UpgradeGradetextBox.Text = "";

                RegisterationListLabel.Text = "";
                using (var database = new Database1MdfContext())
                {
                    foreach (var registrations in database.Registrations)
                    {

                        RegisterationListLabel.Text += $"{registrations}" + Environment.NewLine;
                    }

                }
            }
        }
    }
}
