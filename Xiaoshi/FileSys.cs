using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Xiaoshi
{
    internal class FileSys
    {
        public enum Response
        {
            Ok,
            NotFound
        }
        public static (byte[], Response, string file_name) prepareResponse(string selected_path, string vir_path)
        {
            string path = selected_path + vir_path; 


            if (path.EndsWith("/"))
                path = path.Remove(path.Length - 1);

            
            Console.WriteLine(path);
            if(!(File.Exists(path) || Directory.Exists(path)) || path == selected_path)
                return (Encoding.ASCII.GetBytes(""), Response.NotFound, String.Empty);


            String file_name = path.Split('/').Last();
            if (Directory.Exists(path))
            {
                string zip = "./" + file_name + ".zip";

                if (File.Exists(zip))
                    File.Delete(zip);
                
                System.IO.Compression.ZipFile.CreateFromDirectory(path, zip);
                // Add System.IO.COmpression.FileSystem assembly in References
                // Man I miss Rider's Hand Holding after using VS

                if(File.Exists(zip))
                {
                    byte[] data = File.ReadAllBytes(zip);
                    File.Delete(zip);
                    return (data, Response.Ok, zip.Split('/').Last());
                }
            }

            return (File.ReadAllBytes(path), Response.Ok,  file_name);
        }
    }
}
