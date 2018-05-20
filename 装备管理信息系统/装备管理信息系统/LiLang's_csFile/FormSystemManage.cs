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
    public partial class FormSystemManage : Form
    {
        public FormSystemManage()
        {
            InitializeComponent();
        }

        //退出
        private void buttonExitSystemManage_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("你确定要退出吗？","提示",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //显示用户管理
        private void buttonUserManage_Click(object sender, EventArgs e)
        {
            new FormUserManage().Show();
        }

        //显示密码修改
        private void buttonPwdModify_Click(object sender, EventArgs e)
        {
            new FormPwdModify().Show();
        }

        //显示日志管理
        private void buttonLogManage_Click(object sender, EventArgs e)
        {
            new FormLogManage().Show();
        }
    }
}
