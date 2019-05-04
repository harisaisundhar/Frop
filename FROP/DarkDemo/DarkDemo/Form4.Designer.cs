namespace DarkDemo
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.trend = new System.Windows.Forms.Button();
            this.share = new System.Windows.Forms.Button();
            this.chat = new System.Windows.Forms.Button();
            this.dash = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Chatq = new System.Windows.Forms.Button();
            this.Fileq = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trend);
            this.panel1.Controls.Add(this.share);
            this.panel1.Controls.Add(this.chat);
            this.panel1.Controls.Add(this.dash);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 450);
            this.panel1.TabIndex = 1;
            // 
            // trend
            // 
            this.trend.FlatAppearance.BorderSize = 0;
            this.trend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.trend.ForeColor = System.Drawing.Color.White;
            this.trend.Image = ((System.Drawing.Image)(resources.GetObject("trend.Image")));
            this.trend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trend.Location = new System.Drawing.Point(0, 361);
            this.trend.Name = "trend";
            this.trend.Size = new System.Drawing.Size(163, 79);
            this.trend.TabIndex = 1;
            this.trend.Text = "Web Down";
            this.trend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.trend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.trend.UseVisualStyleBackColor = true;
            this.trend.Click += new System.EventHandler(this.trend_Click);
            // 
            // share
            // 
            this.share.FlatAppearance.BorderSize = 0;
            this.share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.share.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.share.ForeColor = System.Drawing.Color.White;
            this.share.Image = ((System.Drawing.Image)(resources.GetObject("share.Image")));
            this.share.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.share.Location = new System.Drawing.Point(2, 281);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(163, 79);
            this.share.TabIndex = 1;
            this.share.Text = "Share";
            this.share.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.share.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.share.UseVisualStyleBackColor = true;
            this.share.Click += new System.EventHandler(this.share_Click);
            // 
            // chat
            // 
            this.chat.FlatAppearance.BorderSize = 0;
            this.chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.chat.ForeColor = System.Drawing.Color.White;
            this.chat.Image = ((System.Drawing.Image)(resources.GetObject("chat.Image")));
            this.chat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chat.Location = new System.Drawing.Point(2, 200);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(163, 79);
            this.chat.TabIndex = 1;
            this.chat.Text = "Chat";
            this.chat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chat.UseVisualStyleBackColor = true;
            this.chat.Click += new System.EventHandler(this.chat_Click);
            // 
            // dash
            // 
            this.dash.FlatAppearance.BorderSize = 0;
            this.dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dash.ForeColor = System.Drawing.Color.White;
            this.dash.Image = ((System.Drawing.Image)(resources.GetObject("dash.Image")));
            this.dash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dash.Location = new System.Drawing.Point(0, 119);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(163, 79);
            this.dash.TabIndex = 1;
            this.dash.Text = "Dashboard";
            this.dash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dash.UseVisualStyleBackColor = true;
            this.dash.Click += new System.EventHandler(this.dash_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 76);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(-5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 59);
            this.label2.TabIndex = 0;
            this.label2.Text = "FROP";
            // 
            // Chatq
            // 
            this.Chatq.FlatAppearance.BorderSize = 0;
            this.Chatq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chatq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Chatq.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Chatq.Location = new System.Drawing.Point(478, 38);
            this.Chatq.Name = "Chatq";
            this.Chatq.Size = new System.Drawing.Size(87, 27);
            this.Chatq.TabIndex = 6;
            this.Chatq.Text = "Chat";
            this.Chatq.UseVisualStyleBackColor = true;
            this.Chatq.Click += new System.EventHandler(this.Chatq_Click);
            // 
            // Fileq
            // 
            this.Fileq.FlatAppearance.BorderSize = 0;
            this.Fileq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fileq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Fileq.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Fileq.Location = new System.Drawing.Point(571, 38);
            this.Fileq.Name = "Fileq";
            this.Fileq.Size = new System.Drawing.Size(113, 27);
            this.Fileq.TabIndex = 7;
            this.Fileq.Text = "File Transfer";
            this.Fileq.UseVisualStyleBackColor = true;
            this.Fileq.Click += new System.EventHandler(this.Fileq_Click);
            // 
            // exit
            // 
            this.exit.AllowDrop = true;
            this.exit.AutoEllipsis = true;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(699, 38);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(63, 27);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(199, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wifi Chat and Transfer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(203, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.35647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.64353F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 317);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31446F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.68554F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(553, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Go";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(553, 275);
            this.webBrowser1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(312, 416);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(310, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Feel Free to contact us at frop@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Chatq);
            this.Controls.Add(this.Fileq);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button trend;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.Button chat;
        private System.Windows.Forms.Button dash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Chatq;
        private System.Windows.Forms.Button Fileq;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}