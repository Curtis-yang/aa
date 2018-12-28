using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRead
{
    class Program
    {
        public static void read()
        {
            Console.OutputEncoding = Encoding.GetEncoding("gbk");
            StreamReader sr = new StreamReader(@"E:\makrdown\aa\test1.txt");
            String line = "";
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine("输出{0}", line);
            }
            
        }
        public static void write()
        {

            using (StreamWriter sw = new StreamWriter(@"E:\makrdown\aa\test1.txt",true))
            {
                String s = "实打实大苏打"+DateTime.Now;
                sw.WriteLine(s);
            }
                

        }
        //2进制文件读写
        public static void bytewrite()
        {
            
            BinaryWriter bw;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";
            //创建文件
            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.OpenOrCreate));

            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message + "创建或打开文件失败");
                return;

            }
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;

            }
           
        }
        //读取文件
        public static void byteread()
        {
            //FileStream br;
            try
            {
             using(FileStream fs = new FileStream("names.txt",FileMode.Open))
                {
                 //   var a = fs.BeginRead();

                } 
                //br = new FileStream(new FileStream("names.txt", FileMode.Open));
                //Console.Write(br.ReadString());
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "打开文件失败");
                return;
            }
            
            try
            {
                

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "读取文件失败");
                return;
            }
            
            
        }
        public static void  searchInfo()
        {
            DirectoryInfo mydir = new DirectoryInfo(@"c:\Windows");

            // 获取目录中的文件以及它们的名称和大小
            FileInfo[] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1}",
                    file.Name, file.Length);
            }
            Console.ReadKey();
        }
            static void Main(string[] args)
            {
            Console.OutputEncoding = Encoding.GetEncoding("gbk");
            Program.searchInfo();
            Console.ReadKey();
        }
    }
}
