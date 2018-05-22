using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 装备管理信息系统
{
    public partial class 经费入账管理 : Form
    {
        public 经费入账管理()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            入账 dengji = new 入账();
            dengji.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            入账 xiugai = new 入账();
            xiugai.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            入账 shanchu = new 入账();
            shanchu.Show();
        }
    }
}
