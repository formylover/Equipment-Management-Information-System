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
    public partial class 库存盘点管理 : Form
    {
        public 库存盘点管理()
        {
            InitializeComponent();
        }

        private void 盘点_Click(object sender, EventArgs e)
        {
            new 库存盘点管理盘点编辑_管理员_().Show();
        }
    }
}
