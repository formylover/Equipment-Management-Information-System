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
    public partial class 经费使用管理 : Form
    {
        public 经费使用管理()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            使用 tianjia = new 使用();
            tianjia.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            使用 shanchu = new 使用();
            shanchu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            使用 xiugai = new 使用();
            xiugai.Show();
        }
    }
}
