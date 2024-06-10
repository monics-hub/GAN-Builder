using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using GanBuilder.controls;

namespace GanBuilder
{
    public class Utils
    {
        
        public static string dirname = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public static string imgPath = dirname + "/temp/";

        public static void setFolder_Box(FolderBrowserDialog browser, CueTextbox box)
        {
            if (browser.ShowDialog() == DialogResult.OK)
            {
                string path = browser.SelectedPath;
                box.Text = path;

            }
        }

        public enum Mstype {Success, Error, Warning, Info};
        public static void showMessage(Mstype type, string message, string title = null, int destroy = 0)
        {
            Form notification = null;
            if(type == Mstype.Success)
            {
                notification = new Notification(Notification.alertType.success, message, title, destroy);
            }
            else if(type == Mstype.Error)
            {
                notification = new Notification(Notification.alertType.error, message, title, destroy);
            }
            else if(type == Mstype.Warning)
            {
                notification = new Notification(Notification.alertType.warning, message, title, destroy);
            }
            else
            {
                notification = new Notification(Notification.alertType.info, message, title, destroy);
            }
            notification.Show();
        }


        public static void saveParameters(string filename, string[] arguments)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (string i in arguments)
                {
                    outputFile.WriteLine(i);
                }
            }
        }

        public static void clearFolder(string path)
        {
            string[] files = Directory.GetFiles(path);
            try
            {
                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
            catch
            {
                string exception = "The process cannot start because the previous process is not completely finished. " +
                    "Please wait and then try again.";
                showMessage(Mstype.Warning, exception, "Process not finished exception: ");
            }
            
        }

        public static void runScript(string name, string[] arguments, string exceptionMessage=null)
        {
            try
            {
                string[] settings = System.IO.File.ReadAllLines(dirname + @"\settings.txt", Encoding.UTF8);
                string pythonPath = @"" + settings[1];
                var app = new ProcessStartInfo();
                app.FileName =  pythonPath;
                var script = dirname + @"\" + name + ".py";
                app.Arguments = $"\"{script}\"";
                if (arguments != null)
                {
                    foreach (string i in arguments)
                    {
                        app.Arguments = app.Arguments + $" \"{i}\" ";
                    }
                }
                app.UseShellExecute = false;
                app.CreateNoWindow = true;
                app.RedirectStandardOutput = true;
                app.RedirectStandardError = true;
                var errors = "";
                var results = "";
                using (var process = Process.Start(app))
                {
                    errors = process.StandardError.ReadToEnd();
                    results = process.StandardOutput.ReadToEnd();
                }
                Console.WriteLine(results);
            }
            catch
            {
                string exception = "Not able to run python script:";
                if (exceptionMessage != null)
                {
                    showMessage(Mstype.Error, exceptionMessage, exception);
                }
                else
                {
                    showMessage(Mstype.Error, exception);
                }
            }
        }

        public static string executeCommands(string[] commands, Boolean multipleLines)
        {
            try
            {
                string chain = "";
                foreach(string i in commands)
                {
                    chain = i + " & " + chain;
                }
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + chain);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.StandardOutputEncoding = System.Text.Encoding.ASCII;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                if (multipleLines)
                {
                    return proc.StandardOutput.ReadToEnd();
                }
                else
                {
                    return proc.StandardOutput.ReadLine();
                }
                
            }
            catch (Exception objException)
            {
                return  "An error ocurred. Not able to excute console instructions";
            }
        }

        public static string serverMessage = "0";
        public static Boolean serverRunning = false;
        public static Thread pythonThread;
        public static Thread serverThread;

        public static void runServer(string script, string[] arguments, string exceptionMessage = null)
        {
            void run()
            {
                try
                {
                    pythonThread = new Thread(() => runScript(script, arguments));
                    int port = 5005;
                    byte[] buffer = new Byte[1024];
                    IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                    Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    listener.Bind(localEndPoint);
                    listener.Listen(10);
                    pythonThread.Start();
                    Socket socket = listener.Accept();
                    serverRunning = true;
                    while (serverRunning == true)
                    {
                        int bytesRec = socket.Receive(buffer);
                        string data = Encoding.ASCII.GetString(buffer, 0, bytesRec);
                        if (data.IndexOf("connected") > -1)
                        {
                            data = "-1";
                        }

                        if (data.IndexOf("closed") > -1)
                        {
                            data = data.Remove(data.Length - 5);
                            serverRunning = false;
                            break;
                        }
                        serverMessage = data;

                    }
                    socket.Close();
                    listener.Close();

                }
                catch
                {
                    serverRunning = false;
                    string exception = "Not able to stablish server connection with python:";
                    if (exceptionMessage != null)
                    {
                        showMessage(Mstype.Error, exceptionMessage, exception);
                    }
                    else
                    {
                        showMessage(Mstype.Error, exception);
                    }
                }
            }

            serverThread = new Thread(() => run());
            serverThread.Start();

        }

        
    }
}
