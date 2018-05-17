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

        private void FormSystemManage_Load(object sender, EventArgs e)
        {
            MessageBox.Show("显示系统管理的相关信息");
        }
    }
}
