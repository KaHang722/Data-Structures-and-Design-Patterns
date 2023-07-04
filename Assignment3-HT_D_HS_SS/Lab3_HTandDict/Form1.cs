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
            if (txtKey.Text != "" && txtValue.Text != "")
            {
                if (hashtable.ContainsKey(txtKey.Text))
                {
                    lblError.Text = "Error. The key is duplicated.";  
                }
                else
                {
                    hashtable.Add(txtKey.Text, txtValue.Text);
                    lblError.Text = "";
                }
            }
            txtKey.Clear();
            txtValue.Clear();
            lblCheckValue.Text = "Button \"Check Value\" result";
        }

        private void btnHtRemove_Click(object sender, EventArgs e)
        {
            if (txtKey.Text != "")
            {
                if (hashtable.ContainsKey(txtKey.Text))
                {
                    hashtable.Remove(txtKey.Text);
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "Error. The key is not found.";
                }
            }
            txtKey.Clear();
            txtValue.Clear();
            lblCheckValue.Text = "Button \"Check Value\" result";
        }

        private void btnHtDisplay_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            foreach(DictionaryEntry de in hashtable)
            {
                lbxDisplay.Items.Add(de.Key + " - " + de.Value);
            }
            lblCheckValue.Text = "Button \"Check Value\" result";
            txtKey.Clear();
            txtValue.Clear();
            lblError.Text = "";
        }

        private void btnHtClear_Click(object sender, EventArgs e)
        {
            if (hashtable.Count != 0)
            {
                hashtable.Clear();
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Error. Hashtable is already empty.";
            }
            lblCheckValue.Text = "Button \"Check Value\" result";
            txtKey.Clear();
            txtValue.Clear();
        }

        private void btnHtvalue_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            foreach (DictionaryEntry de in hashtable)
            {
                lbxDisplay.Items.Add(de.Value);
            }
            lblCheckValue.Text = "Button \"Check Value\" result";
            txtKey.Clear();
            txtValue.Clear();
            lblError.Text = "";
        }

        private void btnDictAdd_Click(object sender, EventArgs e)
        {
            if (txtKey.Text != "" && txtValue.Text != "")
            {
                if (dict.ContainsKey(Int32.Parse(txtKey.Text)))
                {
                    lblError.Text = "Error. The key is duplicated";
                }
                else
                {
                    dict.Add(Int32.Parse(txtKey.Text), txtValue.Text);
                    lblError.Text = "";
                }
            }
            txtKey.Clear();
            txtValue.Clear();
            lblCheckValue.Text = "Button \"Check Value\" result";
        }

        private void btnDictRemove_Click(object sender, EventArgs e)
        {
            if(dict.ContainsKey(Int32.Parse(txtKey.Text)))
            {
                dict.Remove(Int32.Parse(txtKey.Text));
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Error. The key is not found.";
            }
            txtKey.Clear();
            txtValue.Clear();
            lblCheckValue.Text = "Button \"Check Value\" result";
        }

        private void btnDictDisplay_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            foreach(KeyValuePair<int, string> kvp in dict)
            {
                lbxDisplay.Items.Add(kvp.Key + " - " + kvp.Value);
            }
            lblCheckValue.Text = "Button \"Check Value\" result";
            txtKey.Clear();
            txtValue.Clear();
            lblError.Text = "";
        }

        private void btnDictClear_Click(object sender, EventArgs e)
        {
            if (dict.Count != 0)
            {
                dict.Clear();
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Error. Dictionary  is already empty.";
            }
            lblCheckValue.Text = "Button \"Check Value\" result";
            txtKey.Clear();
            txtValue.Clear();
        }

        private void btnDictCheckValue_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            
            if (txtValue.Text !="")
            {
                if (dict.ContainsValue(txtValue.Text))
                {
                    var dKey = dict.FirstOrDefault(x => x.Value == txtValue.Text).Key;
                    lblCheckValue.Text= dKey + " - " +txtValue.Text;
                }
                else
                {
                    lblCheckValue.Text = "Not found";
                }
            }
            lblError.Text = "";
            txtValue.Clear();
            txtKey.Clear();
        }
    }
}