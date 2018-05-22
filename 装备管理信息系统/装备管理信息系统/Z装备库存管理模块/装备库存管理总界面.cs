using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 装备管理信息系统.Z装备库存管理模块;

namespace 装备管理信息系统.Z装备库存管理模块
{
    public partial class 装备库存管理总界面 : Form
    {
        public 装备库存管理总界面()
        {
            InitializeComponent();
        }

        private void 总界面仓库信息管理按钮_Click(object sender, EventArgs e)
        {
            new 装备库存管理.仓库信息管理().Show();
        }

        private void 总界面装备出库管理按钮_Click(object sender, EventArgs e)
        {
            new 装备库存管理.装备出库管理().Show();
        }

        private void 总界面装备入库管理按钮_Click(object sender, EventArgs e)
        {
            new 装备库存管理.装备入库管理().Show();
        }

        private void 总界面库存盘点管理按钮_Click(object sender, EventArgs e)
        {
            new 装备库存管理.库存盘点管理().Show();
        }
    }
}
