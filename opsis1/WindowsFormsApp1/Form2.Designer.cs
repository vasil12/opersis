namespace WindowsFormsApp1
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lab1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.regulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeInWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeInWindowVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namberOfWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lab1ToolStripMenuItem,
            this.lab2ToolStripMenuItem,
            this.lab3ToolStripMenuItem,
            this.lab4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lab1ToolStripMenuItem
            // 
            this.lab1ToolStripMenuItem.Name = "lab1ToolStripMenuItem";
            this.lab1ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.lab1ToolStripMenuItem.Text = "lab1";
            this.lab1ToolStripMenuItem.Click += new System.EventHandler(this.Lab1ToolStripMenuItem_Click);
            // 
            // lab2ToolStripMenuItem
            // 
            this.lab2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.regulationToolStripMenuItem,
            this.namberOfWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.lab2ToolStripMenuItem.Name = "lab2ToolStripMenuItem";
            this.lab2ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.lab2ToolStripMenuItem.Text = "lab2";
            this.lab2ToolStripMenuItem.Click += new System.EventHandler(this.Lab2ToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.closeToolStripMenuItem1});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.createToolStripMenuItem.Text = "window";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.createToolStripMenuItem1.Text = "create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.CreateToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.closeToolStripMenuItem1.Text = "close";
            this.closeToolStripMenuItem1.Visible = false;
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.CloseToolStripMenuItem1_Click);
            // 
            // regulationToolStripMenuItem
            // 
            this.regulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.placeInWindowToolStripMenuItem,
            this.placeInWindowVerticalToolStripMenuItem});
            this.regulationToolStripMenuItem.Name = "regulationToolStripMenuItem";
            this.regulationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.regulationToolStripMenuItem.Text = "regulation";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cascadeToolStripMenuItem.Text = "cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.collapseAllToolStripMenuItem.Text = "collapse all";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.CollapseAllToolStripMenuItem_Click);
            // 
            // placeInWindowToolStripMenuItem
            // 
            this.placeInWindowToolStripMenuItem.Name = "placeInWindowToolStripMenuItem";
            this.placeInWindowToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.placeInWindowToolStripMenuItem.Text = "place in window horisontal";
            this.placeInWindowToolStripMenuItem.Click += new System.EventHandler(this.PlaceInWindowToolStripMenuItem_Click);
            // 
            // placeInWindowVerticalToolStripMenuItem
            // 
            this.placeInWindowVerticalToolStripMenuItem.Name = "placeInWindowVerticalToolStripMenuItem";
            this.placeInWindowVerticalToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.placeInWindowVerticalToolStripMenuItem.Text = "place in window vertical";
            this.placeInWindowVerticalToolStripMenuItem.Click += new System.EventHandler(this.PlaceInWindowVerticalToolStripMenuItem_Click);
            // 
            // namberOfWindowToolStripMenuItem
            // 
            this.namberOfWindowToolStripMenuItem.Name = "namberOfWindowToolStripMenuItem";
            this.namberOfWindowToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.namberOfWindowToolStripMenuItem.Text = "namber of window";
            this.namberOfWindowToolStripMenuItem.Click += new System.EventHandler(this.NamberOfWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // lab3ToolStripMenuItem
            // 
            this.lab3ToolStripMenuItem.Name = "lab3ToolStripMenuItem";
            this.lab3ToolStripMenuItem.ShowShortcutKeys = false;
            this.lab3ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.lab3ToolStripMenuItem.Text = "lab3";
            this.lab3ToolStripMenuItem.Click += new System.EventHandler(this.Lab3ToolStripMenuItem_Click);
            // 
            // lab4ToolStripMenuItem
            // 
            this.lab4ToolStripMenuItem.Name = "lab4ToolStripMenuItem";
            this.lab4ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.lab4ToolStripMenuItem.Text = "lab4";
            this.lab4ToolStripMenuItem.Click += new System.EventHandler(this.Lab4ToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(641, 464);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lab1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem regulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeInWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namberOfWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeInWindowVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab4ToolStripMenuItem;
    }
}