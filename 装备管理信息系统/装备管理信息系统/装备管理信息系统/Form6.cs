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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 tianjia = new Form9();
            tianjia.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 shanchu = new Form9();
            shanchu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 xiugai = new Form9();
            xiugai.Show();
        }
    }
}
