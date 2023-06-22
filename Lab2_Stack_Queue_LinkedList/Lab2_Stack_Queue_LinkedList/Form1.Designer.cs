namespace Lab2_Stack_Queue_LinkedList
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
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnEnQueue = new System.Windows.Forms.Button();
            this.btnDeQueue = new System.Windows.Forms.Button();
            this.btnDisplayQueue = new System.Windows.Forms.Button();
            this.btnAddLast = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDisplayLL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(68, 56);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 23);
            this.txtCourseName.TabIndex = 0;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(238, 56);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 23);
            this.txtScore.TabIndex = 1;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 15;
            this.lbxOutput.Location = new System.Drawing.Point(487, 155);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(120, 94);
            this.lbxOutput.TabIndex = 2;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(56, 169);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 3;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(160, 169);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 4;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(263, 169);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnEnQueue
            // 
            this.btnEnQueue.Location = new System.Drawing.Point(56, 265);
            this.btnEnQueue.Name = "btnEnQueue";
            this.btnEnQueue.Size = new System.Drawing.Size(75, 23);
            this.btnEnQueue.TabIndex = 6;
            this.btnEnQueue.Text = "EnQueue";
            this.btnEnQueue.UseVisualStyleBackColor = true;
            this.btnEnQueue.Click += new System.EventHandler(this.btnEnQueue_Click);
            // 
            // btnDeQueue
            // 
            this.btnDeQueue.Location = new System.Drawing.Point(160, 265);
            this.btnDeQueue.Name = "btnDeQueue";
            this.btnDeQueue.Size = new System.Drawing.Size(75, 23);
            this.btnDeQueue.TabIndex = 7;
            this.btnDeQueue.Text = "DeQueue";
            this.btnDeQueue.UseVisualStyleBackColor = true;
            this.btnDeQueue.Click += new System.EventHandler(this.btnDeQueue_Click);
            // 
            // btnDisplayQueue
            // 
            this.btnDisplayQueue.Location = new System.Drawing.Point(263, 265);
            this.btnDisplayQueue.Name = "btnDisplayQueue";
            this.btnDisplayQueue.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayQueue.TabIndex = 8;
            this.btnDisplayQueue.Text = "Display";
            this.btnDisplayQueue.UseVisualStyleBackColor = true;
            this.btnDisplayQueue.Click += new System.EventHandler(this.btnDisplayQueue_Click);
            // 
            // btnAddLast
            // 
            this.btnAddLast.Location = new System.Drawing.Point(56, 356);
            this.btnAddLast.Name = "btnAddLast";
            this.btnAddLast.Size = new System.Drawing.Size(75, 23);
            this.btnAddLast.TabIndex = 9;
            this.btnAddLast.Text = "AddLast";
            this.btnAddLast.UseVisualStyleBackColor = true;
            this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(160, 356);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(263, 356);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDisplayLL
            // 
            this.btnDisplayLL.Location = new System.Drawing.Point(362, 356);
            this.btnDisplayLL.Name = "btnDisplayLL";
            this.btnDisplayLL.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayLL.TabIndex = 12;
            this.btnDisplayLL.Text = "Display";
            this.btnDisplayLL.UseVisualStyleBackColor = true;
            this.btnDisplayLL.Click += new System.EventHandler(this.btnDisplayLL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Stack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Queue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "LinkedList";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayLL);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddLast);
            this.Controls.Add(this.btnDisplayQueue);
            this.Controls.Add(this.btnDeQueue);
            this.Controls.Add(this.btnEnQueue);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtCourseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCourseName;
        private TextBox txtScore;
        private ListBox lbxOutput;
        private Button btnPush;
        private Button btnPop;
        private Button btnDisplay;
        private Button btnEnQueue;
        private Button btnDeQueue;
        private Button btnDisplayQueue;
        private Button btnAddLast;
        private Button btnRemove;
        private Button btnFind;
        private Button btnDisplayLL;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}