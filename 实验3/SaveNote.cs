using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验3
{
    class SaveNote
    {
        public void Savenote(object sender, SaveType text)
        {
            StreamWriter sw = new StreamWriter(@"h:\notebook.txt");
            sw.WriteLine(text);
            Console.WriteLine("笔记本保存成功");
            sw.Close();
        }

    }
}
