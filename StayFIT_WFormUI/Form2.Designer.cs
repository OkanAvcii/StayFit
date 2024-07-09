namespace StayFIT_WFormUI
{
    partial class frmUserCreate
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
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtHeight = new TextBox();
            label6 = new Label();
            txtWeight = new TextBox();
            dtpBirthdate = new DateTimePicker();
            Birthdate = new Label();
            rdbMale = new RadioButton();
            grpGender = new GroupBox();
            rdbFemale = new RadioButton();
            btnSave = new Button();
            label7 = new Label();
            cmbActivity = new ComboBox();
            grpGender.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(125, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(192, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 0;
            label2.Text = "Last Name :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(125, 61);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(192, 23);
            txtLastName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 93);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 23);
            txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 122);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 0;
            label4.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(125, 119);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 23);
            txtPassword.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 151);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 0;
            label5.Text = "Height :";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(125, 148);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(192, 23);
            txtHeight.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 180);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 0;
            label6.Text = "Weight :";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(125, 177);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(192, 23);
            txtWeight.TabIndex = 1;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(125, 206);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(192, 23);
            dtpBirthdate.TabIndex = 2;
            // 
            // Birthdate
            // 
            Birthdate.AutoSize = true;
            Birthdate.Location = new Point(25, 212);
            Birthdate.Name = "Birthdate";
            Birthdate.Size = new Size(55, 15);
            Birthdate.TabIndex = 0;
            Birthdate.Text = "Birthdate";
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(28, 22);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(51, 19);
            rdbMale.TabIndex = 3;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdbFemale);
            grpGender.Controls.Add(rdbMale);
            grpGender.Location = new Point(125, 270);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(192, 56);
            grpGender.TabIndex = 4;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(109, 22);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(63, 19);
            rdbFemale.TabIndex = 3;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(125, 332);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(192, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 243);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 0;
            label7.Text = "Activity Level";
            // 
            // cmbActivity
            // 
            cmbActivity.FormattingEnabled = true;
            cmbActivity.Location = new Point(125, 240);
            cmbActivity.Name = "cmbActivity";
            cmbActivity.Size = new Size(192, 23);
            cmbActivity.TabIndex = 6;
            // 
            // frmUserCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 410);
            Controls.Add(cmbActivity);
            Controls.Add(btnSave);
            Controls.Add(grpGender);
            Controls.Add(dtpBirthdate);
            Controls.Add(txtWeight);
            Controls.Add(label7);
            Controls.Add(Birthdate);
            Controls.Add(label6);
            Controls.Add(txtHeight);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "frmUserCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Create";
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtHeight;
        private Label label6;
        private TextBox txtWeight;
        private DateTimePicker dtpBirthdate;
        private Label Birthdate;
        private RadioButton rdbMale;
        private GroupBox grpGender;
        private RadioButton rdbFemale;
        private Button btnSave;
        private Label label7;
        private ComboBox cmbActivity;
    }
}