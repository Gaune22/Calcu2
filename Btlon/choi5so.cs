using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btlon
{
    public partial class choi5so : Form
    {
        Random rand = new Random();
        public choi5so()
        {
            InitializeComponent();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            index frm1 = new index();
            this.Hide();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a1 = int.Parse(textBox1.Text);
                int b1 = int.Parse(textBox2.Text);
                int c1 = int.Parse(textBox3.Text);
                int d1 = int.Parse(textBox4.Text);
                int f1 = int.Parse(textBox5.Text);

                int a = rand.Next(1, 40);
                int b = rand.Next(1, 40);
                int c = rand.Next(1, 40);
                int d = rand.Next(1, 40);
                int f = rand.Next(1, 40);

                label2.Text = a.ToString();
                label3.Text = b.ToString();
                label4.Text = c.ToString();
                label5.Text = d.ToString();
                label6.Text = f.ToString();

                

                if ((a == a1 && b == b1 && c == c1) || (a == a1 && b == b1 && d == d1) || (a == a1 && b == b1 && f == f1) || (a == a1 && f == f1 && c == c1) || (a == a1 && d == d1 && c == c1) || (a == a1 && d == d1 && f == f1) ||
                    (b == b1 && c == c1 && d == d1) || (b == b1 && c == c1 && f == f1) || (b == b1 && d == d1 && f == f1) || (c == c1 && d == d1 && f == f1))
                    label8.Text = "Chúc mừng bạn trúng được 3 số!";

                else if ((a == a1 && b == b1 && c == c1 && d == d1) || (a == a1 && b == b1 && c == c1 && f == f1) || (a == a1 && b == b1 && f == f1 && d == d1) || (f == f1 && b == b1 && c == c1 && d == d1))
                    label8.Text = "Chúc mừng bạn trúng được 4 số!";
                else if (a == a1 && b == b1 && c == c1 && d == d1 && f == f1)
                    label8.Text = "Chúc mừng bạn trúng được 5 số!";
                else
                    label8.Text = "Bạn chưa may mắn, thử lại nhé!";
            }
            catch (FormatException)
            {
                label8.Text = "Bạn phải mua vé!";
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a1 = rand.Next(1, 40);
            int b1 = rand.Next(1, 40);
            int c1 = rand.Next(1, 40);
            int d1 = rand.Next(1, 40);
            int f1 = rand.Next(1, 40);

            textBox1.Text = a1.ToString();
            textBox2.Text = b1.ToString();
            textBox3.Text = c1.ToString();
            textBox4.Text = d1.ToString();
            textBox5.Text = f1.ToString();
        }
    }
}
// a b c d f

// 3 so
// a b c
// a b d
// a b f
// a c f
// a c d
// a d f 
// b c d 
// b c f
// b d f 
// c d f

// 4 so 
// a b c d 
// a b c f
// a b d f 
// b c d f 
