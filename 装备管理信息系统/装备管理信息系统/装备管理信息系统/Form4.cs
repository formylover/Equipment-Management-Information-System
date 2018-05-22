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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 tianjia = new Form7();
            tianjia.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 xiugai = new Form7();
            xiugai.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 shanchu = new Form7();
            shanchu.Show();
        }
    }
}
