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
    public partial class 仓库信息管理 : Form
    {
        public 仓库信息管理()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new 仓库信息管理添加().Show();
        }

        private void 仓库信息管理修改按钮_Click(object sender, EventArgs e)
        {
            new 仓库信息管理修改().Show();
        }
    }
}
