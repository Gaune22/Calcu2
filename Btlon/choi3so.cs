using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Btlon
{
    public partial class choi3so : Form
    {
        Random random = new Random();
        public choi3so()
        {
            InitializeComponent();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            index frm1 = new index();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a1 = int.Parse(textBox1.Text);
                int b1 = int.Parse(textBox2.Text);
                int c1 = int.Parse(textBox3.Text);
               

                int a = random.Next(1, 40);
                int b = random.Next(1, 40);
                int c = random.Next(1, 40);

                textBox4.Text = a.ToString();
                textBox5.Text = b.ToString();
                textBox6.Text = c.ToString();



                if (a == a1 && b == b1 && c == c1)
                {
                    label3.Text = "Chúc mừng bạn đã trúng cả 3 số";
                    textBox1.BackColor = textBox2.BackColor = textBox3.BackColor = textBox4.BackColor = textBox5.BackColor = textBox6.BackColor = Color.Yellow;
                }

                else
                    label3.Text = "Bạn chưa may mắn, thử lại sau nhé!";
            }
            catch(FormatException )
            {
                label3.Text = "Bạn phải điền số";
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a1 = random.Next(1, 40);
            int b1 = random.Next(1, 40);
            int c1 = random.Next(1, 40);

            textBox1.Text = a1.ToString();
            textBox2.Text = b1.ToString();
            textBox3.Text = c1.ToString();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Result frm2 = new Result();
            this.Hide();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            
            
        }
    }
}
