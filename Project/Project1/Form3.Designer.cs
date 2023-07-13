namespace Project1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnUnassignCourse = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(60, 341);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(570, 229);
            this.listBox1.TabIndex = 26;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(555, 289);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 25;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.Location = new System.Drawing.Point(279, 289);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(119, 23);
            this.btnUnassign.TabIndex = 24;
            this.btnUnassign.Text = "Remove Record";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(179, 289);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 23;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(148, 223);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(482, 23);
            this.txtCourseName.TabIndex = 20;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(148, 175);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(482, 23);
            this.txtStudentID.TabIndex = 19;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(60, 226);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(82, 15);
            this.lblCourseName.TabIndex = 18;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(60, 178);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 15);
            this.lblStudentID.TabIndex = 17;
            this.lblStudentID.Text = "Student ID:";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(672, 547);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 16;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(672, 490);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnTeacher.TabIndex = 15;
            this.btnTeacher.Text = "Faculty";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnUnassignCourse
            // 
            this.btnUnassignCourse.Location = new System.Drawing.Point(417, 289);
            this.btnUnassignCourse.Name = "btnUnassignCourse";
            this.btnUnassignCourse.Size = new System.Drawing.Size(119, 23);
            this.btnUnassignCourse.TabIndex = 27;
            this.btnUnassignCourse.Text = "Unassign Course";
            this.btnUnassignCourse.UseVisualStyleBackColor = true;
            this.btnUnassignCourse.Click += new System.EventHandler(this.btnUnassignCourse_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(60, 8);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(726, 135);
            this.lblInstruction.TabIndex = 28;
            this.lblInstruction.Text = resources.GetString("lblInstruction.Text");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnUnassignCourse);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnTeacher);
            this.Name = "Form3";
            this.Text = "Student Management System  - Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button btnDisplay;
        private Button btnUnassign;
        private Button btnAssign;
        private TextBox txtCourseName;
        private TextBox txtStudentID;
        private Label lblCourseName;
        private Label lblStudentID;
        private Button btnSummary;
        private Button btnTeacher;
        private Button btnUnassignCourse;
        private Label lblInstruction;
    }
}