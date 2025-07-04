namespace C_Project
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
            panel1 = new Panel();
            panel5 = new Panel();
            siderinventory = new Label();
            sidersales = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panelmain = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            TopTitle = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(siderinventory);
            panel1.Controls.Add(sidersales);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 412);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 352);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 60);
            panel5.TabIndex = 5;
            // 
            // siderinventory
            // 
            siderinventory.AutoSize = true;
            siderinventory.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            siderinventory.Location = new Point(48, 279);
            siderinventory.Name = "siderinventory";
            siderinventory.Size = new Size(100, 30);
            siderinventory.TabIndex = 6;
            siderinventory.Text = "inventory";
            // 
            // sidersales
            // 
            sidersales.AutoSize = true;
            sidersales.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            sidersales.Location = new Point(48, 209);
            sidersales.Name = "sidersales";
            sidersales.Size = new Size(60, 30);
            sidersales.TabIndex = 3;
            sidersales.Text = "Sales";
            sidersales.Click += sidersales_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(48, 140);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 2;
            label2.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(1, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 1);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(42, 31);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panelmain
            // 
            panelmain.Location = new Point(212, 95);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(448, 258);
            panelmain.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(TopTitle);
            panel3.Location = new Point(212, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 96);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(344, 37);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 2;
            label4.Text = "Admin";
            // 
            // TopTitle
            // 
            TopTitle.AutoSize = true;
            TopTitle.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            TopTitle.Location = new Point(25, 31);
            TopTitle.Name = "TopTitle";
            TopTitle.Size = new Size(129, 32);
            TopTitle.TabIndex = 1;
            TopTitle.Text = "Dashboard";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(212, 352);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 60);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(42, 12);
            label3.Name = "label3";
            label3.Size = new Size(126, 30);
            label3.TabIndex = 7;
            label3.Text = "User: admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label5.Location = new Point(25, 12);
            label5.Name = "label5";
            label5.Size = new Size(88, 30);
            label5.TabIndex = 8;
            label5.Text = "Settings";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label6.Location = new Point(344, 12);
            label6.Name = "label6";
            label6.Size = new Size(75, 30);
            label6.TabIndex = 9;
            label6.Text = "Admin";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveBorder;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(325, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 60);
            panel6.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 412);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelmain);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label sidersales;
        private Label label2;
        private Label siderinventory;
        private Panel panelmain;
        private Panel panel3;
        private Label label4;
        private Label TopTitle;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private Label label6;
        private Label label5;
    }
}
