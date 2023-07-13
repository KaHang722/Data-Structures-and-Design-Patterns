using Microsoft.VisualBasic;
using System;
using System.Collections;

namespace Project1
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Form3 form3;
        private Form4 form4;
        private ArrayList studentlist;
        private ArrayList facultylist;
        private ArrayList courselist;

        public Form1()
        {
            InitializeComponent();
            studentlist = new ArrayList();
            facultylist = new ArrayList();
            courselist = new ArrayList();
            form2 = new Form2(this, facultylist, courselist, studentlist);


        }

        //Change the label text when radio button is checked
        private void rbCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
            {
                label1.Text = "Student ID:";
                label2.Text = "First Name:";
                label3.Text = "Last Name:";
                label4.Text = "Gender:";
                label5.Text = "Department:";
                lblError.Text = "";
            }
            else if (rbFaculty.Checked)
            {
                label1.Text = "Faculty ID:";
                label2.Text = "First Name:";
                label3.Text = "Last Name:";
                label4.Text = "Gender:";
                label5.Text = "Department:";
                lblError.Text = "";
            }
            else if (rbCourse.Checked)
            {
                label1.Text = "Course Name:";
                label2.Text = "Course Code:";
                label3.Text = "Location:";
                label4.Text = "Day:";
                label5.Text = "Number of Hour:";
                lblError.Text = "";
            }
            this.textboxClear();
        }

        //Switching to form2 (Faculty)
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }


        //Adding objects to arraylist
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
                bool flag = true;
                if (textBox1.Text != "" && textBox2.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "") //check the textbox is empty or not
                {
                    if (rbStudent.Checked) //add a student object into studentlist if radio button 'student' is checked
                    {
                        foreach (Student s in studentlist)
                        {
                            if (s.StudentID == Int32.Parse(textBox1.Text)) //check if the Student ID is duplicate
                            {
                                flag = false;
                                lblError.Text = "Duplicate student ID not allowed";
                            }
                        }
                        if (flag)
                        {
                            if (textBox4.Text.Contains("Male") || textBox4.Text.Contains("Female")) //check if the gender is either male or female
                            {
                                studentlist.Add(new Student(Int32.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
                                lblError.Text = "";
                            }
                            else
                            {
                                lblError.Text = "Gender should be 'Male' or 'Female'";
                            }
                        }
                    }
                    else if (rbFaculty.Checked) //add a faculty object into facultylist if radio button 'faculty' is checked
                    {
                        foreach (Faculty f in facultylist)
                        {
                            if (f.FacultyID == Int32.Parse(textBox1.Text)) //check if the faculty ID is duplicate
                            {
                                flag = false;
                                lblError.Text = "Duplicate faculty ID not allowed";
                            }
                        }
                        if (flag)
                        {
                            if (textBox4.Text.Contains("Male") || textBox4.Text.Contains("Female")) //check if the gender is either male or female
                            {
                                facultylist.Add(new Faculty(Int32.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
                                lblError.Text = "";
                            }
                            else
                            {
                                lblError.Text = "Gender should be 'Male' or 'Female'";
                            }
                        }
                    }
                    else if (rbCourse.Checked) //add a course object into courselist if radio button 'course' is checked
                    {
                        foreach (Course c in courselist)
                        {
                            if (c.CourseName == textBox1.Text && c.CourseCode == textBox2.Text) //check if the course name or course code is/are duplicate
                            {
                                flag = false;
                                lblError.Text = "Duplicate course name and course code not allowed";
                            }
                            else if (c.CourseCode == textBox2.Text)
                            {
                                flag = false;
                                lblError.Text = "Duplicate course code not allowed";
                            }
                            else if (c.CourseName == textBox1.Text)
                            {
                                flag = false;
                                lblError.Text = "Duplicate course name not allowed";
                            }
                        }
                        if (flag)
                        {
                            
                            if (IsInt(textBox5)||textBox4.Text.Contains("Monday") || textBox4.Text.Contains("Tuesday") || textBox4.Text.Contains("Wednesday") || textBox4.Text.Contains("Thursday") || textBox4.Text.Contains("Friday"))//check if the day is betweem monday and friday
                            {
                                int hour;
                                bool par = int.TryParse(textBox5.Text, out hour);
                                if (hour>0)
                                {
                                    courselist.Add(new Course(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, hour));
                                    lblError.Text = "";
                                }
                                else
                                {
                                    lblError.Text = "Number of hour should be an interger that greater than 0. ";
                                }
                            }
                            else
                            {
                                lblError.Text = "Day should be matched one of the below words" + "\n" + "('Monday', 'Tuesday', Wednesday', 'Thursday', 'Friday')";
                            }
                        }
                    }
                }
                else
                {
                    lblError.Text = "User input required";
                }
                this.textboxClear();
           // }
           // catch (Exception ex)
            //{
             //   lblError.Text=ex.Message;
           // }
            
        }

        //display objects of arraylist in the listbox
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lbxStudent.Items.Clear();
            lbxFaculty.Items.Clear();
            lbxCourse.Items.Clear();
            if (studentlist.Count == 0 && facultylist.Count == 0 && courselist.Count == 0) //check if the studentlist, facultylist and courselist is/are empty
            {
                lblError.Text = "Nothing to display";
            }
            else if (studentlist.Count == 0 && facultylist.Count == 0)
            {
                lblError.Text = "There is no student and faculty information to display";
            }
            else if (studentlist.Count == 0 && courselist.Count == 0)
            {
                lblError.Text = "There is no student and course information to display";
            }
            else if(facultylist.Count == 0 && courselist.Count == 0)
            {
                lblError.Text = "There is no faculty and course information to display";
            }
            else if (studentlist.Count == 0)
            {
                lblError.Text = "There is no Student information to display";
            }
            else if (facultylist.Count == 0)
            {
                lblError.Text = "There is no faculty information to display";
            }
            else if (courselist.Count == 0)
            {
                lblError.Text = "There is no course information to display";
            }
            else
            {
                lblError.Text = "";
            }
            foreach (Student s in studentlist) //Student
            {
                lbxStudent.Items.Add("ID: " + s.StudentID + "  |  Name: " + s.FirstName +" "+ s.LastName + "  |  Gender: " + s.Gender + "  |  Department: " + s.Department);
            }
            foreach (Faculty f in facultylist) //Faculty
            {
                lbxFaculty.Items.Add("ID: " + f.FacultyID + "  |  Name: " + f.FirstName + " " + f.LastName + "  |  Gender: " + f.Gender + "  |  Department: " + f.Department);
            }
            foreach (Course c in courselist) //Course
            {
                lbxCourse.Items.Add("Name: " + c.CourseName + "  |  Code: " + c.CourseCode + "  |  Location: " + c.CourseLocation + "  |  Day: " + c.CourseDay + "  |  Hours: " + c.CourseTime);
            }
            this.textboxClear();
        }

        //remove object of arraylist from a selected item of listbox
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i1 = lbxStudent.SelectedIndex; //Student
            if (i1 >= 0)
            {
                lbxStudent.Items.RemoveAt(i1);
                studentlist.RemoveAt(i1);
            }

            int i2 = lbxFaculty.SelectedIndex; //Faculty
            if (i2 >= 0)
            {
                lbxFaculty.Items.RemoveAt(i2);
                facultylist.RemoveAt(i2);
            }

            int i3 = lbxCourse.SelectedIndex; //Course
            if (i3 >= 0)
            {
                lbxCourse.Items.RemoveAt(i3);
                courselist.RemoveAt(i3);
            }
            lblError.Text = "";
            this.textboxClear();
        }

        //Clear the arraylist
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (studentlist.Count == 0 && facultylist.Count == 0 && courselist.Count == 0) //check if the arraylist(s) is/are empty
            {
                lblError.Text = "Nothing to clear";
            }
            else if (studentlist.Count == 0 && facultylist.Count == 0)
            {
                lblError.Text = "There is no student and faculty information to clear";
                courselist.Clear();
            }
            else if (studentlist.Count == 0 && courselist.Count == 0)
            {
                lblError.Text = "There is no student and course information to clear";
                facultylist.Clear();
            }
            else if (facultylist.Count == 0 && courselist.Count == 0)
            {
                lblError.Text = "There is no faculty and course information to clear";
                studentlist.Clear();
            }
            else if (studentlist.Count == 0)
            {
                lblError.Text = "There is no Student information to clear";
                facultylist.Clear();
                courselist.Clear();

            }
            else if (facultylist.Count == 0)
            {
                lblError.Text = "There is no faculty information to clear";
                studentlist.Clear();
                courselist.Clear();

            }
            else if (courselist.Count == 0)
            {
                lblError.Text = "There is no course information to clear";
                studentlist.Clear();
                facultylist.Clear();
            }
            else
            {
                lblError.Text = "";
                studentlist.Clear();
                facultylist.Clear();
                courselist.Clear();
            }
            this.textboxClear();
        }

        //clear the textboxes
        private void textboxClear() 
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private bool IsInt(TextBox textBox)
        {
            int num;
            if (int.TryParse(textBox.Text, out num))
            {
                return true;
            }
            else
            {
                lblError.Text="Product total should be an Integer, Error";
                return false;
            }
        }
    }
}