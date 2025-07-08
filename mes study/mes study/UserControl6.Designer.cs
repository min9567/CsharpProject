namespace mes_study
{
    partial class UserControl6
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
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 89);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(435, 124);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(29, 91);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 10;
            label4.Text = "비고";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(604, 331);
            button1.Name = "button1";
            button1.Size = new Size(81, 37);
            button1.TabIndex = 9;
            button1.Text = "등록";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 8;
            label1.Text = "수정";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.Location = new Point(517, 331);
            button2.Name = "button2";
            button2.Size = new Size(81, 37);
            button2.TabIndex = 12;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserControl6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "UserControl6";
            Size = new Size(706, 389);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}
