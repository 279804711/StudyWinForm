using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyWinform
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
            label1.Text = "你好"+GlobalFunc.Instance.AcountG;

        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
            int count = 0;
            try 
            {
                price = int.Parse(textBox1.Text);
                count = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("单价和数量必须为数字");
            }
            int sum = price * count;
            label4.Text = "总价="+sum.ToString();


        }
    }
}
