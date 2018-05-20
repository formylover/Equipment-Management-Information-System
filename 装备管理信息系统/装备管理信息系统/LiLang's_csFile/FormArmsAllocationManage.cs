using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 装备管理信息系统.LiLang_s_csFile;

namespace 装备管理信息系统
{
    public partial class FormArmsAllocationManage : Form
    {
        public FormArmsAllocationManage()
        {
            InitializeComponent();
        }

        //显示添加窗口
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new FormArmsAllocationAdd().Show();
        }

        //显示删除窗口
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        //显示修改窗口
        private void buttonModify_Click(object sender, EventArgs e)
        {
            new FormArmsAllocationModify().Show();
        }

        //显示取消窗口
        private void buttonMyCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
