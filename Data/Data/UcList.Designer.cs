namespace Data
{
    partial class UcList
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
            label2 = new Label();
            listView1 = new ListView();
            순번 = new ColumnHeader();
            품명 = new ColumnHeader();
            수량 = new ColumnHeader();
            단위 = new ColumnHeader();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(30, 15);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 2;
            label2.Text = "자재 목록";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { 순번, 품명, 수량, 단위 });
            listView1.Location = new Point(38, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(474, 328);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // 순번
            // 
            순번.Text = "순번";
            // 
            // 품명
            // 
            품명.Text = "품명";
            품명.TextAlign = HorizontalAlignment.Center;
            품명.Width = 200;
            // 
            // 수량
            // 
            수량.Text = "수량";
            수량.TextAlign = HorizontalAlignment.Center;
            수량.Width = 70;
            // 
            // 단위
            // 
            단위.Text = "단위";
            단위.TextAlign = HorizontalAlignment.Center;
            // 
            // UcList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listView1);
            Controls.Add(label2);
            Name = "UcList";
            Size = new Size(549, 421);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ListView listView1;
        private ColumnHeader 순번;
        private ColumnHeader 품명;
        private ColumnHeader 수량;
        private ColumnHeader 단위;
    }
}
