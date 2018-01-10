namespace notepad
{
    partial class Text
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_document = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_clear_document = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_save_document = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_check = new System.Windows.Forms.ToolStripMenuItem();
            this.查看保存文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_document,
            this.MenuItem_check,
            this.MenuItem_help,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem_document
            // 
            this.MenuItem_document.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_clear_document,
            this.MenuItem_save_document});
            this.MenuItem_document.Name = "MenuItem_document";
            this.MenuItem_document.Size = new System.Drawing.Size(61, 21);
            this.MenuItem_document.Text = "文件(&D)";
            this.MenuItem_document.Click += new System.EventHandler(this.MenuItem_document_Click);
            // 
            // MenuItem_clear_document
            // 
            this.MenuItem_clear_document.Name = "MenuItem_clear_document";
            this.MenuItem_clear_document.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_clear_document.Text = "新建文件";
            this.MenuItem_clear_document.Click += new System.EventHandler(this.MenuItem_clear_document_Click);
            // 
            // MenuItem_save_document
            // 
            this.MenuItem_save_document.Name = "MenuItem_save_document";
            this.MenuItem_save_document.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_save_document.Text = "保存文件";
            this.MenuItem_save_document.Click += new System.EventHandler(this.MenuItem_save_document_Click);
            // 
            // MenuItem_check
            // 
            this.MenuItem_check.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看保存文档ToolStripMenuItem,
            this.个人信息ToolStripMenuItem});
            this.MenuItem_check.Name = "MenuItem_check";
            this.MenuItem_check.Size = new System.Drawing.Size(60, 21);
            this.MenuItem_check.Text = "查看(&C)";
            // 
            // 查看保存文档ToolStripMenuItem
            // 
            this.查看保存文档ToolStripMenuItem.Name = "查看保存文档ToolStripMenuItem";
            this.查看保存文档ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看保存文档ToolStripMenuItem.Text = "查看保存文档";
            this.查看保存文档ToolStripMenuItem.Click += new System.EventHandler(this.查看保存文档ToolStripMenuItem_Click);
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // MenuItem_help
            // 
            this.MenuItem_help.Name = "MenuItem_help";
            this.MenuItem_help.Size = new System.Drawing.Size(44, 21);
            this.MenuItem_help.Text = "帮助";
            this.MenuItem_help.Click += new System.EventHandler(this.MenuItem_help_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(579, 310);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.ForeColor = System.Drawing.Color.Red;
            this.label_title.Location = new System.Drawing.Point(12, 28);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(48, 16);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "label";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "日记本",
            "随笔",
            "其他"});
            this.comboBox_type.Location = new System.Drawing.Point(470, 29);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 20);
            this.comboBox_type.TabIndex = 3;
            this.comboBox_type.Text = "日记本";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.Color.Transparent;
            this.label_type.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_type.Location = new System.Drawing.Point(429, 30);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(35, 14);
            this.label_type.TabIndex = 4;
            this.label_type.Text = "类型";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(391, 367);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(350, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "日期";
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Text";
            this.Text = "Text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Text_FormClosing);
            this.Load += new System.EventHandler(this.Text_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_document;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_save_document;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_clear_document;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_check;
        private System.Windows.Forms.ToolStripMenuItem 查看保存文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_help;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;

    }
}