namespace FrmOpenFile
{
    partial class FrmRegistration
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbPrograms = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.Location = new System.Drawing.Point(327, 368);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(143, 47);
            this.btnRegister.TabIndex = 39;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbPrograms
            // 
            this.cbPrograms.BackColor = System.Drawing.Color.White;
            this.cbPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPrograms.FormattingEnabled = true;
            this.cbPrograms.Location = new System.Drawing.Point(449, 97);
            this.cbPrograms.Name = "cbPrograms";
            this.cbPrograms.Size = new System.Drawing.Size(339, 28);
            this.cbPrograms.TabIndex = 38;
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.White;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cbGender.Location = new System.Drawing.Point(449, 216);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(187, 28);
            this.cbGender.TabIndex = 37;
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.datePickerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePickerBirthday.Location = new System.Drawing.Point(125, 280);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(284, 26);
            this.datePickerBirthday.TabIndex = 36;
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.White;
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(559, 282);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(220, 26);
            this.txtContactNo.TabIndex = 35;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.BackColor = System.Drawing.Color.White;
            this.txtMiddleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.Location = new System.Drawing.Point(716, 157);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(72, 26);
            this.txtMiddleInitial.TabIndex = 34;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(449, 157);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(202, 26);
            this.txtFirstName.TabIndex = 33;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(130, 216);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(111, 26);
            this.txtAge.TabIndex = 32;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(130, 155);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(202, 26);
            this.txtLastName.TabIndex = 31;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.BackColor = System.Drawing.Color.White;
            this.txtStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNo.Location = new System.Drawing.Point(130, 99);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(202, 26);
            this.txtStudentNo.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Contact No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Birthday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(666, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "M.I.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Student No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registration";
            // 
            // btnViewRecord
            // 
            this.btnViewRecord.BackColor = System.Drawing.Color.LightGreen;
            this.btnViewRecord.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnViewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnViewRecord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewRecord.Location = new System.Drawing.Point(670, 368);
            this.btnViewRecord.Name = "btnViewRecord";
            this.btnViewRecord.Size = new System.Drawing.Size(109, 47);
            this.btnViewRecord.TabIndex = 40;
            this.btnViewRecord.Text = "Records";
            this.btnViewRecord.UseVisualStyleBackColor = false;
            this.btnViewRecord.Click += new System.EventHandler(this.btnViewRecord_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewRecord);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbPrograms);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbPrograms;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewRecord;
    }
}