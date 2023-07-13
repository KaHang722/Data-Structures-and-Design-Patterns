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
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
        private ArrayList facultylist;
        private ArrayList courselist;
        private ArrayList studentlist;
        public Dictionary<string, int> dict { get; set; }





        public Form2(Form1 form1, ArrayList _facultylist, ArrayList _courselist, ArrayList _studentlist)
        {
            InitializeComponent();
            this.form1 = form1;
            this.facultylist = _facultylist;
            this.courselist = _courselist;
            this.studentlist = _studentlist;

            dict = new Dictionary<string, int>();
            form3 = new Form3(this, facultylist, studentlist, courselist);


        }


        private void btnMain_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (dict.Count <= 0)
                MessageBox.Show("No available Course-to-Faculty assignments to display. Please update the system.");

            else
            {
                foreach (KeyValuePair<string, int> kvp in dict)
                {
                    listBox1.Items.Add("Course Name: " + kvp.Key + " | " + "Faculty ID: " + kvp.Value);
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (txtFacultyID.Text == "" || txtCourseName.Text == "")
            {
                MessageBox.Show("Faculty ID and Course Name fields are required. Please provide the correct entry for each field before clicking Assign.");
            }

            else
            {
                try
                {
                    var f = from Faculty x in facultylist
                            where x.FacultyID == Int32.Parse(txtFacultyID.Text)
                            select x;

                    if (f.ToArray().Count() <= 0)
                        MessageBox.Show("Faculty ID " + txtFacultyID.Text + " not found in the system. Please refer to the list of Faculty Members in the Main page.");

                    else
                    {
                        var c = from Course x in courselist
                                where x.CourseName == txtCourseName.Text
                                select x;

                        if (c.ToArray().Count() <= 0)
                            MessageBox.Show("Course Name " + txtCourseName.Text + " not found in the system. Please refer to the list of Courses in the Main page.");

                        else
                        {
                            if (dict.ContainsKey(txtCourseName.Text))
                                MessageBox.Show("Course " + txtCourseName.Text + " has already been assigned to a faculty member. Please unassign the existing course if necessary then assign to a new faculty member.");

                            else
                            {
                                dict.Add(txtCourseName.Text, Int32.Parse(txtFacultyID.Text));
                                MessageBox.Show("Faculty ID " + txtFacultyID.Text + " has been assigned to course " + txtCourseName.Text + ".\nPlease click the Display button to update the Course-to-Faculty assignment list.");
                                txtCourseName.Clear();
                                txtFacultyID.Clear();
                            }
                        }
                    }

                }

                catch (FormatException fe)
                {
                    MessageBox.Show("Input for Faculty ID should be in number format.");
                }

            }


        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
                MessageBox.Show("There is no selected record to be unassigned.");

            else
            {
                var c = from KeyValuePair<string, int> kvp in dict
                        where ("Course Name: " + kvp.Key + " | " + "Faculty ID: " + kvp.Value) == listBox1.SelectedItem.ToString()
                        select kvp;

                foreach (KeyValuePair<string, int> kvp in c)
                {
                    MessageBox.Show(kvp.Key.ToString() + " will now be unassigned. Please click Display button to update the Course-to-Faculty assignment list.");
                    dict.Remove(kvp.Key);
                }


            }
        }
    }


}
