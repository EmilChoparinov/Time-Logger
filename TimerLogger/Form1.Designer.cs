namespace TimerLogger
{
    partial class TimeLogger
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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chromeButton = new System.Windows.Forms.Button();
            this.steamButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Black;
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(310, 260);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 434);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(140, 70);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(181, 434);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(141, 70);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 408);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(140, 20);
            this.nameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(77, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chromeButton
            // 
            this.chromeButton.Location = new System.Drawing.Point(11, 299);
            this.chromeButton.Name = "chromeButton";
            this.chromeButton.Size = new System.Drawing.Size(141, 79);
            this.chromeButton.TabIndex = 6;
            this.chromeButton.Text = "Launch Chrome";
            this.chromeButton.UseVisualStyleBackColor = true;
            this.chromeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // steamButton
            // 
            this.steamButton.Location = new System.Drawing.Point(181, 299);
            this.steamButton.Name = "steamButton";
            this.steamButton.Size = new System.Drawing.Size(141, 79);
            this.steamButton.TabIndex = 7;
            this.steamButton.Text = "Launch Steam";
            this.steamButton.UseVisualStyleBackColor = true;
            this.steamButton.Click += new System.EventHandler(this.steamButton_Click);
            // 
            // TimeLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 516);
            this.Controls.Add(this.steamButton);
            this.Controls.Add(this.chromeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBox);
            this.Name = "TimeLogger";
            this.Text = "Time Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button chromeButton;
        private System.Windows.Forms.Button steamButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

