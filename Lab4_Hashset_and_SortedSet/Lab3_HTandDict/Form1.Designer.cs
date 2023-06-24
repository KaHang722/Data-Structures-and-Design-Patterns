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
            this.txtKey.Location = new System.Drawing.Point(78, 60);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(125, 27);
            this.txtKey.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(274, 60);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(125, 27);
            this.txtValue.TabIndex = 1;
            // 
            // lbxDisplay
            // 
            this.lbxDisplay.FormattingEnabled = true;
            this.lbxDisplay.ItemHeight = 20;
            this.lbxDisplay.Location = new System.Drawing.Point(563, 60);
            this.lbxDisplay.Name = "lbxDisplay";
            this.lbxDisplay.Size = new System.Drawing.Size(196, 224);
            this.lbxDisplay.TabIndex = 2;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(78, 25);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(33, 20);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "Key";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(274, 25);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(45, 20);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // lblHashtable
            // 
            this.lblHashtable.AutoSize = true;
            this.lblHashtable.Location = new System.Drawing.Point(78, 172);
            this.lblHashtable.Name = "lblHashtable";
            this.lblHashtable.Size = new System.Drawing.Size(76, 20);
            this.lblHashtable.TabIndex = 5;
            this.lblHashtable.Text = "Hashtable";
            // 
            // Dictionary
            // 
            this.Dictionary.AutoSize = true;
            this.Dictionary.Location = new System.Drawing.Point(78, 319);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(77, 20);
            this.Dictionary.TabIndex = 6;
            this.Dictionary.Text = "Dictionary";
            // 
            // btnHtAdd
            // 
            this.btnHtAdd.Location = new System.Drawing.Point(78, 232);
            this.btnHtAdd.Name = "btnHtAdd";
            this.btnHtAdd.Size = new System.Drawing.Size(94, 29);
            this.btnHtAdd.TabIndex = 7;
            this.btnHtAdd.Text = "Add";
            this.btnHtAdd.UseVisualStyleBackColor = true;
            this.btnHtAdd.Click += new System.EventHandler(this.btnHtAdd_Click);
            // 
            // btnHtRemove
            // 
            this.btnHtRemove.Location = new System.Drawing.Point(230, 232);
            this.btnHtRemove.Name = "btnHtRemove";
            this.btnHtRemove.Size = new System.Drawing.Size(94, 29);
            this.btnHtRemove.TabIndex = 8;
            this.btnHtRemove.Text = "Remove";
            this.btnHtRemove.UseVisualStyleBackColor = true;
            this.btnHtRemove.Click += new System.EventHandler(this.btnHtRemove_Click);
            // 
            // btnHtDisplay
            // 
            this.btnHtDisplay.Location = new System.Drawing.Point(380, 232);
            this.btnHtDisplay.Name = "btnHtDisplay";
            this.btnHtDisplay.Size = new System.Drawing.Size(94, 29);
            this.btnHtDisplay.TabIndex = 9;
            this.btnHtDisplay.Text = "Display";
            this.btnHtDisplay.UseVisualStyleBackColor = true;
            this.btnHtDisplay.Click += new System.EventHandler(this.btnHtDisplay_Click);
            // 
            // btnDictAdd
            // 
            this.btnDictAdd.Location = new System.Drawing.Point(78, 383);
            this.btnDictAdd.Name = "btnDictAdd";
            this.btnDictAdd.Size = new System.Drawing.Size(94, 29);
            this.btnDictAdd.TabIndex = 10;
            this.btnDictAdd.Text = "Add";
            this.btnDictAdd.UseVisualStyleBackColor = true;
            this.btnDictAdd.Click += new System.EventHandler(this.btnDictAdd_Click);
            // 
            // btnDictRemove
            // 
            this.btnDictRemove.Location = new System.Drawing.Point(230, 383);
            this.btnDictRemove.Name = "btnDictRemove";
            this.btnDictRemove.Size = new System.Drawing.Size(94, 29);
            this.btnDictRemove.TabIndex = 11;
            this.btnDictRemove.Text = "Remove";
            this.btnDictRemove.UseVisualStyleBackColor = true;
            this.btnDictRemove.Click += new System.EventHandler(this.btnDictRemove_Click);
            // 
            // btnDictDisplay
            // 
            this.btnDictDisplay.Location = new System.Drawing.Point(380, 383);
            this.btnDictDisplay.Name = "btnDictDisplay";
            this.btnDictDisplay.Size = new System.Drawing.Size(94, 29);
            this.btnDictDisplay.TabIndex = 12;
            this.btnDictDisplay.Text = "Display";
            this.btnDictDisplay.UseVisualStyleBackColor = true;
            this.btnDictDisplay.Click += new System.EventHandler(this.btnDictDisplay_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(605, 355);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(94, 29);
            this.btnForm2.TabIndex = 13;
            this.btnForm2.Text = "Form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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