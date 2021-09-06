using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace QS_Server
{
   
    public partial class Form1 : Form
    {
        Socket socket=null;
        Thread threadclient = null;
        List<IPAddress> mlist = new List<IPAddress>();
        private StringBuilder msg = new StringBuilder();
        public string MSg
        {
            get { return msg.ToString(); }
            private set
            {
                msg.AppendLine(value);
                textBox_xian_shi.Text = value + "\r\n";
            }
        }
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void recv()//
        {
            while (true)//持续监听服务端发来的消息
            {
                try
                {
                    //定义一个1M的内存缓冲区，用于临时性存储接收到的消息
                    byte[] arrRecvmsg = new byte[1024 * 1024];

                    //将客户端套接字接收到的数据存入内存缓冲区，并获取长度
                    int length = socket.Receive(arrRecvmsg);

                    //将套接字获取到的字符数组转换为人可以看懂的字符串
                    string strRevMsg = Encoding.UTF8.GetString(arrRecvmsg, 0, length);

                    MSg = ("服务器:" + GetCurrentTime() + "IP:" + socket.RemoteEndPoint + ",的消息:" + strRevMsg + "\r\n\n");
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    MSg = ("远程服务器已经中断连接" + "\r\n");
                    break;
                }
            }
        }
        private string GetCurrentTime()
        {
            string timeStr = System.DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒fff毫秒。");
            return timeStr;
        }

        //发送字符信息到服务端的方法
        public void ClientSendMsg(string sendMsg)
        {
            //将输入的内容字符串转换为机器可以识别的字节数组
            byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
            //调用客户端套接字发送字节数组
            socket.Send(arrClientSendMsg);
        }

 

        public TextBox TextBoxlist(int index)
        {
            TextBox[] textlist =
            {
                textBox_user,
                textBox_IP,
                textBox_port,
                textBox_lu_jin, 
                textBox_wen_jian,
                
            };
            return textlist[index];
        }
        public void CreateFile()//创建部分
        {
            try
            {
                StreamWriter writer = new StreamWriter("Savefile.ini", false);
                for (int i = 0; i < 6; i++)
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
                while (inde < 6)
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
        private void button_yin_yon_Click(object sender, EventArgs e)
        {
            CreateFile();//保存
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {
            ReadFile();//读取保存
        }

        private void button_lian_jie_Click(object sender, EventArgs e)
        {
            //开始
            if (button_lian_jie.Text=="连接")
            {
                try
                {

                    int port = Convert.ToInt32(this.textBox_port.Text);
                    IPAddress ip = IPAddress.Parse(this.textBox_IP.Text.Trim());
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint point = new IPEndPoint(ip, port);
                    MSg = "正在连接服务器" + ip + "：" + port;
                    try
                    {
                        socket.Connect(point);
                    }
                    catch (Exception)
                    {
                        MSg = ("连接失败\r\n");
                        return;
                    }
                    threadclient = new Thread(recv);
                    threadclient.IsBackground = true;
                    threadclient.Start();
                    button_yin_yon.Enabled = false;
                    button_lian_jie.Text = "断开连接";
                }
                catch (Exception)
                {
                    button_lian_jie.Text = "连接";
                    MessageBox.Show("错误，请检查文件完整性！");
                    throw;
                }
            }
            else if (button_lian_jie.Text=="断开连接")
            {
                socket.Close();
                button_yin_yon.Enabled = true;
                button_lian_jie.Text = "连接";

            }

        }

        private void button_kai_guan_Click(object sender, EventArgs e)
        {
            if (button_kai_guan.Text == "关闭")
            {

                button_kai_guan.Text = "开启";
            }
            else
            {

                //本行写需要执行打开的操作

                ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
                Info.FileName = textBox_wen_jian.Text;
                Info.WorkingDirectory = textBox_lu_jin.Text;
                Info.WindowStyle = ProcessWindowStyle.Minimized;

                System.Diagnostics.Process Proc;
                try
                {
                    Proc = System.Diagnostics.Process.Start(Info);
                    System.Threading.Thread.Sleep(500);
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    return;
                }

                if (System.Diagnostics.Process.GetProcessesByName("NBTxxqs_heating").ToList().Count > 0)
                {
                    MessageBox.Show("已经开始运行！");
                    //存在

                }
                else
                {
                    MessageBox.Show("未开始运行！");
                    //不存在
                }
                button_kai_guan.Text = "关闭";
            }
        }
    }
}
