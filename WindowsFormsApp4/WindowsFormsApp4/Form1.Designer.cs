namespace WindowsFormsApp4
{
    partial class Form1
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
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.cl1 = new System.Windows.Forms.CheckedListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.cl2 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(83, 54);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(52, 17);
            this.l1.TabIndex = 0;
            this.l1.Text = "Trainee";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(573, 54);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(78, 17);
            this.l2.TabIndex = 1;
            this.l2.Text = "Lab Trainee";
            // 
            // cl1
            // 
            this.cl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cl1.AllowDrop = true;
            this.cl1.CheckOnClick = true;
            this.cl1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl1.FormattingEnabled = true;
            this.cl1.Items.AddRange(new object[] {
            "Ahmed",
            "Rahma",
            "Nour",
            "Safa",
            "Rahaf",
            "Aly"});
            this.cl1.Location = new System.Drawing.Point(0, 92);
            this.cl1.MultiColumn = true;
            this.cl1.Name = "cl1";
            this.cl1.Size = new System.Drawing.Size(264, 303);
            this.cl1.TabIndex = 2;
            this.cl1.SelectedIndexChanged += new System.EventHandler(this.cl1_SelectedIndexChanged);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn1.Location = new System.Drawing.Point(358, 102);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 34);
            this.btn1.TabIndex = 3;
            this.btn1.Text = ">";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn2.Location = new System.Drawing.Point(358, 160);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 38);
            this.btn2.TabIndex = 4;
            this.btn2.Text = ">>";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn3.Location = new System.Drawing.Point(358, 227);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 38);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "<";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn4.Location = new System.Drawing.Point(358, 298);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 38);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "<<";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // cl2
            // 
            this.cl2.CheckOnClick = true;
            this.cl2.FormattingEnabled = true;
            this.cl2.Location = new System.Drawing.Point(495, 87);
            this.cl2.Name = "cl2";
            this.cl2.Size = new System.Drawing.Size(264, 289);
            this.cl2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DisplayMember = "lab1";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "lab1",
            "lab2",
            "lab3"});
            this.comboBox1.Location = new System.Drawing.Point(518, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "lab1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cl2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cl1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.CheckedListBox cl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.CheckedListBox cl2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

