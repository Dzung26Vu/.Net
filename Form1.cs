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

namespace btap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ textBox1
            string textToAdd = textBox1.Text;

            // Kiểm tra xem textBox1 có nội dung hay không
            if (!string.IsNullOrEmpty(textToAdd))
            {
                // Thêm nội dung vào listBox1
                listBox1.Items.Add(textToAdd);

                // Xóa nội dung trong textBox1 sau khi thêm
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung vào TextBox trước khi thêm vào ListBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục từ ListBox để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}