using System.Collections;

namespace Lab1_ArrayList_List
{
    public partial class Form1 : Form
    {
        private ArrayList arraylist = new ArrayList();
        private List<int> scorelist = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddArrayList_Click(object sender, EventArgs e)
        {
            if (txtArrayList.Text != "")
            {
                if(!arraylist.Contains(txtArrayList.Text))
                {
                    arraylist.Add(txtArrayList.Text);
                    lblMessageArrayList.Text = "";
                    
                }
                else
                {
                    lblMessageArrayList.Text = "Duplicate not allowed ";
                } 
            }else
            {
                lblMessageArrayList.Text = "User input required";
            }
            lblMessageList.Text = "";
            txtArrayList.Clear();
            txtList.Clear();
        }

        private void btnRemoveArrayList_Click(object sender, EventArgs e)
        {
            if (txtArrayList.Text != "")
            {
                if (arraylist.Contains(txtArrayList.Text))
                {
                    arraylist.Remove(txtArrayList.Text);
                    lblMessageArrayList.Text = "";
                    
                }
                else
                {
                    lblMessageArrayList.Text = "Course not found to remove";
                }
            }else
            {
                lblMessageArrayList.Text = "User input required";
            }
            lblMessageList.Text = "";
            txtArrayList.Clear();
            txtList.Clear();
        }

        private void btnDisplayArrayList_Click(object sender, EventArgs e)
        {
            lbxArrayList.Items.Clear();
            arraylist.Sort();
            if (arraylist.Count == 0)
            {
                lblMessageArrayList.Text = "Nothing to display";
            }else
            {
                lblMessageArrayList.Text = "";
            }
            foreach(string item in arraylist)
            {
                lbxArrayList.Items.Add(item);
            }
            lblMessageList.Text = "";
            txtArrayList.Clear();
            txtList.Clear();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if(txtList.Text != "")
            {
                if(!scorelist.Contains(Int32.Parse(txtList.Text)))
                {
                    scorelist.Add(Int32.Parse(txtList.Text));
                    lblMessageList.Text = "";
                }
                else
                {
                    lblMessageList.Text = "Duplicate not allowed";
                }
            }else
            {
                lblMessageList.Text = "User input required";
            }
            lblMessageArrayList.Text = "";
            txtList.Clear();
            txtArrayList.Clear();
        }

        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            if (txtList.Text != "")
            {
                if (scorelist.Contains(Int32.Parse(txtList.Text)))
                {
                    scorelist.Remove(Int32.Parse(txtList.Text));
                    lblMessageList.Text = "";
                }
                else
                {
                    lblMessageList.Text = "Item not found";
                }
            }
            else
            {
                lblMessageList.Text = "User input required";
            }
            lblMessageArrayList.Text = "";
            txtList.Clear();
            txtArrayList.Clear();

        }

        private void btnDisplayList_Click(object sender, EventArgs e)
        {
            lbxList.Items.Clear();
            scorelist.Sort();
            if (scorelist.Count == 0)
            {
                lblMessageList.Text = "Nothing to display";
            }else
            {
                lblMessageList.Text = "";
            }
            foreach (int item in scorelist)
            {
                lbxList.Items.Add(item);
            }
            lblMessageArrayList.Text = "";
            txtList.Clear();
            txtArrayList.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}