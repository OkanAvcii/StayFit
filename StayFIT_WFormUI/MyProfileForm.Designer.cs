namespace StayFIT_WFormUI
{
    partial class frmMyProfileForm
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
            btnUpdate = new Button();
            grpGender = new GroupBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            dtpBirthdate = new DateTimePicker();
            txtWeight = new TextBox();
            Birthdate = new Label();
            label6 = new Label();
            txtHeight = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            grpGender.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(125, 278);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(192, 40);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdbFemale);
            grpGender.Controls.Add(rdbMale);
            grpGender.Location = new Point(125, 216);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(192, 56);
            grpGender.TabIndex = 20;
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
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(125, 187);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(192, 23);
            dtpBirthdate.TabIndex = 19;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(125, 158);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(192, 23);
            txtWeight.TabIndex = 13;
            // 
            // Birthdate
            // 
            Birthdate.AutoSize = true;
            Birthdate.BackColor = Color.IndianRed;
            Birthdate.Location = new Point(25, 193);
            Birthdate.Name = "Birthdate";
            Birthdate.Size = new Size(55, 15);
            Birthdate.TabIndex = 6;
            Birthdate.Text = "Birthdate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.ForestGreen;
            label6.Location = new Point(25, 161);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 7;
            label6.Text = "Weight :";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(125, 129);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(192, 23);
            txtHeight.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.ForestGreen;
            label5.Location = new Point(25, 132);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Height :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(125, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 23);
            txtPassword.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.ForestGreen;
            label4.Location = new Point(25, 103);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Password :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 71);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 23);
            txtEmail.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Location = new Point(25, 74);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Email :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(125, 42);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(192, 23);
            txtLastName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Location = new Point(25, 45);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 11;
            label2.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(125, 13);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(192, 23);
            txtFirstName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 12;
            label1.Text = "First Name :";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(125, 324);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(192, 40);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMyProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 377);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(grpGender);
            Controls.Add(dtpBirthdate);
            Controls.Add(txtWeight);
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
            Name = "frmMyProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfileForm";
            Load += frmMyProfileForm_Load;
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private GroupBox grpGender;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private DateTimePicker dtpBirthdate;
        private TextBox txtWeight;
        private Label Birthdate;
        private Label label6;
        private TextBox txtHeight;
        private Label label5;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private Button btnCancel;
    }
}