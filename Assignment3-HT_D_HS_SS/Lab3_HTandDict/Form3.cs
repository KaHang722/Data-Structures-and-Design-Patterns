using Lab3_HTandDict;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Assignment3
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        SortedSet<string> sset1;
        SortedSet<string> sset2;
        public Form3(Form2 form2)
    {
        InitializeComponent();
        sset1 = new SortedSet<string>();
        sset2 = new SortedSet<string>();
        this.form2 = form2;
    }

    private void btnForm2_Click(object sender, EventArgs e)
    {
        form2.Show();
        this.Hide();
    }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sset1.Add(textBox1.Text);
            }
            lblResult.Text = "result";
            lblError.Text = "";
            lblError2.Text = "";
            textBox1.Clear();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (sset1.Contains(textBox1.Text))
                {
                    sset1.Remove(textBox1.Text);
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "Error. The object is not found.";
                }
            }
            textBox1.Clear();
            lblError2.Text = "";
            lblResult.Text = "result";
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sset2.Add(textBox1.Text);
            }
            lblResult.Text = "result";
            lblError.Text = "";
            lblError2.Text = "";
            textBox1.Clear();
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (sset2.Contains(textBox1.Text))
                {
                    sset2.Remove(textBox1.Text);
                }
                else
                {
                    lblError2.Text = "Error. The object is not found.";
                }
            }
            textBox1.Clear();
            lblError.Text = "";
            lblResult.Text = "result";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ss1.Items.Clear();
            ss2.Items.Clear();

            if (sset1.Count != 0)
            {
                foreach (string item in sset1)
                {
                    ss1.Items.Add(item);
                    lblError.Text = "";
                }
            }
            else
            {
                lblError.Text = "Error. The sortedset 1 is empty.";
                ss1.Items.Clear();
            }

            if (sset2.Count != 0)
            {
                foreach (string item in sset2)
                {
                    ss2.Items.Add(item);
                    lblError2.Text = "";
                }
            }
            else
            {
                lblError2.Text = "Error. The sortedset 2 is empty.";
                ss2.Items.Clear();
            }
            textBox1.Clear();
            lblResult.Text = "result";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (sset1.Count != 0)
            {
                sset1.Clear();
            }
            else
            {
                lblError.Text = "Error. The sortedset 1 is empty.";
                ss1.Items.Clear();
            }

            if (sset2.Count != 0)
            {
                sset2.Clear();
            }
            else
            {
                lblError2.Text = "Error. The sortedset 2 is empty.";
                ss2.Items.Clear();
            }
            textBox1.Clear();
            lblResult.Text = "result";
        }

        private void btnIntersection_Click(object sender, EventArgs e)
        {
            if (sset1.Count == 0 && sset2.Count == 0)
            {
                lblError.Text = "Error. The sortedset 1 is empty";
                ss1.Items.Clear();
                lblError2.Text = "Error. The sortedset 2 is empty";
                ss2.Items.Clear();
            }
            else if(sset1.Count == 0)
            {
                lblError.Text = "Error. The sortedset 1 is empty";
                ss1.Items.Clear();
                lblError2.Text = "";
            }
            else if (sset2.Count == 0)
            {
                lblError2.Text = "Error. The sortedset 2 is empty";
                ss2.Items.Clear();
                lblError.Text = "";
            }
            else
            {
                sset1.IntersectWith(sset2);
                lblError.Text = "";
                lblError2.Text = "";

            }
            textBox1.Clear();
            lblResult.Text = "result";
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            if (sset1.Count == 0 && sset2.Count == 0)
            {
                lblError.Text = "Error. The sortedset 1 is empty";
                ss1.Items.Clear();
                lblError2.Text = "Error. The sortedset 2 is empty";
                ss2.Items.Clear();
                lblResult.Text = "result";
            }
            else if (sset1.Count == 0)
            {
                lblError.Text = "Error. The sortedset 1 is empty";
                ss1.Items.Clear();
                lblError2.Text = "";
            }
            else if (sset2.Count == 0)
            {
                lblError2.Text = "Error. The sortedset 2 is empty"; 
                ss2.Items.Clear();
                lblError.Text = "";
            }
            else
            {
                sset1.UnionWith(sset2);
                lblError.Text = "";
                lblError2.Text = "";

            }
            lblResult.Text = "result";
            textBox1.Clear();
        }

        private void btnSubset_Click(object sender, EventArgs e)
        {
            if (sset1.Count == 0 && sset2.Count == 0)
            {
                lblError.Text = "Error. The sortedset 1 is empty";
                ss1.Items.Clear();
                lblError2.Text = "Error. The sortedset 2 is empty";
                ss2.Items.Clear();
                lblResult.Text = "result";
            }
            else if (sset1.Count == 0)
            {
                lblError.Text = "Error. The sortedset 1 is empty";
                ss1.Items.Clear();
                lblError2.Text = "";
                lblResult.Text = "result";
            }
            else if (sset2.Count == 0)
            {
                lblError2.Text = "Error. The sortedset 2 is empty";
                ss2.Items.Clear();
                lblError.Text = "";
                lblResult.Text = "result";
            }
            else
            {
                lblResult.Text = sset1.IsSubsetOf(sset2).ToString();
                lblError.Text = "";
                lblError2.Text = "";
            }
            textBox1.Clear();
        }

        private void btnSuperSet_Click(object sender, EventArgs e)
        {
            if (sset1.Count == 0 && sset2.Count == 0)
            {
                lblError.Text = "Error. The sortedset 1 is empty";
                ss1.Items.Clear();
                lblError2.Text = "Error. The sortedset 2 is empty";
                ss2.Items.Clear();
                lblResult.Text = "result";
            }
            else if (sset1.Count == 0)
            {
                lblError.Text = "Error. The sortedset 1 is empty";
                ss1.Items.Clear();
                lblError2.Text = "";
                lblResult.Text = "result";
            }
            else if (sset2.Count == 0)
            {
                lblError2.Text = "Error. The sortedset 2 is empty";
                ss2.Items.Clear();
                lblError.Text = "";
                lblResult.Text = "result";
            }
            else
            {
                lblResult.Text = sset1.IsSupersetOf(sset2).ToString();
                lblError.Text = "";
                lblError2.Text = "";
            }
            textBox1.Clear();
        }
    }
}
