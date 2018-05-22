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
    public partial class 装备基本信息管理 : Form
    {
        public 装备基本信息管理()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            编辑装备信息 to_bjzbxx = new 编辑装备信息();
            to_bjzbxx.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            编辑装备信息 to_bjzbxx = new 编辑装备信息();
            to_bjzbxx.Show();
        }
    }
}
