using Assignment3;
using System;
using System.Collections;
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

namespace Lab3_HTandDict
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
        HashSet<string> hset1;
        HashSet<string> hset2;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form3 = new Form3(this);
            hset1 = new HashSet<string>();
            hset2 = new HashSet<string>();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                hset1.Add(textBox1.Text);
            }
            lblresult.Text = "result";
            lblError.Text = "";
            lblError2.Text = "";
            textBox1.Clear();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (hset1.Contains(textBox1.Text))
                {
                    hset1.Remove(textBox1.Text);
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "Error. The object is not found.";
                }
            }
            textBox1.Clear();
            lblError2.Text = "";
            lblresult.Text = "result";
            
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                hset2.Add(textBox1.Text);
            }
            lblresult.Text = "result";
            lblError.Text = "";
            lblError2.Text = "";
            textBox1.Clear();
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (hset2.Contains(textBox1.Text))
                {
                    hset2.Remove(textBox1.Text);
                    lblError2.Text = "";
                }
                else
                {
                    lblError2.Text = "Error. The object is not found.";
                }
            }
            textBox1.Clear();
            lblError.Text = "";
            lblresult.Text = "result";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            hs1.Items.Clear();
            hs2.Items.Clear();

            if (hset1.Count != 0)
            {
                foreach (string item in hset1)
                {
                    hs1.Items.Add(item);
                    lblError.Text = "";
                }
            }
            else
            {
                lblError.Text = "Error. The hashset 1 is empty.";
            }

            if (hset2.Count != 0)
            {
                foreach (string item in hset2)
                {
                    hs2.Items.Add(item);
                    lblError2.Text = "";
                }
            }
            else
            {
                lblError2.Text = "Error. The hashset 2 is empty.";
            }
            textBox1.Clear();
            lblresult.Text = "result";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (hset1.Count != 0)
            {
                hset1.Clear();
            }
            else
            {
                lblError.Text= "Error. The hashset 1 is empty.";
            }
            
            if(hset2.Count != 0)
            {
                hset2.Clear();
            }
            else
            {
                lblError2.Text = "Error. The hashset 2 is empty.";
            }
            textBox1.Clear();
            lblresult.Text = "result";
        }

        private void btnIntersection_Click(object sender, EventArgs e)
        {
            if (hset1.Count == 0 && hset2.Count == 0)
            {
                lblError.Text = "Error. The hashset 1 is empty";
                hs1.Items.Clear();
                lblError2.Text = "Error. The hashset 2 is empty";
                hs2.Items.Clear();
            }
            else if (hset1.Count == 0)
            {
                lblError.Text = "Error. The hashset 1 is empty";
                hs1.Items.Clear();
                lblError2.Text = "";
            }
            else if (hset2.Count == 0)
            {
                lblError2.Text = "Error. The hashset 2 is empty";
                hs2.Items.Clear();
                lblError.Text = "";
            }
            else
            {
                hset1.IntersectWith(hset2);
                lblError.Text = "";
                lblError2.Text = "";

            }
            textBox1.Clear();
            lblresult.Text = "result";
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            if (hset1.Count == 0 && hset2.Count == 0)
            {
                lblError.Text = "Error. The hashset 1 is empty";
                hs1.Items.Clear();
                lblError2.Text = "Error. The hashset 2 is empty";
                hs2.Items.Clear();
            }
            else if (hset1.Count == 0)
            {
                lblError.Text = "Error. The hashset 1 is empty";
                hs1.Items.Clear();
                lblError2.Text = "";
            }
            else if (hset2.Count == 0)
            {
                lblError2.Text = "Error. The hashset 2 is empty";
                hs2.Items.Clear();
                lblError.Text = "";
            }
            else
            {
                hset1.UnionWith(hset2);
                lblError.Text = "";
                lblError2.Text = "";

            }
            lblresult.Text = "result";
            textBox1.Clear();
        }

        private void btnSubset_Click(object sender, EventArgs e)
        {
            if (hset1.Count == 0 && hset2.Count == 0)
            {
                lblError.Text = "Error. The hashset 1 is empty";
                hs1.Items.Clear();
                lblError2.Text = "Error. The hashset 2 is empty";
                hs2.Items.Clear();
                lblresult.Text = "result";
            }
            else if(hset1.Count == 0)
            {
                lblError.Text = "Error. The hashset 1 is empty";
                lblresult.Text = "result";
                lblError2.Text = "";
                hs1.Items.Clear();
            }
            else if (hset2.Count == 0)
            {
                lblError2.Text = "Error. The hashset 2 is empty";
                lblresult.Text = "result"; 
                lblError.Text = "";
                hs2.Items.Clear();
            }
            else
            {
                lblresult.Text = hset1.IsSubsetOf(hset2).ToString();
                lblError.Text = "";
                lblError2.Text = "";
            }
            textBox1.Clear();
        }

        private void btnSuperset_Click(object sender, EventArgs e)
        {
            if (hset1.Count == 0 && hset2.Count == 0)
            {
                lblError.Text = "Error. The hashset 1 is empty";
                hs1.Items.Clear();
                lblError2.Text = "Error. The hashset 2 is empty";
                hs2.Items.Clear();
                lblresult.Text = "result";
            }
            else if (hset1.Count == 0)
            {
                lblError.Text = "Error. The hashset 1 is empty";
                lblresult.Text = "result";
                lblError2.Text = "";
                hs1.Items.Clear();
            }
            else if (hset2.Count == 0)
            {
                lblError2.Text = "Error. The hashset 2 is empty";
                lblresult.Text = "result";
                lblError.Text = "";
                hs2.Items.Clear();
            }
            else
            {
                lblresult.Text = hset1.IsSupersetOf(hset2).ToString();
                lblError.Text = "";
                lblError2.Text = "";
            }
            textBox1.Clear();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }
    }
}
