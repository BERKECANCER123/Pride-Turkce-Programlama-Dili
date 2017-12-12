namespace Pride
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ızgara = new System.Windows.Forms.RichTextBox();
            this.main = new System.Windows.Forms.RichTextBox();
            this.program = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.only_fonksiyon = new System.Windows.Forms.ListBox();
            this.sayilar = new System.Windows.Forms.ListBox();
            this.goruntuler = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.derleToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.yeniToolStripMenuItem});
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.açToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.kaydetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeToolStripMenuItem,
            this.fonksiyonToolStripMenuItem});
            this.yeniToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // projeToolStripMenuItem
            // 
            this.projeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.projeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.projeToolStripMenuItem.Name = "projeToolStripMenuItem";
            this.projeToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.projeToolStripMenuItem.Text = "Proje";
            this.projeToolStripMenuItem.Click += new System.EventHandler(this.projeToolStripMenuItem_Click);
            // 
            // fonksiyonToolStripMenuItem
            // 
            this.fonksiyonToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.fonksiyonToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fonksiyonToolStripMenuItem.Name = "fonksiyonToolStripMenuItem";
            this.fonksiyonToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.fonksiyonToolStripMenuItem.Text = "Fonksiyon";
            this.fonksiyonToolStripMenuItem.Click += new System.EventHandler(this.fonksiyonToolStripMenuItem_Click_1);
            // 
            // derleToolStripMenuItem
            // 
            this.derleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.derleToolStripMenuItem.Name = "derleToolStripMenuItem";
            this.derleToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.derleToolStripMenuItem.Text = "Derle ve Çalıştır";
            this.derleToolStripMenuItem.Click += new System.EventHandler(this.derleToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ızgara
            // 
            this.ızgara.BackColor = System.Drawing.Color.Black;
            this.ızgara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ızgara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ızgara.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ızgara.ForeColor = System.Drawing.Color.White;
            this.ızgara.Location = new System.Drawing.Point(0, 28);
            this.ızgara.Name = "ızgara";
            this.ızgara.Size = new System.Drawing.Size(1053, 373);
            this.ızgara.TabIndex = 1;
            this.ızgara.Text = "Program{\n\n\n\n}";
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(926, 286);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(100, 96);
            this.main.TabIndex = 2;
            this.main.Text = "";
            this.main.Visible = false;
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Black;
            this.program.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.program.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.program.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.program.ForeColor = System.Drawing.Color.LightGray;
            this.program.Location = new System.Drawing.Point(0, 401);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(1053, 203);
            this.program.TabIndex = 3;
            this.program.Text = "";
            this.program.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.listBox1.ForeColor = System.Drawing.Color.Aqua;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(1053, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 604);
            this.listBox1.TabIndex = 4;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // only_fonksiyon
            // 
            this.only_fonksiyon.FormattingEnabled = true;
            this.only_fonksiyon.ItemHeight = 20;
            this.only_fonksiyon.Location = new System.Drawing.Point(434, 146);
            this.only_fonksiyon.Name = "only_fonksiyon";
            this.only_fonksiyon.Size = new System.Drawing.Size(120, 84);
            this.only_fonksiyon.TabIndex = 5;
            this.only_fonksiyon.Visible = false;
            // 
            // sayilar
            // 
            this.sayilar.BackColor = System.Drawing.Color.Black;
            this.sayilar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sayilar.ForeColor = System.Drawing.Color.Blue;
            this.sayilar.FormattingEnabled = true;
            this.sayilar.ItemHeight = 20;
            this.sayilar.Location = new System.Drawing.Point(681, 77);
            this.sayilar.Name = "sayilar";
            this.sayilar.Size = new System.Drawing.Size(120, 262);
            this.sayilar.TabIndex = 6;
            this.sayilar.Visible = false;
            // 
            // goruntuler
            // 
            this.goruntuler.BackColor = System.Drawing.Color.Black;
            this.goruntuler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goruntuler.ForeColor = System.Drawing.Color.Red;
            this.goruntuler.FormattingEnabled = true;
            this.goruntuler.ItemHeight = 20;
            this.goruntuler.Location = new System.Drawing.Point(834, 77);
            this.goruntuler.Name = "goruntuler";
            this.goruntuler.Size = new System.Drawing.Size(120, 262);
            this.goruntuler.TabIndex = 7;
            this.goruntuler.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1173, 604);
            this.Controls.Add(this.goruntuler);
            this.Controls.Add(this.sayilar);
            this.Controls.Add(this.only_fonksiyon);
            this.Controls.Add(this.ızgara);
            this.Controls.Add(this.main);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.program);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ahmetet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derleToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox ızgara;
        private System.Windows.Forms.RichTextBox main;
        private System.Windows.Forms.RichTextBox program;
        private System.Windows.Forms.ToolStripMenuItem fonksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox only_fonksiyon;
        private System.Windows.Forms.ListBox sayilar;
        private System.Windows.Forms.ListBox goruntuler;
    }
}

