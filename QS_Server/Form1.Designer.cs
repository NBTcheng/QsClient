
namespace QS_Server
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_xian_shi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_lian_jie = new System.Windows.Forms.Button();
            this.button_kai_guan = new System.Windows.Forms.Button();
            this.textBox_wen_jian = new System.Windows.Forms.TextBox();
            this.textBox_lu_jin = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.button_yin_yon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_xian_shi);
            this.groupBox1.Controls.Add(this.textBox_wen_jian);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_lu_jin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_user);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_IP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息填写";
            // 
            // textBox_xian_shi
            // 
            this.textBox_xian_shi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_xian_shi.ForeColor = System.Drawing.Color.Aqua;
            this.textBox_xian_shi.Location = new System.Drawing.Point(226, 78);
            this.textBox_xian_shi.Multiline = true;
            this.textBox_xian_shi.Name = "textBox_xian_shi";
            this.textBox_xian_shi.Size = new System.Drawing.Size(218, 91);
            this.textBox_xian_shi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "启动文件名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "启动路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器IP";
            // 
            // button_lian_jie
            // 
            this.button_lian_jie.Location = new System.Drawing.Point(356, 193);
            this.button_lian_jie.Name = "button_lian_jie";
            this.button_lian_jie.Size = new System.Drawing.Size(75, 23);
            this.button_lian_jie.TabIndex = 1;
            this.button_lian_jie.Text = "连接";
            this.button_lian_jie.UseVisualStyleBackColor = true;
            this.button_lian_jie.Click += new System.EventHandler(this.button_lian_jie_Click);
            // 
            // button_kai_guan
            // 
            this.button_kai_guan.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QS_Client.Properties.Settings.Default, "开关", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_kai_guan.Location = new System.Drawing.Point(20, 193);
            this.button_kai_guan.Name = "button_kai_guan";
            this.button_kai_guan.Size = new System.Drawing.Size(75, 23);
            this.button_kai_guan.TabIndex = 2;
            this.button_kai_guan.Text = global::QS_Client.Properties.Settings.Default.开关;
            this.button_kai_guan.UseVisualStyleBackColor = true;
            this.button_kai_guan.Click += new System.EventHandler(this.button_kai_guan_Click);
            // 
            // textBox_wen_jian
            // 
            this.textBox_wen_jian.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QS_Client.Properties.Settings.Default, "启动程序名", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_wen_jian.Location = new System.Drawing.Point(77, 83);
            this.textBox_wen_jian.Name = "textBox_wen_jian";
            this.textBox_wen_jian.Size = new System.Drawing.Size(120, 21);
            this.textBox_wen_jian.TabIndex = 9;
            this.textBox_wen_jian.Text = global::QS_Client.Properties.Settings.Default.启动程序名;
            // 
            // textBox_lu_jin
            // 
            this.textBox_lu_jin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QS_Client.Properties.Settings.Default, "启动路径", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_lu_jin.Location = new System.Drawing.Point(65, 51);
            this.textBox_lu_jin.Name = "textBox_lu_jin";
            this.textBox_lu_jin.Size = new System.Drawing.Size(379, 21);
            this.textBox_lu_jin.TabIndex = 7;
            this.textBox_lu_jin.Text = global::QS_Client.Properties.Settings.Default.启动路径;
            // 
            // textBox_user
            // 
            this.textBox_user.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QS_Client.Properties.Settings.Default, "YHUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_user.Location = new System.Drawing.Point(344, 20);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(100, 21);
            this.textBox_user.TabIndex = 5;
            this.textBox_user.Text = global::QS_Client.Properties.Settings.Default.YHUser;
            // 
            // textBox_port
            // 
            this.textBox_port.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QS_Client.Properties.Settings.Default, "Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_port.Location = new System.Drawing.Point(210, 20);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(65, 21);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.Text = global::QS_Client.Properties.Settings.Default.Port;
            // 
            // textBox_IP
            // 
            this.textBox_IP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QS_Client.Properties.Settings.Default, "IPAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_IP.Location = new System.Drawing.Point(65, 20);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(100, 21);
            this.textBox_IP.TabIndex = 0;
            this.textBox_IP.Text = global::QS_Client.Properties.Settings.Default.IPAddress;
            // 
            // button_yin_yon
            // 
            this.button_yin_yon.Location = new System.Drawing.Point(189, 193);
            this.button_yin_yon.Name = "button_yin_yon";
            this.button_yin_yon.Size = new System.Drawing.Size(75, 23);
            this.button_yin_yon.TabIndex = 3;
            this.button_yin_yon.Text = "应用";
            this.button_yin_yon.UseVisualStyleBackColor = true;
            this.button_yin_yon.Click += new System.EventHandler(this.button_yin_yon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 217);
            this.Controls.Add(this.button_yin_yon);
            this.Controls.Add(this.button_kai_guan);
            this.Controls.Add(this.button_lian_jie);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(503, 256);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_xian_shi;
        private System.Windows.Forms.TextBox textBox_wen_jian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_lu_jin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_lian_jie;
        private System.Windows.Forms.Button button_kai_guan;
        private System.Windows.Forms.Button button_yin_yon;
    }
}

