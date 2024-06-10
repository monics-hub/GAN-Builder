private string getData(Socket socket, byte[] buffer)
        {
            int bytesRec = socket.Receive(buffer);
            string data = Encoding.ASCII.GetString(buffer, 0, bytesRec);
            return data;
        }


        private void executeServer()
        {
            Thread thread = new Thread(() => runScript("my_socket", null));
            int port = 5005;
            byte[] buffer = new Byte[1024];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                thread.Start();
                Socket socket = listener.Accept();
                for (int i = 0; i<4; i++)
                {
                    string data = getData(socket, buffer);
                    myLabel.Text = data;

                }
                socket.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
