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
        Command com = new Command();
        public Form1()
        {
            InitializeComponent();
            Player.setBaseStats();
            displayTextBox.AppendText(com.Handler("look"));
            //playerItemListBox.DataSource = Player.Inventory;
            //playerItemListBox.DisplayMember = Player.Inventory.ToString();
            //roomItemListBox.DataSource = com.world.worldList[Player.Location].itemList;
            //roomItemListBox.DisplayMember = com.world.worldList[Player.Location].itemList.ToString();
        }

        private void questLogButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            QuestLog questLog = new QuestLog();
            questLog.ShowDialog();

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            displayTextBox.AppendText("\n" + com.Handler(commandTextBox.Text));

            commandTextBox.SelectionStart = 0;
            commandTextBox.SelectionLength = commandTextBox.Text.Length;

            //this is to force items to show up in the inventory and room item listboxes.
        }

        private void guiTimer_Tick(object sender, EventArgs e)
        {
            //this will update the player stats every tick.
            playerArmorLabel.Text = Player.Armor.ToString();
            playerHPLabel.Text = Player.HP.ToString();
            playerAttackLabel.Text = Player.ATK.ToString();
            playerDefenseLabel.Text = Player.AC.ToString();
            playerLevelLabel.Text = Player.Lvl.ToString();
            playerExpLabel.Text = Player.EXP.ToString();

            //this will update the equipment labels every tick.
            playerWeaponLabel.Text = Player.Weapon.Name.ToString();
            playerArmorLabel.Text = Player.Armor.Name.ToString();
        }
    }
}
