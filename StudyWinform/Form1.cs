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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("我被点击了");

            //先获取账号密码
            string account = textAccount.Text;
            string password = textBox2.Text;

            //验证账号密码
            //if(account == "123" && password == "456")
            //{
            //    MessageBox.Show("账号密码正确");
            //}
            //else
            //{
            //    MessageBox.Show("账号密码不匹配");
            //}
            if(account != "123")
            {
                MessageBox.Show("账号不正确");
                textAccount.Text = "";
                textBox2.Text = "";
                return;
            }

            if(password != "456")
            {
                MessageBox.Show("密码不正确");
                textAccount.Text = "";
                textBox2.Text = "";

                return;
            }
            MessageBox.Show("账号密码正确请登录");

            GlobalFunc.Instance.AcountG = account;

            index index = new index();
            index.Show();
            //this.Hide();
            GlobalFunc.Instance.formLogin.Hide();

        }

        private void textAccount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
