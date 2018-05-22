using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 装备库存管理
{
    public partial class 装备出库管理 : Form
    {
        public 装备出库管理()
        {
            InitializeComponent();
        }

        private void 装备出库管理添加_Click(object sender, EventArgs e)
        {
            new 装备出库管理添加().Show();
        }

        private void 装备出库管理修改_Click(object sender, EventArgs e)
        {
            new 装备出库管理修改().Show();
        }
    }
}
