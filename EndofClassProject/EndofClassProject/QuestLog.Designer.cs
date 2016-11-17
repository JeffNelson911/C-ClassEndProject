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
            this.questLogListBox.Location = new System.Drawing.Point(12, 25);
            this.questLogListBox.Name = "questLogListBox";
            this.questLogListBox.ScrollAlwaysVisible = true;
            this.questLogListBox.Size = new System.Drawing.Size(190, 160);
            this.questLogListBox.TabIndex = 0;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(169, 191);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // questLogTextBox
            // 
            this.questLogTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.questLogTextBox.Location = new System.Drawing.Point(210, 25);
            this.questLogTextBox.Name = "questLogTextBox";
            this.questLogTextBox.ReadOnly = true;
            this.questLogTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.questLogTextBox.Size = new System.Drawing.Size(203, 160);
            this.questLogTextBox.TabIndex = 2;
            this.questLogTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // QuestLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questLogTextBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.questLogListBox);
            this.Name = "QuestLog";
            this.Text = "QuestLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox questLogListBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.RichTextBox questLogTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}