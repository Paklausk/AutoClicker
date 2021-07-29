namespace AutoClicker
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.leftMouseCheckBox = new System.Windows.Forms.CheckBox();
            this.rightMouseCheckBox = new System.Windows.Forms.CheckBox();
            this.audioCheckBox = new System.Windows.Forms.CheckBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(341, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press interval(ms):";
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(147, 69);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(141, 20);
            this.IntervalTextBox.TabIndex = 2;
            this.IntervalTextBox.Text = "16";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(147, 43);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(141, 20);
            this.KeyTextBox.TabIndex = 4;
            this.KeyTextBox.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key to press:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(52, 118);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start (F11)";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // leftMouseCheckBox
            // 
            this.leftMouseCheckBox.AutoSize = true;
            this.leftMouseCheckBox.Location = new System.Drawing.Point(53, 95);
            this.leftMouseCheckBox.Name = "leftMouseCheckBox";
            this.leftMouseCheckBox.Size = new System.Drawing.Size(79, 17);
            this.leftMouseCheckBox.TabIndex = 6;
            this.leftMouseCheckBox.Text = "Left Mouse";
            this.leftMouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // rightMouseCheckBox
            // 
            this.rightMouseCheckBox.AutoSize = true;
            this.rightMouseCheckBox.Location = new System.Drawing.Point(139, 95);
            this.rightMouseCheckBox.Name = "rightMouseCheckBox";
            this.rightMouseCheckBox.Size = new System.Drawing.Size(86, 17);
            this.rightMouseCheckBox.TabIndex = 7;
            this.rightMouseCheckBox.Text = "Right Mouse";
            this.rightMouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // audioCheckBox
            // 
            this.audioCheckBox.AutoSize = true;
            this.audioCheckBox.Checked = true;
            this.audioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.audioCheckBox.Location = new System.Drawing.Point(214, 122);
            this.audioCheckBox.Name = "audioCheckBox";
            this.audioCheckBox.Size = new System.Drawing.Size(53, 17);
            this.audioCheckBox.TabIndex = 8;
            this.audioCheckBox.Text = "Audio";
            this.audioCheckBox.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(133, 118);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop (F12)";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.StatusLabel.Location = new System.Drawing.Point(92, 148);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(54, 13);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Stopped";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 187);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.audioCheckBox);
            this.Controls.Add(this.rightMouseCheckBox);
            this.Controls.Add(this.leftMouseCheckBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClicker 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.CheckBox leftMouseCheckBox;
        private System.Windows.Forms.CheckBox rightMouseCheckBox;
        private System.Windows.Forms.CheckBox audioCheckBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StatusLabel;
    }
}

