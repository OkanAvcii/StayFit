namespace StayFIT_WFormUI
{
    partial class frmMainForm
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
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            myProfileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mealsToolStripMenuItem = new ToolStripMenuItem();
            createMealToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            endOfDayReportToolStripMenuItem = new ToolStripMenuItem();
            benchmarkReportToolStripMenuItem = new ToolStripMenuItem();
            foodTypeReportToolStripMenuItem = new ToolStripMenuItem();
            userDailyActivityToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, mealsToolStripMenuItem, reportsToolStripMenuItem, userDailyActivityToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(695, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myProfileToolStripMenuItem, exitToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(53, 20);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // myProfileToolStripMenuItem
            // 
            myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            myProfileToolStripMenuItem.Size = new Size(180, 22);
            myProfileToolStripMenuItem.Text = "My Profile";
            myProfileToolStripMenuItem.Click += myProfileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // mealsToolStripMenuItem
            // 
            mealsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createMealToolStripMenuItem });
            mealsToolStripMenuItem.Name = "mealsToolStripMenuItem";
            mealsToolStripMenuItem.Size = new Size(50, 20);
            mealsToolStripMenuItem.Text = "Meals";
            // 
            // createMealToolStripMenuItem
            // 
            createMealToolStripMenuItem.Name = "createMealToolStripMenuItem";
            createMealToolStripMenuItem.Size = new Size(180, 22);
            createMealToolStripMenuItem.Text = "My Meals";
            createMealToolStripMenuItem.Click += createMealToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { endOfDayReportToolStripMenuItem, benchmarkReportToolStripMenuItem, foodTypeReportToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // endOfDayReportToolStripMenuItem
            // 
            endOfDayReportToolStripMenuItem.Name = "endOfDayReportToolStripMenuItem";
            endOfDayReportToolStripMenuItem.Size = new Size(172, 22);
            endOfDayReportToolStripMenuItem.Text = "End Of Day Report";
            // 
            // benchmarkReportToolStripMenuItem
            // 
            benchmarkReportToolStripMenuItem.Name = "benchmarkReportToolStripMenuItem";
            benchmarkReportToolStripMenuItem.Size = new Size(172, 22);
            benchmarkReportToolStripMenuItem.Text = "Benchmark Report";
            // 
            // foodTypeReportToolStripMenuItem
            // 
            foodTypeReportToolStripMenuItem.Name = "foodTypeReportToolStripMenuItem";
            foodTypeReportToolStripMenuItem.Size = new Size(172, 22);
            foodTypeReportToolStripMenuItem.Text = "Food Type Report";
            // 
            // userDailyActivityToolStripMenuItem
            // 
            userDailyActivityToolStripMenuItem.Name = "userDailyActivityToolStripMenuItem";
            userDailyActivityToolStripMenuItem.Size = new Size(114, 20);
            userDailyActivityToolStripMenuItem.Text = "User Daily Activity";
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 465);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem myProfileToolStripMenuItem;
        private ToolStripMenuItem mealsToolStripMenuItem;
        private ToolStripMenuItem createMealToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem endOfDayReportToolStripMenuItem;
        private ToolStripMenuItem benchmarkReportToolStripMenuItem;
        private ToolStripMenuItem foodTypeReportToolStripMenuItem;
        private ToolStripMenuItem userDailyActivityToolStripMenuItem;
    }
}