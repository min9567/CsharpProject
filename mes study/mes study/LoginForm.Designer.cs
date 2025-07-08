namespace mes_study
{
    partial class LoginForm
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            loginpanel = new Panel();
            loginpanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11.25F);
            label1.Location = new Point(90, 51);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "아이디";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11.25F);
            label2.Location = new Point(75, 87);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "비밀번호";
            // 
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.Disable;
            textBox1.Location = new Point(150, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 88);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 11.25F);
            button1.Location = new Point(212, 129);
            button1.Name = "button1";
            button1.Size = new Size(93, 32);
            button1.TabIndex = 4;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 11.25F);
            button2.Location = new Point(101, 129);
            button2.Name = "button2";
            button2.Size = new Size(93, 32);
            button2.TabIndex = 5;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // loginpanel
            // 
            loginpanel.Controls.Add(button2);
            loginpanel.Controls.Add(button1);
            loginpanel.Controls.Add(textBox2);
            loginpanel.Controls.Add(textBox1);
            loginpanel.Controls.Add(label2);
            loginpanel.Controls.Add(label1);
            loginpanel.Dock = DockStyle.Fill;
            loginpanel.Location = new Point(0, 0);
            loginpanel.Name = "loginpanel";
            loginpanel.Size = new Size(380, 213);
            loginpanel.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 213);
            Controls.Add(loginpanel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Panel loginpanel;
    }
}