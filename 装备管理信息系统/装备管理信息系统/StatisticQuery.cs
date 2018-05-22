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
    public partial class StatisticQuery : Form
    {
        public StatisticQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            IO_information io_info = new IO_information();
            io_info.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonInfo pinfo = new PersonInfo();
            pinfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EquipmentStringInfo esi = new EquipmentStringInfo();
            esi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FundingData fd = new FundingData();
            fd.Show();
        }
    }
}
