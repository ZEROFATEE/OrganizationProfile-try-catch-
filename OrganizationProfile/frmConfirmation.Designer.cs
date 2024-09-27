namespace OrganizationProfile
{
    partial class frmConfirmation
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
            label1 = new Label();
            lblStudentNo = new Label();
            lblBirthday = new Label();
            label4 = new Label();
            label5 = new Label();
            lblName = new Label();
            lblProgram = new Label();
            label8 = new Label();
            lblAge = new Label();
            label6 = new Label();
            lblGender = new Label();
            label7 = new Label();
            lblContactNo = new Label();
            label9 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 49);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No:";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(148, 49);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(0, 15);
            lblStudentNo.TabIndex = 1;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(148, 183);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(0, 15);
            lblBirthday.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 183);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Birthday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 87);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 2;
            label5.Text = "Name:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(148, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 3;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(148, 121);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(0, 15);
            lblProgram.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 121);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 4;
            label8.Text = "Program:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(148, 152);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(0, 15);
            lblAge.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 152);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 6;
            label6.Text = "Age:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(148, 217);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(0, 15);
            lblGender.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 217);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 8;
            label7.Text = "Gender:";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(148, 249);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(0, 15);
            lblContactNo.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 249);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 10;
            label9.Text = "Contact No:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(91, 302);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 370);
            Controls.Add(btnSubmit);
            Controls.Add(lblContactNo);
            Controls.Add(label9);
            Controls.Add(lblGender);
            Controls.Add(label7);
            Controls.Add(lblAge);
            Controls.Add(label6);
            Controls.Add(lblProgram);
            Controls.Add(label8);
            Controls.Add(lblName);
            Controls.Add(lblBirthday);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblStudentNo);
            Controls.Add(label1);
            Name = "frmConfirmation";
            Text = "frmConfirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStudentNo;
        private Label lblBirthday;
        private Label label4;
        private Label label5;
        private Label lblName;
        private Label lblProgram;
        private Label label8;
        private Label lblAge;
        private Label label6;
        private Label lblGender;
        private Label label7;
        private Label lblContactNo;
        private Label label9;
        private Button btnSubmit;
    }
}