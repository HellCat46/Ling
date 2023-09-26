using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiaoshi
{
    internal class Webserver
    {
        public void Initilize(string selected_path, string address)
        {
            HttpListener listener = new HttpListener();
            String port = FindPort(address).ToString();
            String uri = "http://" + address + ":" + port + "/";

            listener.Prefixes.Add(uri);
         
            listener.Start();
            Logging.Write("Listening to http://" + address + ":" + port);

            while (true)
            {
                HttpListenerContext ctx = listener.GetContext();
                
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse res = ctx.Response;

                Response(ref res, selected_path, req.RawUrl.ToString());
                Logging.Write("Request Completed!!!");

                res.Close();
             }
        }

        private void Response(ref HttpListenerResponse res, string selected_path, string path)
        {

            (byte[] res_body, FileSys.Response res_type, string file_name) = FileSys.prepareResponse(selected_path, path);
            const string eol = "\r\n";

            if (res_type == FileSys.Response.NotFound)
            {
                res.StatusCode = 404;
                return; 
            }

            if (file_name == String.Empty) // Only for Debugging purpose
            {
                res.StatusCode = 500;
                return;
            }


            res.StatusCode = 200;
            res.ContentType = "content-type: application/octel-stream";
            res.AppendHeader("content-disposition", "attackment; filename="+file_name);
            res.ContentLength64 = res_body.Length;
            res.OutputStream.Write(res_body, 0, res_body.Length);

            //String response = "HTTP/1.1 200 OK" + eol;
            //response += "content-type: application/octel-stream" + eol;
            //response += "content-disposition: attachment; filename=" + file_name + eol; // Required for surving zipped folders
            //response += "content-length:" + res_body.Length + eol;
            //response += eol;
            //byte[] res_header = Encoding.ASCII.GetBytes(response);

            //byte[] res = new byte[res_header.Length + res_body.Length];
            //res_header.CopyTo(res, 0);
            //res_body.CopyTo(res, res_header.Length);

            //return res;
        }
        private int FindPort(string ip)
        {
            int avail_port = 0;

            for (int port = 49512; port <= 65535; port++)
            {
                try
                {
                    Logging.Write("Trying Port no. " + port.ToString());
                    TcpListener listener = new TcpListener(IPAddress.Parse(ip), port);
                    listener.Start();
                    avail_port = port;
                    listener.Stop();
                    break;
                }
                catch (Exception e)
                {
                    Logging.Write(e.ToString());
                    Logging.Write("Port " + port.ToString() + " is being used by some other program");
                }

            }
            if (avail_port != 0)
            {
                Logging.Write("Port " + avail_port.ToString() + "is free. Moving to the process of starting Web Server");
                return avail_port;
            }
            else
            {
                string error = "No Free Port Found. Exiting the program...";
                Logging.Write(error);
                MessageBox.Show("No Free Port Found. Exiting the program...");
                Environment.Exit(1);
                return 0; // Temp until I find a way to crash program 
            }
        }
    }
}
