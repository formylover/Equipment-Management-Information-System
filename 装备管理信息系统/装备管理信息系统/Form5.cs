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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 dengji = new Form8();
            dengji.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 xiugai = new Form8();
            xiugai.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 shanchu = new Form8();
            shanchu.Show();
        }
    }
}
