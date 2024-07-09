namespace StayFIT_WFormUI
{
    partial class frmMyMeals
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
            cmbMeals = new ComboBox();
            label2 = new Label();
            cmbCategories = new ComboBox();
            dgvFoods = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Calory = new DataGridViewTextBoxColumn();
            btnMealCreate = new Button();
            btnMealUpdate = new Button();
            btnMealDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 75);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Meals :";
            // 
            // cmbMeals
            // 
            cmbMeals.FormattingEnabled = true;
            cmbMeals.Location = new Point(129, 72);
            cmbMeals.Name = "cmbMeals";
            cmbMeals.Size = new Size(223, 23);
            cmbMeals.TabIndex = 1;
            cmbMeals.SelectedIndexChanged += cmbMeals_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 104);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 0;
            label2.Text = "Categories :";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(129, 101);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(223, 23);
            cmbCategories.TabIndex = 1;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // dgvFoods
            // 
            dgvFoods.AllowUserToAddRows = false;
            dgvFoods.AllowUserToDeleteRows = false;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Columns.AddRange(new DataGridViewColumn[] { Name, Calory });
            dgvFoods.Location = new Point(58, 143);
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowTemplate.Height = 25;
            dgvFoods.Size = new Size(294, 201);
            dgvFoods.TabIndex = 2;
            // 
            // Name
            // 
            Name.FillWeight = 2F;
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 150;
            // 
            // Calory
            // 
            Calory.FillWeight = 2F;
            Calory.HeaderText = "Calory";
            Calory.Name = "Calory";
            Calory.ReadOnly = true;
            // 
            // btnMealCreate
            // 
            btnMealCreate.Location = new Point(58, 360);
            btnMealCreate.Name = "btnMealCreate";
            btnMealCreate.Size = new Size(75, 23);
            btnMealCreate.TabIndex = 3;
            btnMealCreate.Text = "Create";
            btnMealCreate.UseVisualStyleBackColor = true;
            btnMealCreate.Click += btnMealCreate_Click;
            // 
            // btnMealUpdate
            // 
            btnMealUpdate.Location = new Point(168, 360);
            btnMealUpdate.Name = "btnMealUpdate";
            btnMealUpdate.Size = new Size(75, 23);
            btnMealUpdate.TabIndex = 3;
            btnMealUpdate.Text = "Update";
            btnMealUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMealDelete
            // 
            btnMealDelete.Location = new Point(277, 360);
            btnMealDelete.Name = "btnMealDelete";
            btnMealDelete.Size = new Size(75, 23);
            btnMealDelete.TabIndex = 3;
            btnMealDelete.Text = "Delete";
            btnMealDelete.UseVisualStyleBackColor = true;
            // 
            // frmMyMeals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 472);
            Controls.Add(btnMealDelete);
            Controls.Add(btnMealUpdate);
            Controls.Add(btnMealCreate);
            Controls.Add(dgvFoods);
            Controls.Add(cmbCategories);
            Controls.Add(label2);
            Controls.Add(cmbMeals);
            Controls.Add(label1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyMeals";
            Load += MyMeals_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMeals;
        private Label label2;
        private ComboBox cmbCategories;
        private DataGridView dgvFoods;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Calory;
        private Button btnMealCreate;
        private Button btnMealUpdate;
        private Button btnMealDelete;
    }
}