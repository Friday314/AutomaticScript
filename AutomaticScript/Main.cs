using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticScript
{
    public partial class AutomaticScript : Form
    {
        //百度API
        BaiDuAPI baidu = new BaiDuAPI();

        //DD 函数
        DD_Function df = new DD_Function();

        public static bool showValueIf = false;
        public static bool showValueLogIf = false;

        public AutomaticScript()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
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

                            break;
                        case 101:    //按下的是Shift+D

                            //窗口解绑
                            textLog.AppendText(df.UnBindWindow());

                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        public void _Show()
        {
            while (true)
            {
                if (showValueIf)
                {
                     lab窗口名称.Text = ShowValue.lab窗口名称;
                    showValueIf = false;
                }
            }
        }

        public void _Showlog()
        {
            while (true)
            {
                if (showValueLogIf)
                {
                    textLog.AppendText(ShowValue.textLog + "\r\n");
                    showValueIf = false;
                }
            }
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
                textLog.AppendText("\r\n插件版本:" + df.Ver() + "\r\n");
                //网络注册
                textLog.AppendText(df.Sysreg().ToString() + "\r\n");
                //初始化临界
                textLog.AppendText(df.InitCri() + "\r\n");
                //确认获得窗体名称
                ShowValue.lab窗口名称 = df.getWindTitle();
                showValueIf = true;
                //窗口绑定
                ShowValue.textLog=df.bindWindowEx();
                showValueLogIf = true;

                i = 1;
            }
        }
    }
}
