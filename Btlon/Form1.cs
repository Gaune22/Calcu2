/*1.Viết chương trình Game Xổ số Vietlote với các yêu cầu sau:
-Chương trình gồm các loại vé: ba số, bốn số, năm số,...
- Cho phép chọn số, mua vé số ngẫu nhiên
- Lưu các số người dùng chọn, lưu kết quả các lượt xổ số vào tập tin
- Cho phép xem lại kết quả các lần quay số trước
- Cho phép tìm kiếm kết quả theo ngày quay số
- Cho phép thống kê số lượt trúng thưởng, giải thưởng
- ... tham khảo thực tế*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Btlon
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void bt3so_Click(object sender, EventArgs e)
        {
            choi3so frm3so = new choi3so();
            this.Hide();
            frm3so.Show();
            
        }

        private void bt4so_Click(object sender,EventArgs e)
        {
            choi4so frm4so = new choi4so();
            this.Hide();
            frm4so.Show();
        }
        private void bt5so_Click(object sender, EventArgs e)
        {
            choi5so frm5So = new choi5so();
            frm5So.Show();
            this.Hide();
        }

    }
}
