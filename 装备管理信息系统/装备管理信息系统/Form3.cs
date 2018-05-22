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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 mingxi = new Form4();
            mingxi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 ruzhang = new Form5();
            ruzhang.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 shiyong = new Form6();
            shiyong.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
