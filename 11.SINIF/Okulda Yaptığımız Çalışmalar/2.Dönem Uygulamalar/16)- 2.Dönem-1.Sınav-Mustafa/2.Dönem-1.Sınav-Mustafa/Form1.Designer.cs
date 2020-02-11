namespace _2.Dönem_1.Sınav_Mustafa
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sorularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soru1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soru2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soru3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sorularToolStripMenuItem,
            this.zamanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(216, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // sorularToolStripMenuItem
            // 
            this.sorularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soru1ToolStripMenuItem,
            this.soru2ToolStripMenuItem,
            this.soru3ToolStripMenuItem});
            this.sorularToolStripMenuItem.Name = "sorularToolStripMenuItem";
            this.sorularToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sorularToolStripMenuItem.Text = "Sorular";
            // 
            // soru1ToolStripMenuItem
            // 
            this.soru1ToolStripMenuItem.Name = "soru1ToolStripMenuItem";
            this.soru1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.soru1ToolStripMenuItem.Text = "Soru1";
            this.soru1ToolStripMenuItem.Click += new System.EventHandler(this.soru1ToolStripMenuItem_Click);
            // 
            // soru2ToolStripMenuItem
            // 
            this.soru2ToolStripMenuItem.Name = "soru2ToolStripMenuItem";
            this.soru2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.soru2ToolStripMenuItem.Text = "Soru2";
            this.soru2ToolStripMenuItem.Click += new System.EventHandler(this.soru2ToolStripMenuItem_Click);
            // 
            // soru3ToolStripMenuItem
            // 
            this.soru3ToolStripMenuItem.Name = "soru3ToolStripMenuItem";
            this.soru3ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.soru3ToolStripMenuItem.Text = "Soru3";
            this.soru3ToolStripMenuItem.Click += new System.EventHandler(this.soru3ToolStripMenuItem_Click);
            // 
            // zamanToolStripMenuItem
            // 
            this.zamanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarihToolStripMenuItem,
            this.saatToolStripMenuItem});
            this.zamanToolStripMenuItem.Name = "zamanToolStripMenuItem";
            this.zamanToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.zamanToolStripMenuItem.Text = "Zaman";
            // 
            // tarihToolStripMenuItem
            // 
            this.tarihToolStripMenuItem.Name = "tarihToolStripMenuItem";
            this.tarihToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.tarihToolStripMenuItem.Text = "Tarih";
            this.tarihToolStripMenuItem.Click += new System.EventHandler(this.tarihToolStripMenuItem_Click);
            // 
            // saatToolStripMenuItem
            // 
            this.saatToolStripMenuItem.Name = "saatToolStripMenuItem";
            this.saatToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saatToolStripMenuItem.Text = "Saat";
            this.saatToolStripMenuItem.Click += new System.EventHandler(this.saatToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hoşgeldiniz                                            ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(70, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 141);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2.Dönem 1.Sınavı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sorularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soru1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soru2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soru3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

