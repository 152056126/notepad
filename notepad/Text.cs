using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//连接数据库所用的头文件
//添加引用system.configuration
using System.Data.SqlClient;
using System.Configuration;

namespace notepad
{
    public partial class Text : Form
    {
        //读取配置文件:app.config
        string Connection = ConfigurationManager.ConnectionStrings["notepad.Properties.Settings.notepadConnectionString"].ConnectionString;
        public Text()
        {
            InitializeComponent();
        }

        private void MenuItem_save_document_Click(object sender, EventArgs e)//保存文件
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("内容空白，你还要保存？！请填写内容");
            }
            else 
            {
                string time = dateTimePicker1.Text.Trim();
                SqlConnection conn = new SqlConnection(Connection);
                conn.Open();
                string sqlinsert = "insert into notepad_content values('" + public_class.user_name.Trim() + "','" + comboBox_type.Text.Trim() + "','" + textBox1.Text.Trim() + "','" +time +"')";//Convert.ToDateTime
                SqlCommand sc = new SqlCommand(sqlinsert, conn);
                sc.ExecuteNonQuery();
                MessageBox.Show("保存完成,记录生活的点点滴滴真好！！！");
                conn.Close();
                textBox1.Text = "";
            }
        }

        private void MenuItem_clear_document_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void MenuItem_document_Click(object sender, EventArgs e)
        {

        }

        private void Text_Load(object sender, EventArgs e)
        {
            label_title.Text = "欢迎你使用私人记事本：我的主人" + public_class.user_name;
        }

        private void MenuItem_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请拨打电话110");
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            person_information p = new person_information();
            this.Hide();
            p.Show();
        }

        private void 查看保存文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document_information di = new Document_information();
            this.Hide();
            di.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Text_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult r = MessageBox.Show("确定要退出程序?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            } 
        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        

       
    }
}
