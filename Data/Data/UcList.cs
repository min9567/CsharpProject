using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class UcList : UserControl
    {
        public UcList()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ItemStore.Items;
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // DataGridView 객체를 grid 변수에 저장
            var grid = sender as DataGridView;
            // 행번호 표시
            string rowIdx = (e.RowIndex + 1).ToString(); // 1번부터 시작

            // 글자 정렬 방식 지정
            var centerFormat = new StringFormat()
            {
                // 수평
                Alignment = StringAlignment.Center,
                // 수직
                LineAlignment = StringAlignment.Center
            };

            // 행 머리글(맨 앞 빈 칸) 영역의 위치와 크기 정보
            Rectangle headerBounds = new Rectangle(
                e.RowBounds.Left, e.RowBounds.Top,
                grid.RowHeadersWidth, e.RowBounds.Height);

            // 위에서 지정한 영역(headerBounds)에 행 번호(rowIdx)를 DataGridView의 폰트, 기본 텍스트 색상으로 가운데 정렬로 출력
            e.Graphics.DrawString(
                rowIdx, grid.Font, SystemBrushes.ControlText,
                headerBounds, centerFormat);
        }
    }
}
