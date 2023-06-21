namespace Lab1_ArrayList_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArrayList = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.txtArrayList = new System.Windows.Forms.TextBox();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnAddArrayList = new System.Windows.Forms.Button();
            this.btnRemoveArrayList = new System.Windows.Forms.Button();
            this.btnDisplayArrayList = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnRemoveList = new System.Windows.Forms.Button();
            this.btnDisplayList = new System.Windows.Forms.Button();
            this.lbxArrayList = new System.Windows.Forms.ListBox();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblArrayList
            // 
            this.lblArrayList.AutoSize = true;
            this.lblArrayList.Location = new System.Drawing.Point(157, 62);
            this.lblArrayList.Name = "lblArrayList";
            this.lblArrayList.Size = new System.Drawing.Size(139, 15);
            this.lblArrayList.TabIndex = 0;
            this.lblArrayList.Text = "ArrayList - List of courses";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(157, 219);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(115, 15);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "List - Score obtained";
            // 
            // txtArrayList
            // 
            this.txtArrayList.Location = new System.Drawing.Point(157, 101);
            this.txtArrayList.Name = "txtArrayList";
            this.txtArrayList.Size = new System.Drawing.Size(100, 23);
            this.txtArrayList.TabIndex = 2;
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(157, 263);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(100, 23);
            this.txtList.TabIndex = 3;
            // 
            // btnAddArrayList
            // 
            this.btnAddArrayList.Location = new System.Drawing.Point(104, 151);
            this.btnAddArrayList.Name = "btnAddArrayList";
            this.btnAddArrayList.Size = new System.Drawing.Size(75, 23);
            this.btnAddArrayList.TabIndex = 4;
            this.btnAddArrayList.Text = "Add";
            this.btnAddArrayList.UseVisualStyleBackColor = true;
            this.btnAddArrayList.Click += new System.EventHandler(this.btnAddArrayList_Click);
            // 
            // btnRemoveArrayList
            // 
            this.btnRemoveArrayList.Location = new System.Drawing.Point(201, 151);
            this.btnRemoveArrayList.Name = "btnRemoveArrayList";
            this.btnRemoveArrayList.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveArrayList.TabIndex = 5;
            this.btnRemoveArrayList.Text = "Remove";
            this.btnRemoveArrayList.UseVisualStyleBackColor = true;
            this.btnRemoveArrayList.Click += new System.EventHandler(this.btnRemoveArrayList_Click);
            // 
            // btnDisplayArrayList
            // 
            this.btnDisplayArrayList.Location = new System.Drawing.Point(302, 151);
            this.btnDisplayArrayList.Name = "btnDisplayArrayList";
            this.btnDisplayArrayList.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayArrayList.TabIndex = 6;
            this.btnDisplayArrayList.Text = "Display";
            this.btnDisplayArrayList.UseVisualStyleBackColor = true;
            this.btnDisplayArrayList.Click += new System.EventHandler(this.btnDisplayArrayList_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(104, 316);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(75, 23);
            this.btnAddList.TabIndex = 7;
            this.btnAddList.Text = "Add";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.Location = new System.Drawing.Point(201, 316);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveList.TabIndex = 8;
            this.btnRemoveList.Text = "Remove";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            this.btnRemoveList.Click += new System.EventHandler(this.btnRemoveList_Click);
            // 
            // btnDisplayList
            // 
            this.btnDisplayList.Location = new System.Drawing.Point(302, 316);
            this.btnDisplayList.Name = "btnDisplayList";
            this.btnDisplayList.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayList.TabIndex = 9;
            this.btnDisplayList.Text = "Display";
            this.btnDisplayList.UseVisualStyleBackColor = true;
            this.btnDisplayList.Click += new System.EventHandler(this.btnDisplayList_Click);
            // 
            // lbxArrayList
            // 
            this.lbxArrayList.FormattingEnabled = true;
            this.lbxArrayList.ItemHeight = 15;
            this.lbxArrayList.Location = new System.Drawing.Point(517, 62);
            this.lbxArrayList.Name = "lbxArrayList";
            this.lbxArrayList.Size = new System.Drawing.Size(120, 94);
            this.lbxArrayList.TabIndex = 10;
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 15;
            this.lbxList.Location = new System.Drawing.Point(517, 219);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(120, 94);
            this.lbxList.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.lbxArrayList);
            this.Controls.Add(this.btnDisplayList);
            this.Controls.Add(this.btnRemoveList);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.btnDisplayArrayList);
            this.Controls.Add(this.btnRemoveArrayList);
            this.Controls.Add(this.btnAddArrayList);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.txtArrayList);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblArrayList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblArrayList;
        private Label lblList;
        private TextBox txtArrayList;
        private TextBox txtList;
        private Button btnAddArrayList;
        private Button btnRemoveArrayList;
        private Button btnDisplayArrayList;
        private Button btnAddList;
        private Button btnRemoveList;
        private Button btnDisplayList;
        private ListBox lbxArrayList;
        private ListBox lbxList;
    }
}