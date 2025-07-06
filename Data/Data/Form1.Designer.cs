namespace Data
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
            sddToolStripMenuItem = new ToolStripMenuItem();
            입고ToolStripMenuItem = new ToolStripMenuItem();
            출고ToolStripMenuItem = new ToolStripMenuItem();
            자재목록ToolStripMenuItem = new ToolStripMenuItem();
            ddToolStripMenuItem = new ToolStripMenuItem();
            전체생산내역ToolStripMenuItem = new ToolStripMenuItem();
            날짜별생산내역ToolStripMenuItem = new ToolStripMenuItem();
            출고관리ToolStripMenuItem = new ToolStripMenuItem();
            출고등록ToolStripMenuItem = new ToolStripMenuItem();
            출고내역ToolStripMenuItem = new ToolStripMenuItem();
            장비관리ToolStripMenuItem = new ToolStripMenuItem();
            장비등록ToolStripMenuItem = new ToolStripMenuItem();
            장비내역ToolStripMenuItem = new ToolStripMenuItem();
            차량관리ToolStripMenuItem = new ToolStripMenuItem();
            차량등록ToolStripMenuItem = new ToolStripMenuItem();
            차량내역ToolStripMenuItem = new ToolStripMenuItem();
            직원관리ToolStripMenuItem = new ToolStripMenuItem();
            직원등록ToolStripMenuItem = new ToolStripMenuItem();
            직원목록ToolStripMenuItem = new ToolStripMenuItem();
            권한설정ToolStripMenuItem = new ToolStripMenuItem();
            권한설정ToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            mainpanel = new Panel();
            siderpanel = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            siderpanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sddToolStripMenuItem, ddToolStripMenuItem, 출고관리ToolStripMenuItem, 장비관리ToolStripMenuItem, 차량관리ToolStripMenuItem, 직원관리ToolStripMenuItem, 권한설정ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(664, 41);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sddToolStripMenuItem
            // 
            sddToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 입고ToolStripMenuItem, 출고ToolStripMenuItem, 자재목록ToolStripMenuItem });
            sddToolStripMenuItem.Name = "sddToolStripMenuItem";
            sddToolStripMenuItem.Size = new Size(81, 37);
            sddToolStripMenuItem.Text = "자재관리";
            // 
            // 입고ToolStripMenuItem
            // 
            입고ToolStripMenuItem.Name = "입고ToolStripMenuItem";
            입고ToolStripMenuItem.Size = new Size(143, 24);
            입고ToolStripMenuItem.Text = "입고";
            입고ToolStripMenuItem.Click += 입고ToolStripMenuItem_Click;
            // 
            // 출고ToolStripMenuItem
            // 
            출고ToolStripMenuItem.Name = "출고ToolStripMenuItem";
            출고ToolStripMenuItem.Size = new Size(143, 24);
            출고ToolStripMenuItem.Text = "출고";
            출고ToolStripMenuItem.Click += 출고ToolStripMenuItem_Click;
            // 
            // 자재목록ToolStripMenuItem
            // 
            자재목록ToolStripMenuItem.Name = "자재목록ToolStripMenuItem";
            자재목록ToolStripMenuItem.Size = new Size(143, 24);
            자재목록ToolStripMenuItem.Text = "자재 목록";
            자재목록ToolStripMenuItem.Click += 자재목록ToolStripMenuItem_Click;
            // 
            // ddToolStripMenuItem
            // 
            ddToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 전체생산내역ToolStripMenuItem, 날짜별생산내역ToolStripMenuItem });
            ddToolStripMenuItem.Name = "ddToolStripMenuItem";
            ddToolStripMenuItem.Size = new Size(81, 37);
            ddToolStripMenuItem.Text = "생산관리";
            // 
            // 전체생산내역ToolStripMenuItem
            // 
            전체생산내역ToolStripMenuItem.Name = "전체생산내역ToolStripMenuItem";
            전체생산내역ToolStripMenuItem.Size = new Size(143, 24);
            전체생산내역ToolStripMenuItem.Text = "생산 등록";
            // 
            // 날짜별생산내역ToolStripMenuItem
            // 
            날짜별생산내역ToolStripMenuItem.Name = "날짜별생산내역ToolStripMenuItem";
            날짜별생산내역ToolStripMenuItem.Size = new Size(143, 24);
            날짜별생산내역ToolStripMenuItem.Text = "생산 목록";
            // 
            // 출고관리ToolStripMenuItem
            // 
            출고관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 출고등록ToolStripMenuItem, 출고내역ToolStripMenuItem });
            출고관리ToolStripMenuItem.Name = "출고관리ToolStripMenuItem";
            출고관리ToolStripMenuItem.Size = new Size(86, 37);
            출고관리ToolStripMenuItem.Text = "출고 관리";
            // 
            // 출고등록ToolStripMenuItem
            // 
            출고등록ToolStripMenuItem.Name = "출고등록ToolStripMenuItem";
            출고등록ToolStripMenuItem.Size = new Size(143, 24);
            출고등록ToolStripMenuItem.Text = "출고 등록";
            // 
            // 출고내역ToolStripMenuItem
            // 
            출고내역ToolStripMenuItem.Name = "출고내역ToolStripMenuItem";
            출고내역ToolStripMenuItem.Size = new Size(143, 24);
            출고내역ToolStripMenuItem.Text = "출고 목록";
            // 
            // 장비관리ToolStripMenuItem
            // 
            장비관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 장비등록ToolStripMenuItem, 장비내역ToolStripMenuItem });
            장비관리ToolStripMenuItem.Name = "장비관리ToolStripMenuItem";
            장비관리ToolStripMenuItem.Size = new Size(81, 37);
            장비관리ToolStripMenuItem.Text = "장비관리";
            // 
            // 장비등록ToolStripMenuItem
            // 
            장비등록ToolStripMenuItem.Name = "장비등록ToolStripMenuItem";
            장비등록ToolStripMenuItem.Size = new Size(143, 24);
            장비등록ToolStripMenuItem.Text = "장비 등록";
            // 
            // 장비내역ToolStripMenuItem
            // 
            장비내역ToolStripMenuItem.Name = "장비내역ToolStripMenuItem";
            장비내역ToolStripMenuItem.Size = new Size(143, 24);
            장비내역ToolStripMenuItem.Text = "장비 목록";
            // 
            // 차량관리ToolStripMenuItem
            // 
            차량관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 차량등록ToolStripMenuItem, 차량내역ToolStripMenuItem });
            차량관리ToolStripMenuItem.Name = "차량관리ToolStripMenuItem";
            차량관리ToolStripMenuItem.Size = new Size(81, 37);
            차량관리ToolStripMenuItem.Text = "차량관리";
            // 
            // 차량등록ToolStripMenuItem
            // 
            차량등록ToolStripMenuItem.Name = "차량등록ToolStripMenuItem";
            차량등록ToolStripMenuItem.Size = new Size(143, 24);
            차량등록ToolStripMenuItem.Text = "차량 등록";
            // 
            // 차량내역ToolStripMenuItem
            // 
            차량내역ToolStripMenuItem.Name = "차량내역ToolStripMenuItem";
            차량내역ToolStripMenuItem.Size = new Size(143, 24);
            차량내역ToolStripMenuItem.Text = "차량 목록";
            // 
            // 직원관리ToolStripMenuItem
            // 
            직원관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 직원등록ToolStripMenuItem, 직원목록ToolStripMenuItem });
            직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem";
            직원관리ToolStripMenuItem.Size = new Size(81, 37);
            직원관리ToolStripMenuItem.Text = "직원관리";
            // 
            // 직원등록ToolStripMenuItem
            // 
            직원등록ToolStripMenuItem.Name = "직원등록ToolStripMenuItem";
            직원등록ToolStripMenuItem.Size = new Size(138, 24);
            직원등록ToolStripMenuItem.Text = "직원등록";
            // 
            // 직원목록ToolStripMenuItem
            // 
            직원목록ToolStripMenuItem.Name = "직원목록ToolStripMenuItem";
            직원목록ToolStripMenuItem.Size = new Size(138, 24);
            직원목록ToolStripMenuItem.Text = "직원목록";
            // 
            // 권한설정ToolStripMenuItem
            // 
            권한설정ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 권한설정ToolStripMenuItem1 });
            권한설정ToolStripMenuItem.Name = "권한설정ToolStripMenuItem";
            권한설정ToolStripMenuItem.Size = new Size(81, 37);
            권한설정ToolStripMenuItem.Text = "권한설정";
            // 
            // 권한설정ToolStripMenuItem1
            // 
            권한설정ToolStripMenuItem1.Name = "권한설정ToolStripMenuItem1";
            권한설정ToolStripMenuItem1.Size = new Size(138, 24);
            권한설정ToolStripMenuItem1.Text = "권한설정";
            // 
            // panel1
            // 
            panel1.Controls.Add(mainpanel);
            panel1.Controls.Add(siderpanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 434);
            panel1.TabIndex = 1;
            // 
            // mainpanel
            // 
            mainpanel.BorderStyle = BorderStyle.Fixed3D;
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(152, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(512, 434);
            mainpanel.TabIndex = 1;
            // 
            // siderpanel
            // 
            siderpanel.BorderStyle = BorderStyle.Fixed3D;
            siderpanel.Controls.Add(label1);
            siderpanel.Dock = DockStyle.Left;
            siderpanel.Location = new Point(0, 0);
            siderpanel.Name = "siderpanel";
            siderpanel.Size = new Size(152, 434);
            siderpanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "즐겨찾기";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 475);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            siderpanel.ResumeLayout(false);
            siderpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sddToolStripMenuItem;
        private ToolStripMenuItem ddToolStripMenuItem;
        private ToolStripMenuItem 장비관리ToolStripMenuItem;
        private ToolStripMenuItem 차량관리ToolStripMenuItem;
        private ToolStripMenuItem 입고ToolStripMenuItem;
        private ToolStripMenuItem 출고ToolStripMenuItem;
        private ToolStripMenuItem 날짜별생산내역ToolStripMenuItem;
        private ToolStripMenuItem 전체생산내역ToolStripMenuItem;
        private ToolStripMenuItem 출고관리ToolStripMenuItem;
        private ToolStripMenuItem 출고내역ToolStripMenuItem;
        private ToolStripMenuItem 출고등록ToolStripMenuItem;
        private ToolStripMenuItem 장비내역ToolStripMenuItem;
        private ToolStripMenuItem 장비등록ToolStripMenuItem;
        private ToolStripMenuItem 자재목록ToolStripMenuItem;
        private ToolStripMenuItem 차량등록ToolStripMenuItem;
        private ToolStripMenuItem 차량내역ToolStripMenuItem;
        private Panel panel1;
        private Panel mainpanel;
        private Panel siderpanel;
        private Label label1;
        private ToolStripMenuItem 권한설정ToolStripMenuItem;
        private ToolStripMenuItem 직원관리ToolStripMenuItem;
        private ToolStripMenuItem 권한설정ToolStripMenuItem1;
        private ToolStripMenuItem 직원등록ToolStripMenuItem;
        private ToolStripMenuItem 직원목록ToolStripMenuItem;
    }
}
