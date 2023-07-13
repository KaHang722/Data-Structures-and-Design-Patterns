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
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class Form4 : Form
    {
        private Form3 form3;
        private ArrayList facultylist;
        private ArrayList studentlist;
        private ArrayList courselist;
        private Dictionary<string, int> dict;
        private Dictionary<int, List<string>> dict2;



        public Form4(Form2 form2, Form3 form3, ArrayList _facultylist, ArrayList _studentlist, ArrayList _courselist, Dictionary<string, int> _dict, Dictionary<int, List<string>> _dict2)
        {
            InitializeComponent();
            this.form3 = form3;
            this.facultylist = _facultylist;
            this.studentlist = _studentlist;
            this.courselist = _courselist;
            this.dict = form2.dict;
            this.dict2 = form3.dict2;

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lbxSummary.Items.Clear();
            if (txtCourseName.Text != "")
            {
                if (dict.ContainsKey(txtCourseName.Text))
                {
                    lbxSummary.Items.Add("Course Name: " + txtCourseName.Text + " | Assigned Faculty ID: " + dict[txtCourseName.Text]);
                }

                else
                    lbxSummary.Items.Add("No faculty assigned yet for course " + txtCourseName.Text);


                lbxSummary.Items.Add("Assigned Faculty ID: ");



                foreach (Student student in studentlist)
                {
                    if (dict2[student.StudentID].Contains(txtCourseName.Text))
                    {
                        var key = from KeyValuePair<int, List<string>> x in dict2
                                  where x.Key == student.StudentID
                                  select x.Key;
                        foreach (var keys in key)

                        lbxSummary.Items.Add(keys);


                    }

                    /*
                    var studentAssigned = from KeyValuePair<int, List<string>> x in dict2
                                          where dict2[student.StudentID].Contains(txtCourseName.Text)
                                          select x;



                    foreach (KeyValuePair<int, List<string>> a in studentAssigned.Distinct())



                        if (dict2.ContainsKey(a.Key))
                        {
                            lbxSummary.Items.Add(a.Key);
                    */
                }
            }



            else { 
                lbxSummary.Items.Add("No students assigned yet for course " + txtCourseName.Text);
                }
            }
        }
    }



