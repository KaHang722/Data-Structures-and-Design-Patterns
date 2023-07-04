namespace Assignment3
{
    partial class Form3
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnForm2 = new System.Windows.Forms.Button();
            this.ss1 = new System.Windows.Forms.ListBox();
            this.ss2 = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIntersection = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnSubset = new System.Windows.Forms.Button();
            this.btnSuperSet = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(692, 383);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 0;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // ss1
            // 
            this.ss1.FormattingEnabled = true;
            this.ss1.ItemHeight = 15;
            this.ss1.Location = new System.Drawing.Point(66, 55);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(120, 94);
            this.ss1.TabIndex = 1;
            // 
            // ss2
            // 
            this.ss2.FormattingEnabled = true;
            this.ss2.ItemHeight = 15;
            this.ss2.Location = new System.Drawing.Point(590, 55);
            this.ss2.Name = "ss2";
            this.ss2.Size = new System.Drawing.Size(120, 94);
            this.ss2.TabIndex = 2;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(282, 55);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(86, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(383, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIntersection
            // 
            this.btnIntersection.Location = new System.Drawing.Point(282, 92);
            this.btnIntersection.Name = "btnIntersection";
            this.btnIntersection.Size = new System.Drawing.Size(86, 23);
            this.btnIntersection.TabIndex = 5;
            this.btnIntersection.Text = "Intersection";
            this.btnIntersection.UseVisualStyleBackColor = true;
            this.btnIntersection.Click += new System.EventHandler(this.btnIntersection_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(383, 92);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(86, 23);
            this.btnUnion.TabIndex = 6;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnSubset
            // 
            this.btnSubset.Location = new System.Drawing.Point(282, 127);
            this.btnSubset.Name = "btnSubset";
            this.btnSubset.Size = new System.Drawing.Size(86, 23);
            this.btnSubset.TabIndex = 7;
            this.btnSubset.Text = "Subset?";
            this.btnSubset.UseVisualStyleBackColor = true;
            this.btnSubset.Click += new System.EventHandler(this.btnSubset_Click);
            // 
            // btnSuperSet
            // 
            this.btnSuperSet.Location = new System.Drawing.Point(383, 127);
            this.btnSuperSet.Name = "btnSuperSet";
            this.btnSuperSet.Size = new System.Drawing.Size(86, 23);
            this.btnSuperSet.TabIndex = 8;
            this.btnSuperSet.Text = "SuperSet?";
            this.btnSuperSet.UseVisualStyleBackColor = true;
            this.btnSuperSet.Click += new System.EventHandler(this.btnSuperSet_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(357, 165);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(36, 15);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "result";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 10;
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(88, 188);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(75, 23);
            this.btnAdd1.TabIndex = 11;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnRemove1
            // 
            this.btnRemove1.Location = new System.Drawing.Point(183, 188);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(75, 23);
            this.btnRemove1.TabIndex = 12;
            this.btnRemove1.Text = "Remove";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(511, 188);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 13;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(616, 188);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(75, 23);
            this.btnRemove2.TabIndex = 14;
            this.btnRemove2.Text = "Remove";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(88, 263);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 15;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Location = new System.Drawing.Point(511, 263);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(0, 15);
            this.lblError2.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnRemove1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSuperSet);
            this.Controls.Add(this.btnSubset);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.btnIntersection);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.ss2);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.btnForm2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnForm2;
    private ListBox ss1;
    private ListBox ss2;
    private Button btnDisplay;
    private Button btnClear;
    private Button btnIntersection;
    private Button btnUnion;
    private Button btnSubset;
    private Button btnSuperSet;
    private Label lblResult;
    private TextBox textBox1;
    private Button btnAdd1;
    private Button btnRemove1;
    private Button btnAdd2;
    private Button btnRemove2;
        private Label lblError;
        private Label lblError2;
    }
}