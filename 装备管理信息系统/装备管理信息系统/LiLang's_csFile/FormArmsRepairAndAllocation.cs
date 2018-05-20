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
    public partial class FormArmsRepairAndAllocation : Form
    {
        public FormArmsRepairAndAllocation()
        {
            InitializeComponent();
        }

        //退出
        private void buttonExitArmsRepairAndAllocation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //显示装备维修管理
        private void buttonArmsRepair_Click(object sender, EventArgs e)
        {
            new FormArmsRepairManage().Show();
        }

        //显示装备调拨管理
        private void buttonArmsAllocation_Click(object sender, EventArgs e)
        {
            new FormArmsAllocationManage().Show();
        }
    }
}
