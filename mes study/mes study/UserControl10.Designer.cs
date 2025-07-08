namespace mes_study
{
    partial class UserControl10
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 11.25F);
            button2.Location = new Point(101, 129);
            button2.Name = "button2";
            button2.Size = new Size(93, 32);
            button2.TabIndex = 11;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 11.25F);
            button1.Location = new Point(212, 129);
            button1.Name = "button1";
            button1.Size = new Size(93, 32);
            button1.TabIndex = 10;
            button1.Text = "변경";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 52);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '●';
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11.25F);
            label2.Location = new Point(25, 52);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 7;
            label2.Text = "변경할 비밀번호";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 88);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11.25F);
            label3.Location = new Point(90, 88);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 12;
            label3.Text = "재확인";
            // 
            // UserControl10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "UserControl10";
            Size = new Size(380, 213);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
    }
}
