using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Data
{
    public partial class UcIn : UserControl
    {
        public UcIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 입력값 읽기
            string name = comboBox1.Text;
            int qty;
            if (!int.TryParse(textBox1.Text, out qty))
            {
                MessageBox.Show("수량에는 숫자만 입력하세요.");
                textBox1.Focus();
                return;
            }
            string user = comboBox2.Text;
            DateTime regDate = DateTime.Now;

            // 객체 생성 및 저장
            var item = new Item
            {
                품명 = name,
                수량 = qty,
                등록자 = user,
                등록일시 = regDate
            };
            ItemStore.Items.Add(item);

            // 입력 완료 후 입력값 초기화, 알림 등
            MessageBox.Show("등록되었습니다!");

            // 등록 완료 후 입력값 초기화
            comboBox1.SelectedIndex = -1;   // 콤보박스 선택 해제 (없으면 0으로 초기화)
            textBox1.Text = "";            // 텍스트박스 값 초기화
            comboBox2.SelectedIndex = -1;  // 두 번째 콤보박스도 선택 해제

            comboBox1.Focus();
        }
    }
}
