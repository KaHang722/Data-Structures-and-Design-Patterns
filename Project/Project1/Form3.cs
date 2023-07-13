using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        private Form4 form4;
        private ArrayList facultylist;
        private ArrayList studentlist;
        private ArrayList courselist;
        public Dictionary<string, int> dict { get; set; }
        public Dictionary<int, List<string>> dict2 { get; set; }

        public Form3(Form2 form2, ArrayList _facultylist, ArrayList _studentlist, ArrayList _courselist)
        {
            InitializeComponent();
            this.form2 = form2;
            this.facultylist = _facultylist;
            this.studentlist = _studentlist;
            this.courselist = _courselist;
            dict2 = new Dictionary<int, List<string>>();
            form4 = new Form4(form2, this, facultylist, studentlist, courselist, dict, this.dict2);
            
        }
        //switching to form2 (Faculty)
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }
        //switching to form4 (Summary)
        private void btnSummary_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Hide();
        }
        //assign the course
        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCourseName.Text != "" && txtStudentID.Text != "") //if input fields not empty
                {
                        var studentselected = from Student s in studentlist
                                              where s.StudentID == Int32.Parse(txtStudentID.Text)
                                              select s;
                        if (studentselected.ToArray().Count() <= 0)
                        {
                            MessageBox.Show("Error, Cannot found the student id");
                        }
                            
                        var courseSelected = from Course c in courselist
                                             where c.CourseName == txtCourseName.Text
                                             select c;
                        if (courseSelected.ToArray().Count() <= 0)
                        {
                            MessageBox.Show("Error, Cannot found the student id");
                        }

                        foreach (Course c in courseSelected)
                        foreach (Student s in studentselected)
                        {
                            List <string> list = new List<string>();
                            if (!(dict2.ContainsKey(s.StudentID)))
                            {
                                dict2.Add(s.StudentID, list);
                                dict2[s.StudentID].Add(c.CourseName);
                                dict2[s.StudentID].Sort();
                            }
                            else
                            {
                                    if (dict2[s.StudentID].Contains(c.CourseName))
                                    {
                                        MessageBox.Show("Error. The course is already added");
                                    }
                                    else
                                    {
                                        dict2[s.StudentID].Add(c.CourseName);
                                        dict2[s.StudentID].Sort();
                                    }
                            }
                        }                       
                }else if (txtCourseName.Text == "" || txtStudentID.Text == "")
                {
                    MessageBox.Show("Error. Input field(s) cannot be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.textboxClear();
        }
        //Display the record
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

                for (int i=0; i<dict2.Count; i++)
                {
                    listBox1.Items.Add("Student ID: " + dict2.Keys.ElementAt(i) + " -  Course(s): " + String.Join(", ", dict2.Values.ElementAt(i).ToArray()));
                }
            this.textboxClear();
        }
        //Remove the record
        private void btnUnassign_Click(object sender, EventArgs e)
        {
            int i1 = listBox1.SelectedIndex;
            if (i1 >= 0)
            {
                listBox1.Items.RemoveAt(i1);
                dict2.Remove(dict2.Keys.ElementAt(i1));
            }
            this.textboxClear();
        }
        //Clear all the textbox
        private void textboxClear()
        {
            txtCourseName.Clear();
            txtStudentID.Clear();
        }
        //unassign the course
        private void btnUnassignCourse_Click(object sender, EventArgs e)
        {
            if (dict2.ContainsKey(Int32.Parse(txtStudentID.Text)))
            {
                if (dict2[Int32.Parse(txtStudentID.Text)].Contains(txtCourseName.Text))
                {
                    dict2[Int32.Parse(txtStudentID.Text)].Remove(txtCourseName.Text);
                }
                else
                {
                    MessageBox.Show("Error. Course not found");
                }   
            }
            else
            {
                MessageBox.Show("Error. Record not found.");
            }
        }
    }
    }

