﻿namespace C_Project
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
            labelorders = new Label();
            labelcustomers = new Label();
            SuspendLayout();
            // 
            // labelorders
            // 
            labelorders.AutoSize = true;
            labelorders.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            labelorders.Location = new Point(12, 0);
            labelorders.Name = "labelorders";
            labelorders.Size = new Size(76, 30);
            labelorders.TabIndex = 5;
            labelorders.Text = "Orders";
            labelorders.Click += labelorders_Click;
            // 
            // labelcustomers
            // 
            labelcustomers.AutoSize = true;
            labelcustomers.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            labelcustomers.Location = new Point(12, 40);
            labelcustomers.Name = "labelcustomers";
            labelcustomers.Size = new Size(112, 30);
            labelcustomers.TabIndex = 6;
            labelcustomers.Text = "Customers";
            labelcustomers.Click += labelcustomers_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelcustomers);
            Controls.Add(labelorders);
            Name = "UserControl3";
            Size = new Size(127, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelorders;
        private Label labelcustomers;
    }
}
