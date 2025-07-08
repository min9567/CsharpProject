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
            직원관리ToolStripMenuItem = new ToolStripMenuItem();
            직원등록ToolStripMenuItem = new ToolStripMenuItem();
            직원목록ToolStripMenuItem = new ToolStripMenuItem();
            부서등록ToolStripMenuItem = new ToolStripMenuItem();
            부서목록ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            뒤로가기ToolStripMenuItem = new ToolStripMenuItem();
            로그아웃ToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { 자재관리ToolStripMenuItem, 직원관리ToolStripMenuItem, toolStripMenuItem1, 뒤로가기ToolStripMenuItem, 로그아웃ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(710, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 자재관리ToolStripMenuItem
            // 
            자재관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 입고ToolStripMenuItem, 출고ToolStripMenuItem, 내역ToolStripMenuItem });
            자재관리ToolStripMenuItem.Name = "자재관리ToolStripMenuItem";
            자재관리ToolStripMenuItem.Size = new Size(67, 26);
            자재관리ToolStripMenuItem.Text = "자재관리";
            // 
            // 입고ToolStripMenuItem
            // 
            입고ToolStripMenuItem.Name = "입고ToolStripMenuItem";
            입고ToolStripMenuItem.Size = new Size(98, 22);
            입고ToolStripMenuItem.Text = "입고";
            입고ToolStripMenuItem.Click += 입고ToolStripMenuItem_Click;
            // 
            // 출고ToolStripMenuItem
            // 
            출고ToolStripMenuItem.Name = "출고ToolStripMenuItem";
            출고ToolStripMenuItem.Size = new Size(98, 22);
            출고ToolStripMenuItem.Text = "출고";
            출고ToolStripMenuItem.Click += 출고ToolStripMenuItem_Click;
            // 
            // 내역ToolStripMenuItem
            // 
            내역ToolStripMenuItem.Name = "내역ToolStripMenuItem";
            내역ToolStripMenuItem.Size = new Size(98, 22);
            내역ToolStripMenuItem.Text = "내역";
            내역ToolStripMenuItem.Click += 내역ToolStripMenuItem_Click;
            // 
            // 직원관리ToolStripMenuItem
            // 
            직원관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 직원등록ToolStripMenuItem, 직원목록ToolStripMenuItem, 부서등록ToolStripMenuItem, 부서목록ToolStripMenuItem });
            직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem";
            직원관리ToolStripMenuItem.Size = new Size(67, 26);
            직원관리ToolStripMenuItem.Text = "직원관리";
            // 
            // 직원등록ToolStripMenuItem
            // 
            직원등록ToolStripMenuItem.Name = "직원등록ToolStripMenuItem";
            직원등록ToolStripMenuItem.Size = new Size(126, 22);
            직원등록ToolStripMenuItem.Text = "직원 등록";
            직원등록ToolStripMenuItem.Click += 직원등록ToolStripMenuItem_Click;
            // 
            // 직원목록ToolStripMenuItem
            // 
            직원목록ToolStripMenuItem.Name = "직원목록ToolStripMenuItem";
            직원목록ToolStripMenuItem.Size = new Size(126, 22);
            직원목록ToolStripMenuItem.Text = "직원 목록";
            직원목록ToolStripMenuItem.Click += 직원목록ToolStripMenuItem_Click;
            // 
            // 부서등록ToolStripMenuItem
            // 
            부서등록ToolStripMenuItem.Name = "부서등록ToolStripMenuItem";
            부서등록ToolStripMenuItem.Size = new Size(126, 22);
            부서등록ToolStripMenuItem.Text = "부서 등록";
            부서등록ToolStripMenuItem.Click += 부서등록ToolStripMenuItem_Click;
            // 
            // 부서목록ToolStripMenuItem
            // 
            부서목록ToolStripMenuItem.Name = "부서목록ToolStripMenuItem";
            부서목록ToolStripMenuItem.Size = new Size(126, 22);
            부서목록ToolStripMenuItem.Text = "부서 목록";
            부서목록ToolStripMenuItem.Click += 부서목록ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(430, 26);
            toolStripMenuItem1.Text = " ";
            // 
            // 뒤로가기ToolStripMenuItem
            // 
            뒤로가기ToolStripMenuItem.Name = "뒤로가기ToolStripMenuItem";
            뒤로가기ToolStripMenuItem.Size = new Size(67, 26);
            뒤로가기ToolStripMenuItem.Text = "뒤로가기";
            뒤로가기ToolStripMenuItem.Click += btnBack_Click;
            // 
            // 로그아웃ToolStripMenuItem
            // 
            로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            로그아웃ToolStripMenuItem.Size = new Size(67, 26);
            로그아웃ToolStripMenuItem.Text = "로그아웃";
            로그아웃ToolStripMenuItem.Click += 로그아웃ToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 385);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 414);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 자재관리ToolStripMenuItem;
        private ToolStripMenuItem 입고ToolStripMenuItem;
        private ToolStripMenuItem 출고ToolStripMenuItem;
        private ToolStripMenuItem 내역ToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem 직원관리ToolStripMenuItem;
        private ToolStripMenuItem 직원등록ToolStripMenuItem;
        private ToolStripMenuItem 직원목록ToolStripMenuItem;
        private ToolStripMenuItem 부서등록ToolStripMenuItem;
        private ToolStripMenuItem 부서목록ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 뒤로가기ToolStripMenuItem;
        private ToolStripMenuItem 로그아웃ToolStripMenuItem;
    }
}
