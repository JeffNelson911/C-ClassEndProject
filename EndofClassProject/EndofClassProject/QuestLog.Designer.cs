namespace EndofClassProject
{
    partial class QuestLog
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
            this.questLogListBox = new System.Windows.Forms.ListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.questLogTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questLogListBox
            // 
            this.questLogListBox.FormattingEnabled = true;
            this.questLogListBox.ItemHeight = 16;
            this.questLogListBox.Location = new System.Drawing.Point(16, 31);
            this.questLogListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.questLogListBox.Name = "questLogListBox";
            this.questLogListBox.Size = new System.Drawing.Size(252, 196);
            this.questLogListBox.TabIndex = 0;
            this.questLogListBox.SelectedValueChanged += new System.EventHandler(this.questLogListBox_SelectedValueChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(225, 235);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 28);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // questLogTextBox
            // 
            this.questLogTextBox.BackColor = System.Drawing.Color.White;
            this.questLogTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.questLogTextBox.Location = new System.Drawing.Point(280, 31);
            this.questLogTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.questLogTextBox.Name = "questLogTextBox";
            this.questLogTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.questLogTextBox.Size = new System.Drawing.Size(269, 196);
            this.questLogTextBox.TabIndex = 2;
            this.questLogTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // QuestLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questLogTextBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.questLogListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuestLog";
            this.Text = "QuestLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox questLogListBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox questLogTextBox;
    }
}