namespace WindowsFormsApp1
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.RadioButton();
            this.Btn2 = new System.Windows.Forms.RadioButton();
            this.Btn3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txt1.Location = new System.Drawing.Point(129, 66);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(150, 34);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txt2.Location = new System.Drawing.Point(129, 198);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(150, 34);
            this.txt2.TabIndex = 1;
            // 
            // Btn1
            // 
            this.Btn1.AutoSize = true;
            this.Btn1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btn1.Location = new System.Drawing.Point(539, 69);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(203, 28);
            this.Btn1.TabIndex = 2;
            this.Btn1.TabStop = true;
            this.Btn1.Text = "Meter To Kilometer";
            this.Btn1.UseVisualStyleBackColor = true;
            // 
            // Btn2
            // 
            this.Btn2.AutoSize = true;
            this.Btn2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btn2.Location = new System.Drawing.Point(539, 132);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(153, 28);
            this.Btn2.TabIndex = 3;
            this.Btn2.TabStop = true;
            this.Btn2.Text = "Meter To Mile";
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.AutoSize = true;
            this.Btn3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Btn3.Location = new System.Drawing.Point(539, 201);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(199, 28);
            this.Btn3.TabIndex = 4;
            this.Btn3.TabStop = true;
            this.Btn3.Text = "Mile To CentiMeter";
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose Unit";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Location = new System.Drawing.Point(346, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(285, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "choose one converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RadioButton Btn1;
        private System.Windows.Forms.RadioButton Btn2;
        private System.Windows.Forms.RadioButton Btn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

