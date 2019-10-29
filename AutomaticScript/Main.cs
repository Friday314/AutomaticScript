using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticScript
{
    public partial class AutomaticScript : Form
    {
        //创建大漠对象
        DmReg dr = new DmReg();
        //百度API
        BaiDuAPI baidu = new BaiDuAPI();
        //基础信息初始
        SysReg sr = new SysReg();
        //移动打开
        MoveOpen mo = new MoveOpen();
        //抓图
        CaptureImage ci = new CaptureImage();

        public AutomaticScript()
        {
            InitializeComponent();
        }

        private void AutomaticScript_Load(object sender, EventArgs e)
        {
            //注册热键Shift+S，Id号为100。HotKey.KeyModifiers.Shift也可以直接使用数字4来表示。
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Shift, Keys.S);
            HotKey.RegisterHotKey(Handle, 101, HotKey.KeyModifiers.Shift, Keys.D);

            //textBox 禁止输入
            textLog.ReadOnly = true;
        }

        private void AutomaticScript_FormClosing(object sender, FormClosingEventArgs e)
        {
            //注销Id号为100的热键设定
            HotKey.UnregisterHotKey(Handle, 100);
            HotKey.UnregisterHotKey(Handle, 101);
        }

        static int _but师门 = 0;
        private void but师门_Click(object sender, EventArgs e)
        {
            if (_but师门 == 0)
            {
                but师门.BackColor = System.Drawing.Color.Olive;
                _but师门 = 1;
            }
            else if (_but师门 == 1)
            {
                but师门.BackColor = System.Drawing.Color.LightGray;
                _but师门 = 0;
            }
        }

        static int _but挖图 = 0;
        private void but挖图_Click(object sender, EventArgs e)
        {
            if (_but挖图 == 0)
            {
                but挖图.BackColor = System.Drawing.Color.Olive;
                _but挖图 = 1;
            }
            else if (_but挖图 == 1)
            {
                but挖图.BackColor = System.Drawing.Color.LightGray;
                _but挖图 = 0;
            }
        }

        /// 监视Windows消息
        /// 重载WndProc方法，用于实现热键响应
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:    //按下的是Shift+S

                            //软开启，界面初始化
                            Initi界面();
                            //人物名称及门派初始化
                            Initi人物();
                            //人物状态初始化
                            Initi人物状态();
                            //宠物状态初始化
                            Initi宠物状态();

                            break;
                        case 101:    //按下的是Shift+D

                            //窗口解绑
                            textLog.AppendText(sr.UnBindWindow());

                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        public void Initi界面()
        {
            int i = 0;
            if (i == 0)
            {
                //输出版本号
                textLog.AppendText("\r\n插件版本:" + sr.Ver() + "\r\n");
                //网络注册
                textLog.AppendText(sr.Sysreg().ToString() + "\r\n");
                //初始化临界
                textLog.AppendText(sr.InitCri() + "\r\n");
                //确认获得窗体名称
                labTitleName.Text = sr.getWindTitle();
                //窗口绑定
                textLog.AppendText(sr.bindWindowEx() + "\r\n");

                i = 1;
            }
        }

        /// <summary>
        /// 人物初始化
        /// </summary>
        public void Initi人物()
        {
            int i = 0;
            if (i == 0)
            {
                //获得人物名称及门派
                mo.Open人物属性();

                //截图 人物名称
                ci.Capture(new object[] { 200, 94, 376, 127, "./Image/人物名称.bmp" });
                //百度识字
                lab人物名称.Text = baidu.Ocr_Baidu("./Image/人物名称.bmp");
                // 截图 人物门派
                ci.Capture(new object[] { 152, 157, 193, 284, "./Image/人物门派.bmp" });
                //百度识字
                lab人物门派.Text = baidu.Ocr_Baidu("./Image/人物门派.bmp");

                //关闭人物属性面板
                mo.TurnOff(new object[] { 1073, 52 });

                i = 1;
            }
        }

        /// <summary>
        /// 人物状态初始化
        /// </summary>
        public void Initi人物状态()
        {
            int i = 0;
            if (i == 0)
            {
                mo.Open人物状态();

                //截图 人物血量
                ci.Capture(new object[] { 1001, 151, 1223, 183, "./Image/人物血量.bmp" });
                lab人物血量.Text = baidu.Ocr_Baidu("./Image/人物血量.bmp");

                //截图 人物蓝量
                ci.Capture(new object[] { 1004, 181, 1256, 212, "./Image/人物蓝量.bmp" });
                lab人物蓝量.Text = baidu.Ocr_Baidu("./Image/人物蓝量.bmp");

                //关闭状态面板
                mo.TurnOff(new object[] { 1131, 273 });

                i = 1;
            }
        }

        /// <summary>
        /// 宠物状态初始化
        /// </summary>
        public void Initi宠物状态()
        {
            int i = 0;
            if (i == 0)
            {
                mo.Open宠物状态();

                //截图 宠物血量
                ci.Capture(new object[] { 810, 151, 1043, 183, "./Image/宠物血量.bmp" });
                lab宠物血量.Text = baidu.Ocr_Baidu("./Image/宠物血量.bmp");

                //截图 宠物蓝量
                ci.Capture(new object[] { 812, 182, 1028, 212, "./Image/宠物蓝量.bmp" });
                lab宠物蓝量.Text = baidu.Ocr_Baidu("./Image/宠物蓝量.bmp");

                //截图 人物蓝量
                //ci.Capture(new object[] { 1004, 181, 1256, 212, "./Image/人物蓝量.bmp" });
                //lab人物蓝量.Text = baidu.Ocr_Baidu("./Image/人物蓝量.bmp");

                //宠物忠诚度还未做

                //关闭状态面板
                mo.TurnOff(new object[] { 1131, 273 });

                i = 1;
            }
        }
    }
}
