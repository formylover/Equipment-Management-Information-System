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
    public partial class 基本信息管理 : Form
    {
        public 基本信息管理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            装备基本信息管理 to_zb = new 装备基本信息管理();
            to_zb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            部门基本信息管理 to_bm = new 部门基本信息管理();
            to_bm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            人员基本信息管理 to_ry = new 人员基本信息管理();
            to_ry.Show();
        }
    }
}
