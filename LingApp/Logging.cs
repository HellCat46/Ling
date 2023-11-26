using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingApp
{
    internal class Logging
    {
        public static void Write(string line)
        {
            line= "\n" + line;
            byte[] bytes = Encoding.ASCII.GetBytes(line);
            string path = "./logs.txt"; // Maintain per day logs instead of dumping everything into single file.

            WaitForFile(path);
            if (File.Exists(path))
            {
                FileStream file = File.Open(path, FileMode.Open);

                int line_count = 0;
                for(int i = 0 ; i < file.Length; i++)
                {
                    if(file.ReadByte() == 10)
                    {
                        line_count++;
                    }
                }

                if(line_count <= 1000)
                {
                    file.Write(bytes, 0, bytes.Length);
                    file.Dispose(); 
                }//else
                //{
                //    file.Close();
                //
                //    file = File.Open(path.Split('.').First() + "-new" + path.Split('.').Last(), FileMode.Create);
                //    file.Write(bytes, 0, bytes.Length);
                //    file.Close();
                //}
                // Work for future me ;D
            }else
            {
                FileStream file = File.Open(path, FileMode.Create);
                
                file.Write(bytes, 0, bytes.Length);
                file.Dispose();
            }
        }
        public static bool WaitForFile(string path)
        {
            while (true) // Add an timeout period
            {
                try
                {
                    StreamWriter fs = new StreamWriter(path);
                    fs.Dispose();
                    return true;
                }
                catch (IOException)
                {
                    continue;
                }
            }
        }

        public static string ReadLast()
        {
            StreamReader stream = new StreamReader("./logs.txt");
            string line = stream.ReadToEnd().Split('\n').Last();
            stream.Dispose();

            return line;
        }
    }
}
