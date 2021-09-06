using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace QsClient
{
    public partial class Form1 : Form
    {

        public EndPoint RemoteEndPoint { get; private set; }
        Thread threadwatch = null;
        Socket socket = null;

        public Dictionary<EndPoint, Socket> dic = new Dictionary<EndPoint, Socket> { };

        private StringBuilder msg = new StringBuilder();
        public string Msg
        {
            get { return msg.ToString(); }
            private set
            {
                msg.AppendLine(value);
                listBox_ji_lu.Items.Add(value + "\r\n");

            }

        }

        public Form1()
        {

            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            //int port = Convert.ToInt32(textBox_port.Text);
            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //IPEndPoint point = new IPEndPoint(IPAddress.Any, port);
            //socket.Bind(point);
            //socket.Listen(20);
            //threadwatch = new Thread(watchconnecting);
            //threadwatch.IsBackground = true;
            //threadwatch.Start();
            //Msg = ("开始监听" + "\r\n");

        }

        private void button_ting_zhi_jian_tinf_Click(object sender, EventArgs e)
        {
            if (button_jian_ting.Text=="开始监听")
            {
                try
                {
                    int port = Convert.ToInt32(textBox_port.Text);
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    IPEndPoint point = new IPEndPoint(IPAddress.Any, port);
                    socket.Bind(point);
                    socket.Listen(20);
                    threadwatch = new Thread(watchconnecting);
                    threadwatch.IsBackground = true;
                    threadwatch.Start();
                    Msg = ("开始监听" + "\r\n");
                    button_bao_cun.Enabled = false; //保存按钮不可用
                    button_jian_ting.Text = "停止监听";
                }
                catch (Exception)
                {
                    MessageBox.Show("服务端启动服务失败!" + "\r\n");
                    button_bao_cun.Enabled = true;//保存按钮可用
                }
            }
            else if(button_jian_ting.Text=="停止监听")
            {
                try
                {
                    socket.Close();
                    MessageBox.Show("服务端已停止连接!" + "\r\n");
                    button_jian_ting.Text = "开始监听";
                    button_bao_cun.Enabled = true;//保存按钮可用
                }
                catch (Exception)
                {
                    MessageBox.Show("错误！请重新启动应用程序!" + "\r\n");
                    throw;
                }
            }
        }
        private void watchconnecting()
        {
            Socket connection = null;
            while (true)
            {
                try
                {
                    connection = socket.Accept();
                }
                catch (Exception ex)
                {
                    Msg = (ex.Message);
                    break;
                }
                //在连接成功后发送消息给客户端
                string sendmsg = "连接服务端成功！你的IP是" + connection.RemoteEndPoint;
                byte[] arrsendMsg = Encoding.UTF8.GetBytes(sendmsg);
                connection.Send(arrsendMsg);

                RemoteEndPoint = connection.RemoteEndPoint;
                Msg = ("成功与" + RemoteEndPoint + "客户端建立连接！\t\n");
                dic.Add(RemoteEndPoint, connection);
                listBox_xian_shi.Items.Add("超级英雄  " + RemoteEndPoint + " 95.56%");
                ParameterizedThreadStart pts = new ParameterizedThreadStart(recv);
                Thread thread = new Thread(pts);
                thread.IsBackground = true;//设置为后台线程，随着主线程退出而退出
                thread.Start(connection);//启动线程

            }
        }
        private void recv(object socketclientpara)
        {
            Socket socketServer = socketclientpara as Socket;
            while (true)
            {
                //创建一个内存缓冲区 其大小为1024*1024字节 即1M
                byte[] arrServerRecMsg = new byte[1024 * 1024];
                //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                try
                {
                    int length = socketServer.Receive(arrServerRecMsg);

                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);

                    //将发送的字符串信息附加到文本框txtMsg上
                    Msg = ("客户端:" + GetCurrentTime() + socketServer.RemoteEndPoint + "的消息:" + strSRecMsg + "\r\n");

                }
                catch (Exception ex)
                {
                    Msg = ("客户端:" + GetCurrentTime() + socketServer.RemoteEndPoint + "已经中断连接" + "\r\n"); //提示套接字监听异常
                                                                                                         //listBoxOnlineList.Items.Remove(socketServer.RemoteEndPoint.ToString());//从listbox中移除断开连接的客户端
                    socketServer.Close();//关闭之前accept出来的和客户端进行通信的套接字
                    break;
                }
            }
        }
        private string GetCurrentTime()
        {
            string timeStr = System.DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒fff毫秒。");
            return timeStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开   启")
            {
                try
                {


                    button1.Text = "关   闭";
                }
                catch (Exception)
                {

                    MessageBox.Show("打开失败。提示：");
                }
            }
            else
            {
                try
                {

                }
                catch (Exception) { }
                button1.Text = "开   启";
            }

        }

        private void button_dao_chu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";
            string filepath = null;
            string totext = null;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < listBox_ji_lu.Items.Count; i++)
                {
                    totext += listBox_ji_lu.Items[i] + "\r\n";
                }
                filepath = saveFileDialog.FileName;
                StreamWriter streamWriter = new StreamWriter(filepath);
                streamWriter.Write(totext);
                streamWriter.Flush();
                streamWriter.Close();
                MessageBox.Show(saveFileDialog.FileName);
            }

        }
        public TextBox TextBoxlist(int index)
        {
            TextBox[] textlist = { textBox_port };
            return textlist[index];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();//读取部分
        }

        private void button_bao_cun_Click(object sender, EventArgs e)
        {
            CreateFile();
        }
        public void CreateFile()//创建部分
        {
            try
            {
                StreamWriter writer = new StreamWriter("Savefile.ini", false);
                for (int i = 0; i < 1; i++)
                {
                    writer.WriteLine(TextBoxlist(i).Text);
                }
                writer.Close();
                MessageBox.Show("保存成功");
            }
            catch
            {
                MessageBox.Show("保存失败");
            }
        }
        public void ReadFile()//读取部分
        {
            try
            {
                StreamReader reader = new StreamReader("Savefile.ini");
                string readerStr = reader.ReadLine();
                int inde = 0;
                while (inde < 1)
                {
                    TextBoxlist(inde).Text = readerStr;
                    readerStr = reader.ReadLine();
                    inde++;
                }
                reader.Close();
            }
            catch
            {
            }
        }

        
        
    }
}
