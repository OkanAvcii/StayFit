namespace StayFIT_WFormUI
{
    partial class frmLogin
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
            txtLoginEmail = new TextBox();
            txtLoginPassword = new TextBox();
            btnLogin = new Button();
            linklblSign = new LinkLabel();
            pBoxLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Location = new Point(63, 190);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(180, 23);
            txtLoginEmail.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(63, 219);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(180, 23);
            txtLoginPassword.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(63, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 42);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linklblSign
            // 
            linklblSign.AutoSize = true;
            linklblSign.Location = new Point(63, 293);
            linklblSign.Name = "linklblSign";
            linklblSign.Size = new Size(43, 15);
            linklblSign.TabIndex = 2;
            linklblSign.TabStop = true;
            linklblSign.Text = "Sign in";
            linklblSign.LinkClicked += linklblSign_LinkClicked;
            // 
            // pBoxLogin
            // 
            pBoxLogin.Location = new Point(63, 45);
            pBoxLogin.Name = "pBoxLogin";
            pBoxLogin.Size = new Size(180, 139);
            pBoxLogin.TabIndex = 3;
            pBoxLogin.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 377);
            Controls.Add(pBoxLogin);
            Controls.Add(linklblSign);
            Controls.Add(btnLogin);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginEmail);
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoginEmail;
        private TextBox txtLoginPassword;
        private Button btnLogin;
        private LinkLabel linklblSign;
        private PictureBox pBoxLogin;
    }
}
