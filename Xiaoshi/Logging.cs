using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaoshi
{
    internal class Logging
    {
        public static void Write(string line)
        {
            line += "\n";
            byte[] bytes = Encoding.ASCII.GetBytes(line);
            string path = "./logs.txt"; // Maintain per day logs instead of dumping everything into single file.
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
                    file.Close(); 
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
                file.Close();
            }
        }
    }
}
