using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_HTandDict
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        HashSet<string> hset1;
        HashSet<string> hset2;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
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
            hset1.Add(textBox1.Text);
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            hset1.Remove(textBox1.Text);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            hset2.Add(textBox1.Text);
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            hset2.Remove(textBox1.Text);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            hs1.Items.Clear();
            hs2.Items.Clear();

            foreach(string item in hset1)
            {
                hs1.Items.Add(item);
            }

            foreach (string item in hset2)
            {
                hs2.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            hset1.Clear();
            hset2.Clear();
        }

        private void btnIntersection_Click(object sender, EventArgs e)
        {
            hset1.IntersectWith(hset2);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            hset1.UnionWith(hset2);
        }

        private void btnSubset_Click(object sender, EventArgs e)
        {
            lblresult.Text = hset1.IsSubsetOf(hset2).ToString();
        }

        private void btnSuperset_Click(object sender, EventArgs e)
        {
            lblresult.Text = hset1.IsSupersetOf(hset2).ToString();
        }
    }
}
