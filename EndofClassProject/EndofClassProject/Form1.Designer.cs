namespace EndofClassProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.combatLogGroupbox = new System.Windows.Forms.GroupBox();
            this.displayTextBox = new System.Windows.Forms.RichTextBox();
            this.combatGroupbox = new System.Windows.Forms.GroupBox();
            this.equipmentGroupbox = new System.Windows.Forms.GroupBox();
            this.playerArmorLabel = new System.Windows.Forms.Label();
            this.playerWeaponLabel = new System.Windows.Forms.Label();
            this.armorLabel = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.enemyGroupbox = new System.Windows.Forms.GroupBox();
            this.mobHPLabel = new System.Windows.Forms.Label();
            this.enemyLevelLabel = new System.Windows.Forms.Label();
            this.mobLevelLabel = new System.Windows.Forms.Label();
            this.enemyDefenseLabel = new System.Windows.Forms.Label();
            this.mobAttackLabel = new System.Windows.Forms.Label();
            this.enemyAttackLabel = new System.Windows.Forms.Label();
            this.mobDefenseLabel = new System.Windows.Forms.Label();
            this.enemyHPLabel = new System.Windows.Forms.Label();
            this.playerGroupbox = new System.Windows.Forms.GroupBox();
            this.playerExpLabel = new System.Windows.Forms.Label();
            this.playerLevelLabel = new System.Windows.Forms.Label();
            this.playerDefenseLabel = new System.Windows.Forms.Label();
            this.expLabel = new System.Windows.Forms.Label();
            this.playerAttackLabel = new System.Windows.Forms.Label();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.attackLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.InventoryGroupbox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playerItemListBox = new System.Windows.Forms.ListBox();
            this.roomGroupbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomItemListBox = new System.Windows.Forms.ListBox();
            this.mobListBox = new System.Windows.Forms.ListBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combatLogGroupbox.SuspendLayout();
            this.combatGroupbox.SuspendLayout();
            this.equipmentGroupbox.SuspendLayout();
            this.enemyGroupbox.SuspendLayout();
            this.playerGroupbox.SuspendLayout();
            this.InventoryGroupbox.SuspendLayout();
            this.roomGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(481, 414);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(18, 414);
            this.commandTextBox.MaxLength = 100;
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(446, 20);
            this.commandTextBox.TabIndex = 14;
            // 
            // combatLogGroupbox
            // 
            this.combatLogGroupbox.Controls.Add(this.displayTextBox);
            this.combatLogGroupbox.Location = new System.Drawing.Point(12, 38);
            this.combatLogGroupbox.Name = "combatLogGroupbox";
            this.combatLogGroupbox.Size = new System.Drawing.Size(577, 359);
            this.combatLogGroupbox.TabIndex = 13;
            this.combatLogGroupbox.TabStop = false;
            this.combatLogGroupbox.Text = "Action Log";
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.displayTextBox.Location = new System.Drawing.Point(6, 19);
            this.displayTextBox.MaxLength = 300;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(560, 330);
            this.displayTextBox.TabIndex = 6;
            this.displayTextBox.Text = "";
            // 
            // combatGroupbox
            // 
            this.combatGroupbox.Controls.Add(this.equipmentGroupbox);
            this.combatGroupbox.Controls.Add(this.enemyGroupbox);
            this.combatGroupbox.Controls.Add(this.playerGroupbox);
            this.combatGroupbox.Controls.Add(this.InventoryGroupbox);
            this.combatGroupbox.Controls.Add(this.roomGroupbox);
            this.combatGroupbox.Location = new System.Drawing.Point(595, 38);
            this.combatGroupbox.Name = "combatGroupbox";
            this.combatGroupbox.Size = new System.Drawing.Size(420, 432);
            this.combatGroupbox.TabIndex = 12;
            this.combatGroupbox.TabStop = false;
            this.combatGroupbox.Text = "Combat";
            // 
            // equipmentGroupbox
            // 
            this.equipmentGroupbox.Controls.Add(this.playerArmorLabel);
            this.equipmentGroupbox.Controls.Add(this.playerWeaponLabel);
            this.equipmentGroupbox.Controls.Add(this.armorLabel);
            this.equipmentGroupbox.Controls.Add(this.weaponLabel);
            this.equipmentGroupbox.Location = new System.Drawing.Point(215, 19);
            this.equipmentGroupbox.Name = "equipmentGroupbox";
            this.equipmentGroupbox.Size = new System.Drawing.Size(187, 118);
            this.equipmentGroupbox.TabIndex = 1;
            this.equipmentGroupbox.TabStop = false;
            this.equipmentGroupbox.Text = "Equipment";
            // 
            // playerArmorLabel
            // 
            this.playerArmorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerArmorLabel.Location = new System.Drawing.Point(9, 89);
            this.playerArmorLabel.Name = "playerArmorLabel";
            this.playerArmorLabel.Size = new System.Drawing.Size(172, 23);
            this.playerArmorLabel.TabIndex = 3;
            this.playerArmorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerWeaponLabel
            // 
            this.playerWeaponLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerWeaponLabel.Location = new System.Drawing.Point(9, 37);
            this.playerWeaponLabel.Name = "playerWeaponLabel";
            this.playerWeaponLabel.Size = new System.Drawing.Size(172, 23);
            this.playerWeaponLabel.TabIndex = 2;
            this.playerWeaponLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // armorLabel
            // 
            this.armorLabel.AutoSize = true;
            this.armorLabel.Location = new System.Drawing.Point(6, 68);
            this.armorLabel.Name = "armorLabel";
            this.armorLabel.Size = new System.Drawing.Size(37, 13);
            this.armorLabel.TabIndex = 1;
            this.armorLabel.Text = "Armor:";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(6, 16);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(51, 13);
            this.weaponLabel.TabIndex = 0;
            this.weaponLabel.Text = "Weapon:";
            // 
            // enemyGroupbox
            // 
            this.enemyGroupbox.Controls.Add(this.mobHPLabel);
            this.enemyGroupbox.Controls.Add(this.enemyLevelLabel);
            this.enemyGroupbox.Controls.Add(this.mobLevelLabel);
            this.enemyGroupbox.Controls.Add(this.enemyDefenseLabel);
            this.enemyGroupbox.Controls.Add(this.mobAttackLabel);
            this.enemyGroupbox.Controls.Add(this.enemyAttackLabel);
            this.enemyGroupbox.Controls.Add(this.mobDefenseLabel);
            this.enemyGroupbox.Controls.Add(this.enemyHPLabel);
            this.enemyGroupbox.Location = new System.Drawing.Point(6, 175);
            this.enemyGroupbox.Name = "enemyGroupbox";
            this.enemyGroupbox.Size = new System.Drawing.Size(198, 118);
            this.enemyGroupbox.TabIndex = 0;
            this.enemyGroupbox.TabStop = false;
            this.enemyGroupbox.Text = "Enemy";
            // 
            // mobHPLabel
            // 
            this.mobHPLabel.AutoSize = true;
            this.mobHPLabel.Location = new System.Drawing.Point(32, 16);
            this.mobHPLabel.Name = "mobHPLabel";
            this.mobHPLabel.Size = new System.Drawing.Size(25, 13);
            this.mobHPLabel.TabIndex = 0;
            this.mobHPLabel.Text = "HP:";
            // 
            // enemyLevelLabel
            // 
            this.enemyLevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyLevelLabel.Location = new System.Drawing.Point(63, 89);
            this.enemyLevelLabel.Name = "enemyLevelLabel";
            this.enemyLevelLabel.Size = new System.Drawing.Size(119, 23);
            this.enemyLevelLabel.TabIndex = 1;
            this.enemyLevelLabel.Text = "0";
            this.enemyLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobLevelLabel
            // 
            this.mobLevelLabel.AutoSize = true;
            this.mobLevelLabel.Location = new System.Drawing.Point(21, 94);
            this.mobLevelLabel.Name = "mobLevelLabel";
            this.mobLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.mobLevelLabel.TabIndex = 0;
            this.mobLevelLabel.Text = "Level:";
            // 
            // enemyDefenseLabel
            // 
            this.enemyDefenseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyDefenseLabel.Location = new System.Drawing.Point(63, 63);
            this.enemyDefenseLabel.Name = "enemyDefenseLabel";
            this.enemyDefenseLabel.Size = new System.Drawing.Size(119, 23);
            this.enemyDefenseLabel.TabIndex = 1;
            this.enemyDefenseLabel.Text = "0";
            this.enemyDefenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobAttackLabel
            // 
            this.mobAttackLabel.AutoSize = true;
            this.mobAttackLabel.Location = new System.Drawing.Point(16, 42);
            this.mobAttackLabel.Name = "mobAttackLabel";
            this.mobAttackLabel.Size = new System.Drawing.Size(41, 13);
            this.mobAttackLabel.TabIndex = 0;
            this.mobAttackLabel.Text = "Attack:";
            // 
            // enemyAttackLabel
            // 
            this.enemyAttackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyAttackLabel.Location = new System.Drawing.Point(63, 37);
            this.enemyAttackLabel.Name = "enemyAttackLabel";
            this.enemyAttackLabel.Size = new System.Drawing.Size(119, 23);
            this.enemyAttackLabel.TabIndex = 1;
            this.enemyAttackLabel.Text = "0";
            this.enemyAttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobDefenseLabel
            // 
            this.mobDefenseLabel.AutoSize = true;
            this.mobDefenseLabel.Location = new System.Drawing.Point(7, 68);
            this.mobDefenseLabel.Name = "mobDefenseLabel";
            this.mobDefenseLabel.Size = new System.Drawing.Size(50, 13);
            this.mobDefenseLabel.TabIndex = 0;
            this.mobDefenseLabel.Text = "Defense:";
            // 
            // enemyHPLabel
            // 
            this.enemyHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyHPLabel.Location = new System.Drawing.Point(63, 11);
            this.enemyHPLabel.Name = "enemyHPLabel";
            this.enemyHPLabel.Size = new System.Drawing.Size(119, 23);
            this.enemyHPLabel.TabIndex = 1;
            this.enemyHPLabel.Text = "0";
            this.enemyHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerGroupbox
            // 
            this.playerGroupbox.Controls.Add(this.playerExpLabel);
            this.playerGroupbox.Controls.Add(this.playerLevelLabel);
            this.playerGroupbox.Controls.Add(this.playerDefenseLabel);
            this.playerGroupbox.Controls.Add(this.expLabel);
            this.playerGroupbox.Controls.Add(this.playerAttackLabel);
            this.playerGroupbox.Controls.Add(this.playerHPLabel);
            this.playerGroupbox.Controls.Add(this.levelLabel);
            this.playerGroupbox.Controls.Add(this.defenseLabel);
            this.playerGroupbox.Controls.Add(this.attackLabel);
            this.playerGroupbox.Controls.Add(this.hpLabel);
            this.playerGroupbox.Location = new System.Drawing.Point(6, 19);
            this.playerGroupbox.Name = "playerGroupbox";
            this.playerGroupbox.Size = new System.Drawing.Size(198, 150);
            this.playerGroupbox.TabIndex = 0;
            this.playerGroupbox.TabStop = false;
            this.playerGroupbox.Text = "Player";
            // 
            // playerExpLabel
            // 
            this.playerExpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerExpLabel.Location = new System.Drawing.Point(61, 113);
            this.playerExpLabel.Name = "playerExpLabel";
            this.playerExpLabel.Size = new System.Drawing.Size(119, 23);
            this.playerExpLabel.TabIndex = 1;
            this.playerExpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerLevelLabel
            // 
            this.playerLevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerLevelLabel.Location = new System.Drawing.Point(61, 89);
            this.playerLevelLabel.Name = "playerLevelLabel";
            this.playerLevelLabel.Size = new System.Drawing.Size(119, 23);
            this.playerLevelLabel.TabIndex = 1;
            this.playerLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerDefenseLabel
            // 
            this.playerDefenseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerDefenseLabel.Location = new System.Drawing.Point(61, 63);
            this.playerDefenseLabel.Name = "playerDefenseLabel";
            this.playerDefenseLabel.Size = new System.Drawing.Size(119, 23);
            this.playerDefenseLabel.TabIndex = 1;
            this.playerDefenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(28, 118);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(28, 13);
            this.expLabel.TabIndex = 0;
            this.expLabel.Text = "Exp:";
            // 
            // playerAttackLabel
            // 
            this.playerAttackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerAttackLabel.Location = new System.Drawing.Point(61, 37);
            this.playerAttackLabel.Name = "playerAttackLabel";
            this.playerAttackLabel.Size = new System.Drawing.Size(119, 23);
            this.playerAttackLabel.TabIndex = 1;
            this.playerAttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHPLabel.Location = new System.Drawing.Point(61, 11);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(119, 23);
            this.playerHPLabel.TabIndex = 1;
            this.playerHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(20, 94);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(36, 13);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "Level:";
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(6, 68);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(50, 13);
            this.defenseLabel.TabIndex = 0;
            this.defenseLabel.Text = "Defense:";
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(15, 42);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(41, 13);
            this.attackLabel.TabIndex = 0;
            this.attackLabel.Text = "Attack:";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(31, 16);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(25, 13);
            this.hpLabel.TabIndex = 0;
            this.hpLabel.Text = "HP:";
            // 
            // InventoryGroupbox
            // 
            this.InventoryGroupbox.Controls.Add(this.label5);
            this.InventoryGroupbox.Controls.Add(this.playerItemListBox);
            this.InventoryGroupbox.Location = new System.Drawing.Point(210, 164);
            this.InventoryGroupbox.Name = "InventoryGroupbox";
            this.InventoryGroupbox.Size = new System.Drawing.Size(192, 131);
            this.InventoryGroupbox.TabIndex = 4;
            this.InventoryGroupbox.TabStop = false;
            this.InventoryGroupbox.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Items";
            // 
            // playerItemListBox
            // 
            this.playerItemListBox.FormattingEnabled = true;
            this.playerItemListBox.Location = new System.Drawing.Point(6, 30);
            this.playerItemListBox.Name = "playerItemListBox";
            this.playerItemListBox.Size = new System.Drawing.Size(180, 82);
            this.playerItemListBox.Sorted = true;
            this.playerItemListBox.TabIndex = 0;
            // 
            // roomGroupbox
            // 
            this.roomGroupbox.Controls.Add(this.label3);
            this.roomGroupbox.Controls.Add(this.label2);
            this.roomGroupbox.Controls.Add(this.roomItemListBox);
            this.roomGroupbox.Controls.Add(this.mobListBox);
            this.roomGroupbox.Location = new System.Drawing.Point(6, 301);
            this.roomGroupbox.Name = "roomGroupbox";
            this.roomGroupbox.Size = new System.Drawing.Size(396, 125);
            this.roomGroupbox.TabIndex = 2;
            this.roomGroupbox.TabStop = false;
            this.roomGroupbox.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inhabitants";
            // 
            // roomItemListBox
            // 
            this.roomItemListBox.FormattingEnabled = true;
            this.roomItemListBox.Location = new System.Drawing.Point(210, 30);
            this.roomItemListBox.Name = "roomItemListBox";
            this.roomItemListBox.Size = new System.Drawing.Size(180, 82);
            this.roomItemListBox.Sorted = true;
            this.roomItemListBox.TabIndex = 0;
            // 
            // mobListBox
            // 
            this.mobListBox.FormattingEnabled = true;
            this.mobListBox.Location = new System.Drawing.Point(6, 30);
            this.mobListBox.Name = "mobListBox";
            this.mobListBox.Size = new System.Drawing.Size(180, 82);
            this.mobListBox.Sorted = true;
            this.mobListBox.TabIndex = 0;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNameLabel.Location = new System.Drawing.Point(59, 12);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(101, 21);
            this.roomNameLabel.TabIndex = 11;
            this.roomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Room:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 487);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.combatLogGroupbox);
            this.Controls.Add(this.combatGroupbox);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.combatLogGroupbox.ResumeLayout(false);
            this.combatGroupbox.ResumeLayout(false);
            this.equipmentGroupbox.ResumeLayout(false);
            this.equipmentGroupbox.PerformLayout();
            this.enemyGroupbox.ResumeLayout(false);
            this.enemyGroupbox.PerformLayout();
            this.playerGroupbox.ResumeLayout(false);
            this.playerGroupbox.PerformLayout();
            this.InventoryGroupbox.ResumeLayout(false);
            this.InventoryGroupbox.PerformLayout();
            this.roomGroupbox.ResumeLayout(false);
            this.roomGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.GroupBox combatLogGroupbox;
        private System.Windows.Forms.RichTextBox displayTextBox;
        private System.Windows.Forms.GroupBox combatGroupbox;
        private System.Windows.Forms.GroupBox equipmentGroupbox;
        private System.Windows.Forms.Label playerArmorLabel;
        private System.Windows.Forms.Label playerWeaponLabel;
        private System.Windows.Forms.Label armorLabel;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.GroupBox enemyGroupbox;
        private System.Windows.Forms.Label mobHPLabel;
        private System.Windows.Forms.Label enemyLevelLabel;
        private System.Windows.Forms.Label mobLevelLabel;
        private System.Windows.Forms.Label enemyDefenseLabel;
        private System.Windows.Forms.Label mobAttackLabel;
        private System.Windows.Forms.Label enemyAttackLabel;
        private System.Windows.Forms.Label mobDefenseLabel;
        private System.Windows.Forms.Label enemyHPLabel;
        private System.Windows.Forms.GroupBox playerGroupbox;
        private System.Windows.Forms.Label playerExpLabel;
        private System.Windows.Forms.Label playerLevelLabel;
        private System.Windows.Forms.Label playerDefenseLabel;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Label playerAttackLabel;
        private System.Windows.Forms.Label playerHPLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.GroupBox InventoryGroupbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox playerItemListBox;
        private System.Windows.Forms.GroupBox roomGroupbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox roomItemListBox;
        private System.Windows.Forms.ListBox mobListBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label label1;
    }
}

