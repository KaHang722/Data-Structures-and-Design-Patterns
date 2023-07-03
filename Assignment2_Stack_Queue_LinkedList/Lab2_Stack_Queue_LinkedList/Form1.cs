using Microsoft.VisualBasic.Devices;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace Lab2_Stack_Queue_LinkedList
{
    public partial class Form1 : Form
    {
        Stack<Course> courseStack;
        Queue<Course> courseQueue;
        LinkedList<Course> courseList;

        public Form1()
        {
            InitializeComponent();
            courseStack = new Stack<Course>();
            courseQueue = new Queue<Course>();
            courseList = new LinkedList<Course>();
        }

        //Stack
        private void btnPush_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text!="" && txtScore.Text!="")
            {
                courseStack.Push(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
            }
            lblError.Text = "";
            txtCourseName.Clear();
            txtScore.Clear();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (courseStack.Count != 0)
            {
                courseStack.Pop();
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Error. The stack is empty.";
                lbxOutput.Items.Clear();
            }
            txtCourseName.Clear();
            txtScore.Clear();
        }
        

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseStack.Count == 0)
            {
                lblError.Text = "Error. The stack is empty.";
            }
            else 
            {
                lblError.Text = "";
            }
            foreach (Course course in courseStack)
            {
                lbxOutput.Items.Add(course.CourseName + "--" + course.Score);
            }
            txtCourseName.Clear();
            txtScore.Clear();
        }
        private void btnPeek_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseStack.Count == 0)
            {
                lblError.Text = "Error. The stack is empty.";
            }
            else
            {
                lblError.Text = "";
                Course cS = courseStack.Peek();
                lbxOutput.Items.Add(cS.CourseName + "--" + cS.Score);
            }
            txtCourseName.Clear();
            txtScore.Clear();
        }

        //Queue
        private void btnEnQueue_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text != "" && txtScore.Text != "")
            {
                courseQueue.Enqueue(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
            }
            lblError.Text = "";
            txtCourseName.Clear();
            txtScore.Clear();
        }

        private void btnDeQueue_Click(object sender, EventArgs e)
        {
            if (courseQueue.Count != 0)
            {
                courseQueue.Dequeue();
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Error. The queue is empty.";
                lbxOutput.Items.Clear();
            }
            txtCourseName.Clear();
            txtScore.Clear();
        }

        private void btnDisplayQueue_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseQueue.Count == 0)
            {
                lblError.Text = "Error. The queue is empty.";
            }
            else
            {
                lblError.Text = "";
            }
            foreach (Course c in courseQueue)
            {
                lbxOutput.Items.Add(c.CourseName + "--" + c.Score);
            }
            txtCourseName.Clear();
            txtScore.Clear();
        }
        private void btnPeekQueue_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseQueue.Count == 0)
            {
                lblError.Text = "Error. The queue is empty.";
            }
            else
            {
                lblError.Text = "";
                Course cQ = courseQueue.Peek();
                lbxOutput.Items.Add(cQ.CourseName + "--" + cQ.Score);
            }
            txtCourseName.Clear();
            txtScore.Clear();
        }

        //LinkedList
        private void btnAddLast_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text != "" && txtScore.Text != "")
            {
                courseList.AddLast(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
            }
            lblError.Text = "";
            txtCourseName.Clear();
            txtScore.Clear();
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text != "" && txtScore.Text != "")
            {
                courseList.AddFirst(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
            }
            lblError.Text = "";
            txtCourseName.Clear();
            txtScore.Clear();
        }

        private void btnDisplayLL_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseList.Count == 0)
            {
                lblError.Text = "Error. The linkedlist is empty.";
            }
            else
            {
                lblError.Text = "";
            }
            foreach (Course c in courseList)
            {
                lbxOutput.Items.Add(c.CourseName + "--" + c.Score);
            }
            txtCourseName.Clear();
            txtScore.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text != "" && txtScore.Text !="")
            {
                if (courseList.Contains(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text))))
                {
                    courseList.Remove(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "Error. Course is not found to remove";
                    lbxOutput.Items.Clear();
                }
            }    
            txtCourseName.Clear();
            txtScore.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            LinkedListNode<Course> result = courseList.Find(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
            if (courseList.Contains(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text))))
            {
                
                lbxOutput.Items.Add(result.Value.CourseName + "--" + result.Value.Score);
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Error. Object is not found";
            }
            txtCourseName.Clear();
            txtScore.Clear();
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            if (courseList.Count != 0)
            {
                courseList.RemoveFirst();
            }
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (courseList.Count != 0)
            {
                courseList.RemoveLast();
            }
        }
    }
}