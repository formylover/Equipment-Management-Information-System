using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 装备管理信息系统.LiLang_s_csFile
{
    public partial class FormArmsAllocationModify : Form
    {
        public FormArmsAllocationModify()
        {
            InitializeComponent();
        }

        private void buttonMyCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
