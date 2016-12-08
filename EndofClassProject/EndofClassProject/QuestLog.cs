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
    public partial class QuestLog : Form
    {
        List<Quest> Quest;

        public QuestLog()
        {
            InitializeComponent();
        }
        public QuestLog(List<Quest> quest)
        {
            InitializeComponent();
            Quest = quest;
            foreach(Quest val in quest)
            {
                questLogListBox.Items.Add(val.questName);
            }
            
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void questLogListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            questLogTextBox.Text = Quest[questLogListBox.SelectedIndex].questName;
        }
    }
}
