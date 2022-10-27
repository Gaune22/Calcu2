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
    public partial class choi4so : Form
    {
        Random rand = new Random();
        public choi4so()
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


                int a = rand.Next(1, 40);
                int b = rand.Next(1, 40);
                int c = rand.Next(1, 40);
                int d = rand.Next(1, 40);


                label7.Text = a.ToString();
                label8.Text = b.ToString();
                label9.Text = c.ToString();
                label10.Text = d.ToString();




                if (a == a1 && b == b1 && c == c1)
                {
                    label3.Text = "Chúc mừng bạn đã trúng được 3 số";
                    textBox1.BackColor = textBox2.BackColor = textBox3.BackColor =
                        label7.BackColor = label8.BackColor = label9.BackColor = Color.DarkCyan;
                }
                else if (a == a1 && b == b1 && d == d1)
                {
                    label3.Text = "Chúc mừng bạn đã trúng được 3 số";
                    textBox1.BackColor = textBox2.BackColor = textBox4.BackColor =
                        label7.BackColor = label8.BackColor = label10.BackColor = Color.DarkCyan;
                }
                else if (a == a1 && c == c1 && d == d1)
                {
                    label3.Text = "Chúc mừng bạn đã trúng được 3 số";
                    textBox1.BackColor = textBox3.BackColor = textBox4.BackColor =
                        label7.BackColor = label9.BackColor = label10.BackColor = Color.DarkCyan;
                }
                else if (b == b1 && c == c1 && d == d1)
                {
                    label3.Text = "Chúc mừng bạn đã trúng được 3 số";
                    textBox4.BackColor = textBox2.BackColor = textBox3.BackColor =
                        label10.BackColor = label8.BackColor = label9.BackColor = Color.DarkCyan;
                }
                else if (a == a1 && b == b1 && c == c1 && d == d1)
                {
                    label3.Text="Chúc mừng bạn đã trúng được 4 số";
                    textBox1.BackColor = textBox2.BackColor = textBox3.BackColor = textBox4.BackColor =
                        label7.BackColor = label8.BackColor = label9.BackColor = label10.BackColor = Color.DarkCyan;
                }

                else
                    label3.Text = "Bạn chưa may mắn, thử lại nhé!"; 
            }
            
        
            catch(FormatException)
            {
                label3.Text = "Bạn phải điền số" ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a1 = rand.Next(1, 40);
            int b1 = rand.Next(1, 40);
            int c1 = rand.Next(1, 40);
            int d1 = rand.Next(1, 40);

            textBox1.Text = a1.ToString();
            textBox2.Text = b1.ToString();
            textBox3.Text = c1.ToString();
            textBox4.Text = d1.ToString();
        }
    }
}
