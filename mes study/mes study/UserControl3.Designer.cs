namespace mes_study
{
    partial class UserControl3
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 1;
            label1.Text = "입고 등록";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(29, 91);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 2;
            label2.Text = "품명";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(69, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(29, 136);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 4;
            label3.Text = "수량";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(606, 334);
            button1.Name = "button1";
            button1.Size = new Size(81, 37);
            button1.TabIndex = 9;
            button1.Text = "등록";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(29, 181);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 7;
            label4.Text = "비고";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(69, 179);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(435, 91);
            textBox3.TabIndex = 8;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.Location = new Point(519, 334);
            button2.Name = "button2";
            button2.Size = new Size(81, 37);
            button2.TabIndex = 10;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl3";
            Size = new Size(706, 389);
            Load += UserControl3_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private TextBox textBox3;
        private Button button2;
    }
}
