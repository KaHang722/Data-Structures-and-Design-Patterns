namespace Project1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbFaculty = new System.Windows.Forms.RadioButton();
            this.rbCourse = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lbxStudent = new System.Windows.Forms.ListBox();
            this.lbxFaculty = new System.Windows.Forms.ListBox();
            this.lbxCourse = new System.Windows.Forms.ListBox();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblFacultyInfo = new System.Windows.Forms.Label();
            this.lblCourseInfo = new System.Windows.Forms.Label();
            this.lblInstrcution = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Department:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(40, 201);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 15);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(374, 322);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 23);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 318);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 23);
            this.textBox4.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(374, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 23);
            this.textBox2.TabIndex = 8;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Checked = true;
            this.rbStudent.Location = new System.Drawing.Point(129, 199);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(66, 19);
            this.rbStudent.TabIndex = 9;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            this.rbStudent.CheckedChanged += new System.EventHandler(this.rbCourse_CheckedChanged);
            // 
            // rbFaculty
            // 
            this.rbFaculty.AutoSize = true;
            this.rbFaculty.Location = new System.Drawing.Point(201, 199);
            this.rbFaculty.Name = "rbFaculty";
            this.rbFaculty.Size = new System.Drawing.Size(63, 19);
            this.rbFaculty.TabIndex = 10;
            this.rbFaculty.Text = "Faculty";
            this.rbFaculty.UseVisualStyleBackColor = true;
            this.rbFaculty.CheckedChanged += new System.EventHandler(this.rbCourse_CheckedChanged);
            // 
            // rbCourse
            // 
            this.rbCourse.AutoSize = true;
            this.rbCourse.Location = new System.Drawing.Point(268, 199);
            this.rbCourse.Name = "rbCourse";
            this.rbCourse.Size = new System.Drawing.Size(62, 19);
            this.rbCourse.TabIndex = 11;
            this.rbCourse.Text = "Course";
            this.rbCourse.UseVisualStyleBackColor = true;
            this.rbCourse.CheckedChanged += new System.EventHandler(this.rbCourse_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(579, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 23);
            this.textBox3.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(539, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 26);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(629, 294);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(540, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(629, 322);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 17;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lbxStudent
            // 
            this.lbxStudent.FormattingEnabled = true;
            this.lbxStudent.ItemHeight = 15;
            this.lbxStudent.Location = new System.Drawing.Point(40, 384);
            this.lbxStudent.Name = "lbxStudent";
            this.lbxStudent.Size = new System.Drawing.Size(664, 154);
            this.lbxStudent.TabIndex = 18;
            // 
            // lbxFaculty
            // 
            this.lbxFaculty.FormattingEnabled = true;
            this.lbxFaculty.ItemHeight = 15;
            this.lbxFaculty.Location = new System.Drawing.Point(40, 563);
            this.lbxFaculty.Name = "lbxFaculty";
            this.lbxFaculty.Size = new System.Drawing.Size(664, 154);
            this.lbxFaculty.TabIndex = 19;
            // 
            // lbxCourse
            // 
            this.lbxCourse.FormattingEnabled = true;
            this.lbxCourse.ItemHeight = 15;
            this.lbxCourse.Location = new System.Drawing.Point(40, 744);
            this.lbxCourse.Name = "lbxCourse";
            this.lbxCourse.Size = new System.Drawing.Size(664, 154);
            this.lbxCourse.TabIndex = 20;
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(718, 875);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnTeacher.TabIndex = 21;
            this.btnTeacher.Text = "Faculty";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(359, 201);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 24;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Location = new System.Drawing.Point(43, 365);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(117, 15);
            this.lblStudentInfo.TabIndex = 25;
            this.lblStudentInfo.Text = "Student Information:";
            // 
            // lblFacultyInfo
            // 
            this.lblFacultyInfo.AutoSize = true;
            this.lblFacultyInfo.Location = new System.Drawing.Point(43, 544);
            this.lblFacultyInfo.Name = "lblFacultyInfo";
            this.lblFacultyInfo.Size = new System.Drawing.Size(114, 15);
            this.lblFacultyInfo.TabIndex = 26;
            this.lblFacultyInfo.Text = "Faculty Information:";
            // 
            // lblCourseInfo
            // 
            this.lblCourseInfo.AutoSize = true;
            this.lblCourseInfo.Location = new System.Drawing.Point(44, 725);
            this.lblCourseInfo.Name = "lblCourseInfo";
            this.lblCourseInfo.Size = new System.Drawing.Size(113, 15);
            this.lblCourseInfo.TabIndex = 27;
            this.lblCourseInfo.Text = "Course Information:";
            // 
            // lblInstrcution
            // 
            this.lblInstrcution.AutoSize = true;
            this.lblInstrcution.Location = new System.Drawing.Point(40, 21);
            this.lblInstrcution.Name = "lblInstrcution";
            this.lblInstrcution.Size = new System.Drawing.Size(616, 150);
            this.lblInstrcution.TabIndex = 28;
            this.lblInstrcution.Text = resources.GetString("lblInstrcution.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 930);
            this.Controls.Add(this.lblInstrcution);
            this.Controls.Add(this.lblCourseInfo);
            this.Controls.Add(this.lblFacultyInfo);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.lbxCourse);
            this.Controls.Add(this.lbxFaculty);
            this.Controls.Add(this.lbxStudent);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbCourse);
            this.Controls.Add(this.rbFaculty);
            this.Controls.Add(this.rbStudent);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label lblType;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private RadioButton rbStudent;
        private RadioButton rbFaculty;
        private RadioButton rbCourse;
        private Label label3;
        private TextBox textBox3;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnClear;
        private Button btnDisplay;
        private ListBox lbxStudent;
        private ListBox lbxFaculty;
        private ListBox lbxCourse;
        private Button btnTeacher;
        private Label lblError;
        private Label lblStudentInfo;
        private Label lblFacultyInfo;
        private Label lblCourseInfo;
        private Label lblInstrcution;
        private ContextMenuStrip contextMenuStrip1;
    }
}