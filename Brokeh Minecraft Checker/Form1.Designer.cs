﻿namespace Brokeh_Minecraft_Checker
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button saveButton;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.socks5 = new System.Windows.Forms.RadioButton();
            this.https = new System.Windows.Forms.RadioButton();
            this.timeoutValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.threadCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.threadsCountLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.countErrorLabel = new System.Windows.Forms.Label();
            this.countBadLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countGoodsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countsTestedsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messageBox = new System.Windows.Forms.TextBox();
            saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timeoutValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.threadCount)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(saveButton);
            this.groupBox1.Controls.Add(this.socks5);
            this.groupBox1.Controls.Add(this.https);
            this.groupBox1.Controls.Add(this.timeoutValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.threadCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "< Control >";
            // 
            // socks5
            // 
            this.socks5.AutoSize = true;
            this.socks5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.socks5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.socks5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.socks5.Location = new System.Drawing.Point(295, 86);
            this.socks5.Name = "socks5";
            this.socks5.Size = new System.Drawing.Size(116, 17);
            this.socks5.TabIndex = 5;
            this.socks5.Text = "SOCKS5 proxys";
            this.socks5.UseVisualStyleBackColor = false;
            // 
            // https
            // 
            this.https.AutoSize = true;
            this.https.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.https.Checked = true;
            this.https.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.https.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.https.Location = new System.Drawing.Point(295, 68);
            this.https.Name = "https";
            this.https.Size = new System.Drawing.Size(109, 17);
            this.https.TabIndex = 5;
            this.https.TabStop = true;
            this.https.Text = "HTTP/S proxys";
            this.https.UseVisualStyleBackColor = false;
            // 
            // timeoutValue
            // 
            this.timeoutValue.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))),
                ((int) (((byte) (48)))), ((int) (((byte) (48)))));
            this.timeoutValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeoutValue.Font = new System.Drawing.Font("Verdana", 12F);
            this.timeoutValue.ForeColor = System.Drawing.Color.White;
            this.timeoutValue.Location = new System.Drawing.Point(224, 71);
            this.timeoutValue.Maximum = new decimal(new int[] {50, 0, 0, 0});
            this.timeoutValue.Minimum = new decimal(new int[] {5, 0, 0, 0});
            this.timeoutValue.Name = "timeoutValue";
            this.timeoutValue.Size = new System.Drawing.Size(48, 23);
            this.timeoutValue.TabIndex = 4;
            this.timeoutValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeoutValue.Value = new decimal(new int[] {20, 0, 0, 0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.Location = new System.Drawing.Point(146, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Timeout:";
            // 
            // threadCount
            // 
            this.threadCount.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))),
                ((int) (((byte) (48)))));
            this.threadCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.threadCount.Font = new System.Drawing.Font("Verdana", 12F);
            this.threadCount.ForeColor = System.Drawing.Color.White;
            this.threadCount.Location = new System.Drawing.Point(92, 71);
            this.threadCount.Name = "threadCount";
            this.threadCount.Size = new System.Drawing.Size(48, 23);
            this.threadCount.TabIndex = 2;
            this.threadCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.threadCount.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Threads: ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (231)))), ((int) (((byte) (76)))),
                ((int) (((byte) (60)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(391, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 34);
            this.button4.TabIndex = 0;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (204)))),
                ((int) (((byte) (113)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(309, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))),
                ((int) (((byte) (48)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(128, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Load Proxies";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))),
                ((int) (((byte) (48)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Combo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.threadsCountLabel);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.countErrorLabel);
            this.groupBox4.Controls.Add(this.countBadLabel);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.countGoodsLabel);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.countsTestedsLabel);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(491, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 115);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "< Status >";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // threadsCountLabel
            // 
            this.threadsCountLabel.AutoSize = true;
            this.threadsCountLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))),
                ((int) (((byte) (62)))), ((int) (((byte) (80)))));
            this.threadsCountLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.threadsCountLabel.ForeColor = System.Drawing.Color.White;
            this.threadsCountLabel.Location = new System.Drawing.Point(98, 89);
            this.threadsCountLabel.Name = "threadsCountLabel";
            this.threadsCountLabel.Size = new System.Drawing.Size(17, 17);
            this.threadsCountLabel.TabIndex = 1;
            this.threadsCountLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F);
            this.label8.Location = new System.Drawing.Point(23, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Threads:";
            // 
            // countErrorLabel
            // 
            this.countErrorLabel.AutoSize = true;
            this.countErrorLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (52)))),
                ((int) (((byte) (73)))), ((int) (((byte) (94)))));
            this.countErrorLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.countErrorLabel.ForeColor = System.Drawing.Color.White;
            this.countErrorLabel.Location = new System.Drawing.Point(98, 72);
            this.countErrorLabel.Name = "countErrorLabel";
            this.countErrorLabel.Size = new System.Drawing.Size(17, 17);
            this.countErrorLabel.TabIndex = 0;
            this.countErrorLabel.Text = "0";
            // 
            // countBadLabel
            // 
            this.countBadLabel.AutoSize = true;
            this.countBadLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (231)))),
                ((int) (((byte) (76)))), ((int) (((byte) (60)))));
            this.countBadLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.countBadLabel.ForeColor = System.Drawing.Color.White;
            this.countBadLabel.Location = new System.Drawing.Point(98, 55);
            this.countBadLabel.Name = "countBadLabel";
            this.countBadLabel.Size = new System.Drawing.Size(17, 17);
            this.countBadLabel.TabIndex = 0;
            this.countBadLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.Location = new System.Drawing.Point(23, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Errors:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F);
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bad:";
            // 
            // countGoodsLabel
            // 
            this.countGoodsLabel.AutoSize = true;
            this.countGoodsLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))),
                ((int) (((byte) (204)))), ((int) (((byte) (113)))));
            this.countGoodsLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.countGoodsLabel.ForeColor = System.Drawing.Color.White;
            this.countGoodsLabel.Location = new System.Drawing.Point(98, 39);
            this.countGoodsLabel.Name = "countGoodsLabel";
            this.countGoodsLabel.Size = new System.Drawing.Size(17, 17);
            this.countGoodsLabel.TabIndex = 0;
            this.countGoodsLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(23, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Good:";
            // 
            // countsTestedsLabel
            // 
            this.countsTestedsLabel.AutoSize = true;
            this.countsTestedsLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (241)))),
                ((int) (((byte) (196)))), ((int) (((byte) (15)))));
            this.countsTestedsLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.countsTestedsLabel.ForeColor = System.Drawing.Color.White;
            this.countsTestedsLabel.Location = new System.Drawing.Point(98, 22);
            this.countsTestedsLabel.Name = "countsTestedsLabel";
            this.countsTestedsLabel.Size = new System.Drawing.Size(17, 17);
            this.countsTestedsLabel.TabIndex = 0;
            this.countsTestedsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tested:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(444, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "B R O K E H    M I N E C R A F T   C H E C K E R   2.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (231)))), ((int) (((byte) (76)))),
                ((int) (((byte) (60)))));
            this.label9.Location = new System.Drawing.Point(12, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 54);
            this.label9.TabIndex = 3;
            this.label9.Text = "♥";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))),
                ((int) (((byte) (48)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 56);
            this.panel1.TabIndex = 4;
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))),
                ((int) (((byte) (48)))));
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.messageBox.ForeColor = System.Drawing.Color.White;
            this.messageBox.Location = new System.Drawing.Point(0, 203);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(729, 257);
            this.messageBox.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))),
                ((int) (((byte) (48)))));
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            saveButton.Font = new System.Drawing.Font("Verdana", 10F);
            saveButton.ForeColor = System.Drawing.Color.White;
            saveButton.Location = new System.Drawing.Point(242, 24);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(61, 34);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save\r\n";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(729, 460);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brokeh Minecraft Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timeoutValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.threadCount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown threadCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label countBadLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countGoodsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countsTestedsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countErrorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown timeoutValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label threadsCountLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton socks5;
        private System.Windows.Forms.RadioButton https;
        private System.Windows.Forms.TextBox messageBox;
    }
}

