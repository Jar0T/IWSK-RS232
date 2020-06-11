namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.rateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.charComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowControlComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.terminatorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.terminatorTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transmissionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pingButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.timeoutComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(111, 10);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 1;
            // 
            // rateComboBox
            // 
            this.rateComboBox.FormattingEnabled = true;
            this.rateComboBox.Location = new System.Drawing.Point(111, 49);
            this.rateComboBox.Name = "rateComboBox";
            this.rateComboBox.Size = new System.Drawing.Size(121, 21);
            this.rateComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Szybkość:";
            // 
            // charComboBox
            // 
            this.charComboBox.FormattingEnabled = true;
            this.charComboBox.Location = new System.Drawing.Point(111, 87);
            this.charComboBox.Name = "charComboBox";
            this.charComboBox.Size = new System.Drawing.Size(121, 21);
            this.charComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Format znaku:";
            // 
            // flowControlComboBox
            // 
            this.flowControlComboBox.FormattingEnabled = true;
            this.flowControlComboBox.Location = new System.Drawing.Point(111, 127);
            this.flowControlComboBox.Name = "flowControlComboBox";
            this.flowControlComboBox.Size = new System.Drawing.Size(121, 21);
            this.flowControlComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kontrola przepływu:";
            // 
            // terminatorComboBox
            // 
            this.terminatorComboBox.FormattingEnabled = true;
            this.terminatorComboBox.Location = new System.Drawing.Point(111, 166);
            this.terminatorComboBox.Name = "terminatorComboBox";
            this.terminatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.terminatorComboBox.TabIndex = 9;
            this.terminatorComboBox.SelectedIndexChanged += new System.EventHandler(this.terminatorComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Terminator:";
            // 
            // terminatorTextBox
            // 
            this.terminatorTextBox.Enabled = false;
            this.terminatorTextBox.Location = new System.Drawing.Point(111, 211);
            this.terminatorTextBox.Name = "terminatorTextBox";
            this.terminatorTextBox.Size = new System.Drawing.Size(121, 20);
            this.terminatorTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Własny terminator:";
            // 
            // transmissionTypeComboBox
            // 
            this.transmissionTypeComboBox.FormattingEnabled = true;
            this.transmissionTypeComboBox.Location = new System.Drawing.Point(111, 251);
            this.transmissionTypeComboBox.Name = "transmissionTypeComboBox";
            this.transmissionTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.transmissionTypeComboBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tryb transmisji:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(34, 348);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pingButton
            // 
            this.pingButton.Enabled = false;
            this.pingButton.Location = new System.Drawing.Point(145, 348);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(75, 23);
            this.pingButton.TabIndex = 15;
            this.pingButton.Text = "Ping";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(270, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(518, 390);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(351, 418);
            this.messageTextBox.MaxLength = 128;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(437, 20);
            this.messageTextBox.TabIndex = 18;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(270, 416);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 19;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // timeoutComboBox
            // 
            this.timeoutComboBox.FormattingEnabled = true;
            this.timeoutComboBox.Location = new System.Drawing.Point(111, 288);
            this.timeoutComboBox.Name = "timeoutComboBox";
            this.timeoutComboBox.Size = new System.Drawing.Size(121, 21);
            this.timeoutComboBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Timeout:";
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(34, 391);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 22;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.timeoutComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pingButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.transmissionTypeComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.terminatorTextBox);
            this.Controls.Add(this.terminatorComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowControlComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.charComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rateComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RS232";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ComboBox rateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox charComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox flowControlComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox terminatorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox terminatorTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox transmissionTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox timeoutComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button stopButton;
    }
}

