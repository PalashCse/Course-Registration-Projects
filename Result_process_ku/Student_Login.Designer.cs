namespace Result_processing_ku
{
    partial class Student_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Studentid = new System.Windows.Forms.TextBox();
            this.Spassword = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Log In Here...........";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(57, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "STUDENT_ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(57, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Studentid
            // 
            this.Studentid.Location = new System.Drawing.Point(60, 123);
            this.Studentid.Name = "Studentid";
            this.Studentid.Size = new System.Drawing.Size(232, 20);
            this.Studentid.TabIndex = 3;
            this.Studentid.TextChanged += new System.EventHandler(this.Studentid_TextChanged);
            // 
            // Spassword
            // 
            this.Spassword.Location = new System.Drawing.Point(60, 195);
            this.Spassword.Name = "Spassword";
            this.Spassword.Size = new System.Drawing.Size(232, 20);
            this.Spassword.TabIndex = 4;
            this.Spassword.TextChanged += new System.EventHandler(this.Spassword_TextChanged);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(60, 247);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(99, 33);
            this.Loginbutton.TabIndex = 5;
            this.Loginbutton.Text = "Log In";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(186, 247);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(106, 33);
            this.Cancelbutton.TabIndex = 6;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Create New Account";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Signupbutton_Click);
            // 
            // Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(360, 416);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Spassword);
            this.Controls.Add(this.Studentid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student_Login";
            this.Text = "Student_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Studentid;
        private System.Windows.Forms.TextBox Spassword;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button button3;
    }
}