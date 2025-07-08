namespace mes_study
{
    partial class UserControl13
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
            listView1 = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader5 });
            listView1.Location = new Point(32, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(204, 307);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "";
            columnHeader0.Width = 25;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "부서";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 175;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 7;
            label1.Text = "부서 목록";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(523, 21);
            button1.Name = "button1";
            button1.Size = new Size(76, 28);
            button1.TabIndex = 10;
            button1.Text = "삭제";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(605, 21);
            button2.Name = "button2";
            button2.Size = new Size(76, 28);
            button2.TabIndex = 11;
            button2.Text = "부서등록";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserControl13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "UserControl13";
            Size = new Size(706, 389);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}
