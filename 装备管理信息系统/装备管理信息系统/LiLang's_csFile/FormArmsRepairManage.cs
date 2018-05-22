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
    public partial class FormArmsRepairManage : Form
    {
        public FormArmsRepairManage()
        {
            InitializeComponent();
        }

        //添加
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new FormArmsRepairAdd().Show();
        }

        //删除
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        //修改
        private void buttonModify_Click(object sender, EventArgs e)
        {
            new FormArmsRepairModify().Show();
        }

        //修改完成
        private void buttonRepairOK_Click(object sender, EventArgs e)
        {
            new FormRepairFinishConfirm().Show();
        }

        //取消
        private void buttonMyCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
