using System.Collections;

namespace Lab3_HTandDict
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Hashtable hashtable;
        private Dictionary<int, string> dict;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this); 
            hashtable = new Hashtable();
            dict = new Dictionary<int, string>();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btnHtAdd_Click(object sender, EventArgs e)
        {
            hashtable.Add(txtKey.Text, txtValue.Text);
        }

        private void btnHtRemove_Click(object sender, EventArgs e)
        {
            hashtable.Remove(txtKey.Text);
        }

        private void btnHtDisplay_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            foreach(DictionaryEntry de in hashtable)
            {
                lbxDisplay.Items.Add(de.Key + " - " + de.Value);
            }
        }

        private void btnDictAdd_Click(object sender, EventArgs e)
        {
            dict.Add(Int32.Parse(txtKey.Text), txtValue.Text);
        }

        private void btnDictRemove_Click(object sender, EventArgs e)
        {
            dict.Remove(Int32.Parse(txtKey.Text));
        }

        private void btnDictDisplay_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                lbxDisplay.Items.Add(kvp.Key + " - " + kvp.Value);
            }
        }
    }
}