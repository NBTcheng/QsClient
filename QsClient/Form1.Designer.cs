
namespace QsClient
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_kong_zhi_qu = new System.Windows.Forms.GroupBox();
            this.listBox_xian_shi = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_cao_zuo_lan = new System.Windows.Forms.GroupBox();
            this.comboBox_user = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_IPAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_ji_lu = new System.Windows.Forms.GroupBox();
            this.listBox_ji_lu = new System.Windows.Forms.ListBox();
            this.groupBox_se_zhi = new System.Windows.Forms.GroupBox();
            this.button_dao_chu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_bao_cun = new System.Windows.Forms.Button();
            this.button_jian_ting = new System.Windows.Forms.Button();
            this.groupBox_kong_zhi_qu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_cao_zuo_lan.SuspendLayout();
            this.groupBox_ji_lu.SuspendLayout();
            this.groupBox_se_zhi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_kong_zhi_qu
            // 
            this.groupBox_kong_zhi_qu.Controls.Add(this.listBox_xian_shi);
            this.groupBox_kong_zhi_qu.Controls.Add(this.label3);
            this.groupBox_kong_zhi_qu.Controls.Add(this.label2);
            this.groupBox_kong_zhi_qu.Controls.Add(this.label1);
            this.groupBox_kong_zhi_qu.Location = new System.Drawing.Point(12, 37);
            this.groupBox_kong_zhi_qu.Name = "groupBox_kong_zhi_qu";
            this.groupBox_kong_zhi_qu.Size = new System.Drawing.Size(531, 314);
            this.groupBox_kong_zhi_qu.TabIndex = 0;
            this.groupBox_kong_zhi_qu.TabStop = false;
            this.groupBox_kong_zhi_qu.Text = "控制区";
            // 
            // listBox_xian_shi
            // 
            this.listBox_xian_shi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox_xian_shi.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox_xian_shi.Font = new System.Drawing.Font("宋体", 14F);
            this.listBox_xian_shi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBox_xian_shi.FormattingEnabled = true;
            this.listBox_xian_shi.ItemHeight = 19;
            this.listBox_xian_shi.Location = new System.Drawing.Point(6, 34);
            this.listBox_xian_shi.Name = "listBox_xian_shi";
            this.listBox_xian_shi.Size = new System.Drawing.Size(508, 251);
            this.listBox_xian_shi.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(314, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "上线率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(125, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // groupBox_cao_zuo_lan
            // 
            this.groupBox_cao_zuo_lan.Controls.Add(this.button_jian_ting);
            this.groupBox_cao_zuo_lan.Controls.Add(this.comboBox_user);
            this.groupBox_cao_zuo_lan.Controls.Add(this.button1);
            this.groupBox_cao_zuo_lan.Controls.Add(this.label7);
            this.groupBox_cao_zuo_lan.Controls.Add(this.textBox_IPAddress);
            this.groupBox_cao_zuo_lan.Controls.Add(this.label6);
            this.groupBox_cao_zuo_lan.Controls.Add(this.textBox_ID);
            this.groupBox_cao_zuo_lan.Controls.Add(this.label5);
            this.groupBox_cao_zuo_lan.Controls.Add(this.label4);
            this.groupBox_cao_zuo_lan.Location = new System.Drawing.Point(549, 37);
            this.groupBox_cao_zuo_lan.MinimumSize = new System.Drawing.Size(213, 314);
            this.groupBox_cao_zuo_lan.Name = "groupBox_cao_zuo_lan";
            this.groupBox_cao_zuo_lan.Size = new System.Drawing.Size(213, 314);
            this.groupBox_cao_zuo_lan.TabIndex = 1;
            this.groupBox_cao_zuo_lan.TabStop = false;
            this.groupBox_cao_zuo_lan.Text = "操作栏";
            // 
            // comboBox_user
            // 
            this.comboBox_user.FormattingEnabled = true;
            this.comboBox_user.Location = new System.Drawing.Point(54, 35);
            this.comboBox_user.Name = "comboBox_user";
            this.comboBox_user.Size = new System.Drawing.Size(152, 20);
            this.comboBox_user.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14F);
            this.button1.Location = new System.Drawing.Point(54, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "开   启";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "操  作：";
            // 
            // textBox_IPAddress
            // 
            this.textBox_IPAddress.Location = new System.Drawing.Point(54, 107);
            this.textBox_IPAddress.Name = "textBox_IPAddress";
            this.textBox_IPAddress.Size = new System.Drawing.Size(152, 21);
            this.textBox_IPAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "用户IP：";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(54, 71);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(152, 21);
            this.textBox_ID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "用户ID：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "用户名：";
            // 
            // groupBox_ji_lu
            // 
            this.groupBox_ji_lu.Controls.Add(this.listBox_ji_lu);
            this.groupBox_ji_lu.Location = new System.Drawing.Point(18, 371);
            this.groupBox_ji_lu.Name = "groupBox_ji_lu";
            this.groupBox_ji_lu.Size = new System.Drawing.Size(525, 130);
            this.groupBox_ji_lu.TabIndex = 3;
            this.groupBox_ji_lu.TabStop = false;
            this.groupBox_ji_lu.Text = "操作记录";
            // 
            // listBox_ji_lu
            // 
            this.listBox_ji_lu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox_ji_lu.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox_ji_lu.Font = new System.Drawing.Font("宋体", 9F);
            this.listBox_ji_lu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBox_ji_lu.FormattingEnabled = true;
            this.listBox_ji_lu.ItemHeight = 12;
            this.listBox_ji_lu.Location = new System.Drawing.Point(11, 20);
            this.listBox_ji_lu.Name = "listBox_ji_lu";
            this.listBox_ji_lu.Size = new System.Drawing.Size(508, 88);
            this.listBox_ji_lu.TabIndex = 4;
            // 
            // groupBox_se_zhi
            // 
            this.groupBox_se_zhi.Controls.Add(this.button_bao_cun);
            this.groupBox_se_zhi.Controls.Add(this.button_dao_chu);
            this.groupBox_se_zhi.Controls.Add(this.label8);
            this.groupBox_se_zhi.Controls.Add(this.textBox_port);
            this.groupBox_se_zhi.Location = new System.Drawing.Point(549, 390);
            this.groupBox_se_zhi.Name = "groupBox_se_zhi";
            this.groupBox_se_zhi.Size = new System.Drawing.Size(227, 100);
            this.groupBox_se_zhi.TabIndex = 4;
            this.groupBox_se_zhi.TabStop = false;
            this.groupBox_se_zhi.Text = "设置";
            // 
            // button_dao_chu
            // 
            this.button_dao_chu.Location = new System.Drawing.Point(9, 66);
            this.button_dao_chu.Name = "button_dao_chu";
            this.button_dao_chu.Size = new System.Drawing.Size(75, 23);
            this.button_dao_chu.TabIndex = 12;
            this.button_dao_chu.Text = "导出记录";
            this.button_dao_chu.UseVisualStyleBackColor = true;
            this.button_dao_chu.Click += new System.EventHandler(this.button_dao_chu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "端口号：";
            // 
            // textBox_port
            // 
            this.textBox_port.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QsClient.Properties.Settings.Default, "Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_port.Location = new System.Drawing.Point(61, 20);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(152, 21);
            this.textBox_port.TabIndex = 10;
            this.textBox_port.Text = global::QsClient.Properties.Settings.Default.Port;
            // 
            // button_bao_cun
            // 
            this.button_bao_cun.Location = new System.Drawing.Point(146, 66);
            this.button_bao_cun.Name = "button_bao_cun";
            this.button_bao_cun.Size = new System.Drawing.Size(75, 23);
            this.button_bao_cun.TabIndex = 13;
            this.button_bao_cun.Text = "保存设置";
            this.button_bao_cun.UseVisualStyleBackColor = true;
            this.button_bao_cun.Click += new System.EventHandler(this.button_bao_cun_Click);
            // 
            // button_jian_ting
            // 
            this.button_jian_ting.Location = new System.Drawing.Point(0, 182);
            this.button_jian_ting.Name = "button_jian_ting";
            this.button_jian_ting.Size = new System.Drawing.Size(75, 23);
            this.button_jian_ting.TabIndex = 10;
            this.button_jian_ting.Text = "开始监听";
            this.button_jian_ting.UseVisualStyleBackColor = true;
            this.button_jian_ting.Click += new System.EventHandler(this.button_ting_zhi_jian_tinf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.groupBox_se_zhi);
            this.Controls.Add(this.groupBox_ji_lu);
            this.Controls.Add(this.groupBox_cao_zuo_lan);
            this.Controls.Add(this.groupBox_kong_zhi_qu);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_kong_zhi_qu.ResumeLayout(false);
            this.groupBox_kong_zhi_qu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_cao_zuo_lan.ResumeLayout(false);
            this.groupBox_cao_zuo_lan.PerformLayout();
            this.groupBox_ji_lu.ResumeLayout(false);
            this.groupBox_se_zhi.ResumeLayout(false);
            this.groupBox_se_zhi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_kong_zhi_qu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_cao_zuo_lan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_IPAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_user;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.ListBox listBox_xian_shi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_ji_lu;
        private System.Windows.Forms.ListBox listBox_ji_lu;
        private System.Windows.Forms.GroupBox groupBox_se_zhi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_dao_chu;
        private System.Windows.Forms.Button button_bao_cun;
        private System.Windows.Forms.Button button_jian_ting;
    }
}

