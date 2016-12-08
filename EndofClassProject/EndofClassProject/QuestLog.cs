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
            foreach (Quest val in quest)
            {
                questLogListBox.Items.Add(val.questName);
                val.checkQuest();

            }
            questLogListBox.SelectedIndex = 0;
            if (questLogListBox.SelectedIndex == 0)
            {
                if (quest[0].state == 1)
                {
                    questLogTextBox.Text = quest[0].description;
                }
                else
                {
                    questLogTextBox.Text = "I don't have that Quest yet";
                }
            }
            else if (questLogListBox.SelectedIndex == 1)
            {
                if (quest[1].state == 1)
                {
                    questLogTextBox.Text = quest[1].description;
                }
                else
                {
                    questLogTextBox.Text = "I don't have that Quest yet";
                }
    }
            else if (questLogListBox.SelectedIndex == 1)
            {
                 if (quest[1].state.Equals(1))
                {
                    questLogTextBox.Text = quest[1].description;
                }
                else
                {
                    questLogTextBox.Text = "I don't have that Quest yet";
                }
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
