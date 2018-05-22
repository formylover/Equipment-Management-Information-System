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
    public partial class 人员基本信息管理 : Form
    {
        public 人员基本信息管理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            编辑人员信息 to_ryxx = new 编辑人员信息();
            to_ryxx.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            编辑人员信息 to_ryxx = new 编辑人员信息();
            to_ryxx.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            编辑人员部门调转 change_bm = new 编辑人员部门调转();
            change_bm.Show();
        }
    }
}
