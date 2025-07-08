namespace mes_study
{
    partial class UserControl7
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox8 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 5;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(604, 331);
            button1.Name = "button1";
            button1.Size = new Size(81, 37);
            button1.TabIndex = 20;
            button1.Text = "등록";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(27, 128);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 4;
            label3.Text = "생년월일";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(53, 88);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 2;
            label2.Text = "이름";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 1;
            label1.Text = "직원 등록";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(40, 168);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 6;
            label4.Text = "연락처";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label5.Location = new Point(53, 248);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 10;
            label5.Text = "부서";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(345, 86);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(142, 23);
            textBox6.TabIndex = 15;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label6.Location = new Point(292, 88);
            label6.Name = "label6";
            label6.Size = new Size(47, 17);
            label6.TabIndex = 14;
            label6.Text = "아이디";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(345, 126);
            textBox7.Name = "textBox7";
            textBox7.PasswordChar = '●';
            textBox7.Size = new Size(142, 23);
            textBox7.TabIndex = 17;
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label7.Location = new Point(279, 128);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 16;
            label7.Text = "비밀번호";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(93, 206);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 23);
            textBox4.TabIndex = 9;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label8.Location = new Point(40, 208);
            label8.Name = "label8";
            label8.Size = new Size(47, 17);
            label8.TabIndex = 8;
            label8.Text = "이메일";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(93, 286);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(394, 23);
            textBox5.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label9.Location = new Point(53, 288);
            label9.Name = "label9";
            label9.Size = new Size(34, 17);
            label9.TabIndex = 12;
            label9.Text = "주소";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label10.Location = new Point(305, 168);
            label10.Name = "label10";
            label10.Size = new Size(34, 17);
            label10.TabIndex = 18;
            label10.Text = "메모";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(345, 166);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(142, 103);
            textBox8.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.Location = new Point(517, 331);
            button2.Name = "button2";
            button2.Size = new Size(81, 37);
            button2.TabIndex = 21;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserControl7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox8);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl7";
            Size = new Size(706, 389);
            Load += UserControl7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private TextBox textBox8;
        private ComboBox comboBox1;
        private Button button2;
    }
}
