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
    public partial class 部门基本信息管理 : Form
    {
        public 部门基本信息管理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            编辑部门信息 to_bm = new 编辑部门信息();
            to_bm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            编辑部门信息 to_bm = new 编辑部门信息();
            to_bm.Show();
        }
    }
}
