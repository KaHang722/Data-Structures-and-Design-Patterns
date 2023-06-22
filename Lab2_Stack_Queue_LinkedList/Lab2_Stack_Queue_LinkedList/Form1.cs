using Microsoft.VisualBasic.Devices;

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

        private void btnPush_Click(object sender, EventArgs e)
        {
            courseStack.Push(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            courseStack.Pop();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            foreach(Course course in courseStack) 
            {
                lbxOutput.Items.Add(course.CourseName + "--" + course.Score);
            }
        }

        private void btnEnQueue_Click(object sender, EventArgs e)
        {
            courseQueue.Enqueue(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
        }

        private void btnDeQueue_Click(object sender, EventArgs e)
        {
            courseQueue.Dequeue();
        }

        private void btnDisplayQueue_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            foreach (Course c in courseQueue)
            {
                lbxOutput.Items.Add(c.CourseName + "--" + c.Score);
            }
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            courseList.AddLast(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //courseList.Remove(//find the object you want to remove);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LinkedListNode<Course> result = courseList.Find(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
            lbxOutput.Items.Clear();
            lbxOutput.Items.Add(result.Value.CourseName + "--" + result.Value.Score);
        }

        private void btnDisplayLL_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            foreach(Course c in courseList)
            {
                lbxOutput.Items.Add(c.CourseName + "--" + c.Score);
            }
        }
    }
}