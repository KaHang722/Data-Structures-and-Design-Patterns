namespace Lab3_HTandDict
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lbxDisplay = new System.Windows.Forms.ListBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblHashtable = new System.Windows.Forms.Label();
            this.Dictionary = new System.Windows.Forms.Label();
            this.btnHtAdd = new System.Windows.Forms.Button();
            this.btnHtRemove = new System.Windows.Forms.Button();
            this.btnHtDisplay = new System.Windows.Forms.Button();
            this.btnDictAdd = new System.Windows.Forms.Button();
            this.btnDictRemove = new System.Windows.Forms.Button();
            this.btnDictDisplay = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(68, 45);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(110, 23);
            this.txtKey.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(240, 45);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(110, 23);
            this.txtValue.TabIndex = 1;
            // 
            // lbxDisplay
            // 
            this.lbxDisplay.FormattingEnabled = true;
            this.lbxDisplay.ItemHeight = 15;
            this.lbxDisplay.Location = new System.Drawing.Point(493, 45);
            this.lbxDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxDisplay.Name = "lbxDisplay";
            this.lbxDisplay.Size = new System.Drawing.Size(172, 169);
            this.lbxDisplay.TabIndex = 2;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(68, 19);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(26, 15);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "Key";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(240, 19);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(35, 15);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // lblHashtable
            // 
            this.lblHashtable.AutoSize = true;
            this.lblHashtable.Location = new System.Drawing.Point(68, 129);
            this.lblHashtable.Name = "lblHashtable";
            this.lblHashtable.Size = new System.Drawing.Size(60, 15);
            this.lblHashtable.TabIndex = 5;
            this.lblHashtable.Text = "Hashtable";
            // 
            // Dictionary
            // 
            this.Dictionary.AutoSize = true;
            this.Dictionary.Location = new System.Drawing.Point(68, 239);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(61, 15);
            this.Dictionary.TabIndex = 6;
            this.Dictionary.Text = "Dictionary";
            // 
            // btnHtAdd
            // 
            this.btnHtAdd.Location = new System.Drawing.Point(68, 174);
            this.btnHtAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHtAdd.Name = "btnHtAdd";
            this.btnHtAdd.Size = new System.Drawing.Size(82, 22);
            this.btnHtAdd.TabIndex = 7;
            this.btnHtAdd.Text = "Add";
            this.btnHtAdd.UseVisualStyleBackColor = true;
            this.btnHtAdd.Click += new System.EventHandler(this.btnHtAdd_Click);
            // 
            // btnHtRemove
            // 
            this.btnHtRemove.Location = new System.Drawing.Point(201, 174);
            this.btnHtRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHtRemove.Name = "btnHtRemove";
            this.btnHtRemove.Size = new System.Drawing.Size(82, 22);
            this.btnHtRemove.TabIndex = 8;
            this.btnHtRemove.Text = "Remove";
            this.btnHtRemove.UseVisualStyleBackColor = true;
            this.btnHtRemove.Click += new System.EventHandler(this.btnHtRemove_Click);
            // 
            // btnHtDisplay
            // 
            this.btnHtDisplay.Location = new System.Drawing.Point(332, 174);
            this.btnHtDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHtDisplay.Name = "btnHtDisplay";
            this.btnHtDisplay.Size = new System.Drawing.Size(82, 22);
            this.btnHtDisplay.TabIndex = 9;
            this.btnHtDisplay.Text = "Display";
            this.btnHtDisplay.UseVisualStyleBackColor = true;
            this.btnHtDisplay.Click += new System.EventHandler(this.btnHtDisplay_Click);
            // 
            // btnDictAdd
            // 
            this.btnDictAdd.Location = new System.Drawing.Point(68, 287);
            this.btnDictAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDictAdd.Name = "btnDictAdd";
            this.btnDictAdd.Size = new System.Drawing.Size(82, 22);
            this.btnDictAdd.TabIndex = 10;
            this.btnDictAdd.Text = "Add";
            this.btnDictAdd.UseVisualStyleBackColor = true;
            this.btnDictAdd.Click += new System.EventHandler(this.btnDictAdd_Click);
            // 
            // btnDictRemove
            // 
            this.btnDictRemove.Location = new System.Drawing.Point(201, 287);
            this.btnDictRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDictRemove.Name = "btnDictRemove";
            this.btnDictRemove.Size = new System.Drawing.Size(82, 22);
            this.btnDictRemove.TabIndex = 11;
            this.btnDictRemove.Text = "Remove";
            this.btnDictRemove.UseVisualStyleBackColor = true;
            this.btnDictRemove.Click += new System.EventHandler(this.btnDictRemove_Click);
            // 
            // btnDictDisplay
            // 
            this.btnDictDisplay.Location = new System.Drawing.Point(332, 287);
            this.btnDictDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDictDisplay.Name = "btnDictDisplay";
            this.btnDictDisplay.Size = new System.Drawing.Size(82, 22);
            this.btnDictDisplay.TabIndex = 12;
            this.btnDictDisplay.Text = "Display";
            this.btnDictDisplay.UseVisualStyleBackColor = true;
            this.btnDictDisplay.Click += new System.EventHandler(this.btnDictDisplay_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(502, 286);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 13;
            this.btnForm2.Text = "Form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnDictDisplay);
            this.Controls.Add(this.btnDictRemove);
            this.Controls.Add(this.btnDictAdd);
            this.Controls.Add(this.btnHtDisplay);
            this.Controls.Add(this.btnHtRemove);
            this.Controls.Add(this.btnHtAdd);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.lblHashtable);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lbxDisplay);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKey;
        private TextBox txtValue;
        private ListBox lbxDisplay;
        private Label lblKey;
        private Label lblValue;
        private Label lblHashtable;
        private Label Dictionary;
        private Button btnHtAdd;
        private Button btnHtRemove;
        private Button btnHtDisplay;
        private Button btnDictAdd;
        private Button btnDictRemove;
        private Button btnDictDisplay;
        private Button btnForm2;
    }
}