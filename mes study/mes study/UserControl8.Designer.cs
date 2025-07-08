namespace mes_study
{
    partial class UserControl8
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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(32, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(648, 307);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "";
            columnHeader0.Width = 25;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "이름";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "아이디";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "생년월일";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "연락처";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "부서";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "등록일";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 5;
            label1.Text = "직원 목록";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(440, 19);
            button2.Name = "button2";
            button2.Size = new Size(76, 28);
            button2.TabIndex = 9;
            button2.Text = "수정";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(522, 19);
            button1.Name = "button1";
            button1.Size = new Size(76, 28);
            button1.TabIndex = 8;
            button1.Text = "상세보기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(329, 19);
            button3.Name = "button3";
            button3.Size = new Size(105, 28);
            button3.TabIndex = 10;
            button3.Text = "비밀번호 초기화";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(604, 19);
            button4.Name = "button4";
            button4.Size = new Size(76, 28);
            button4.TabIndex = 11;
            button4.Text = " 직원등록";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UserControl8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "UserControl8";
            Size = new Size(706, 389);
            Load += UserControl8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}
