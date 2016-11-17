using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndofClassProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void questLogButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            QuestLog questLog = new QuestLog();
            questLog.ShowDialog();
            
        }
    }
}
