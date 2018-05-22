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
    public partial class 装备经费管理 : Form
    {
        public 装备经费管理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            经费明细管理 mingxi = new 经费明细管理();
            mingxi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            经费入账管理 ruzhang = new 经费入账管理();
            ruzhang.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            经费使用管理 shiyong = new 经费使用管理();
            shiyong.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
