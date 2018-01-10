using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
   public  class Note
    {
        string text = null;
        public void createNote()
        {
            Console.WriteLine("请输入笔记内容：");
            string text = Console.ReadLine();
            Console.WriteLine("新建笔记完成");
        }
        public void openNote()
        {
            Console.WriteLine(text);
        }
        public void clasifyNote()
        {
            string s1 = "心情日记";
            string s2 = "学术日志";
            string s3 = "杂记";
            Console.WriteLine("请选择要输入的笔记类型：{0},{1},{2}",s1,s2,s3);
            string type=Console.ReadLine();
            if (type == s1)
            {
                Console.WriteLine("请输入心情日记：");
                createNote();
            }
            else if (type == s2)
            {
                Console.WriteLine("请输入学术日志：");
                createNote();
            }
            else if (type == s3)
            {
                Console.WriteLine("请输入杂记：");
                createNote();
            }
            else
            {
                Console.WriteLine("输入错误，请重新输入");
                clasifyNote();
            }
            Console.WriteLine("请输入是否继续YES或NO");
            string option = Console.ReadLine();
            if (option == "YES") 
            {
                clasifyNote();
                openNote();
            }
          else
            return;
        }
    }
}
