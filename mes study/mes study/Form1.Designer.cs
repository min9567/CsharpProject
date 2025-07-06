namespace mes_study
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            자재관리ToolStripMenuItem = new ToolStripMenuItem();
            입고ToolStripMenuItem = new ToolStripMenuItem();
            출고ToolStripMenuItem = new ToolStripMenuItem();
            내역ToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { 자재관리ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(445, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 자재관리ToolStripMenuItem
            // 
            자재관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 입고ToolStripMenuItem, 출고ToolStripMenuItem, 내역ToolStripMenuItem });
            자재관리ToolStripMenuItem.Name = "자재관리ToolStripMenuItem";
            자재관리ToolStripMenuItem.Size = new Size(67, 20);
            자재관리ToolStripMenuItem.Text = "자재관리";
            // 
            // 입고ToolStripMenuItem
            // 
            입고ToolStripMenuItem.Name = "입고ToolStripMenuItem";
            입고ToolStripMenuItem.Size = new Size(180, 22);
            입고ToolStripMenuItem.Text = "입고";
            입고ToolStripMenuItem.Click += 입고ToolStripMenuItem_Click;
            // 
            // 출고ToolStripMenuItem
            // 
            출고ToolStripMenuItem.Name = "출고ToolStripMenuItem";
            출고ToolStripMenuItem.Size = new Size(180, 22);
            출고ToolStripMenuItem.Text = "출고";
            // 
            // 내역ToolStripMenuItem
            // 
            내역ToolStripMenuItem.Name = "내역ToolStripMenuItem";
            내역ToolStripMenuItem.Size = new Size(180, 22);
            내역ToolStripMenuItem.Text = "내역";
            내역ToolStripMenuItem.Click += 내역ToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 389);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 414);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 자재관리ToolStripMenuItem;
        private ToolStripMenuItem 입고ToolStripMenuItem;
        private ToolStripMenuItem 출고ToolStripMenuItem;
        private ToolStripMenuItem 내역ToolStripMenuItem;
        private Panel panel1;
    }
}
