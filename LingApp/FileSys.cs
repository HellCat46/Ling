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
            Logging.Write("Looking for entry: " + path);


            if (path.EndsWith("/"))
                path = path.Remove(path.Length - 1);
            if(!(File.Exists(path) || Directory.Exists(path)) || path == selected_path)
                return (Encoding.ASCII.GetBytes(""), Response.NotFound, String.Empty);


            String file_name = path.Split('/').Last();
            if (Directory.Exists(path))
            {
                Logging.Write("Folder Found...");
                string zip = "./" + file_name + ".zip";

                if (File.Exists(zip))
                    File.Delete(zip);

                Logging.Write("Zipping the folder");
                System.IO.Compression.ZipFile.CreateFromDirectory(path, zip);
                // Add System.IO.COmpression.FileSystem assembly in References
                // Man I miss Rider's Hand Holding after using VS

                if(File.Exists(zip))
                {
                    Logging.Write("Sending to the receiver");
                    byte[] data = File.ReadAllBytes(zip);
                    File.Delete(zip);
                    return (data, Response.Ok, zip.Split('/').Last());
                }
            }
            Logging.Write("File Found. Sending to the receiver...");
            return (File.ReadAllBytes(path), Response.Ok,  file_name);
        }
    }
}
