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
            arraylist.Add(txtArrayList.Text);
        }

        private void btnRemoveArrayList_Click(object sender, EventArgs e)
        {
            arraylist.Remove(txtArrayList.Text);
        }

        private void btnDisplayArrayList_Click(object sender, EventArgs e)
        {
            lbxArrayList.Items.Clear();
            foreach(string item in arraylist)
            {
                lbxArrayList.Items.Add(item);
            }
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            scorelist.Add(Int32.Parse(txtList.Text));
        }

        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            scorelist.Remove(Int32.Parse(txtList.Text));
        }

        private void btnDisplayList_Click(object sender, EventArgs e)
        {
            lbxList.Items.Clear();
            foreach (int item in scorelist)
            {
                lbxList.Items.Add(item);
            }
        }
    }
}