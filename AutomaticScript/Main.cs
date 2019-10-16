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
        DmSoft ds = new DmSoft();
        SysReg sr = new SysReg();

        public AutomaticScript()
        {
            InitializeComponent();
        }

        private void AutomaticScript_Load(object sender, EventArgs e)
        {
            //textBox 禁止输入
            textLog.ReadOnly = true;

            //网络注册
            textLog.Text = sr.Sysreg(ds) + "\n";

            //输出版本号
            textLog.Text = "插件版本:" + ds.VER + "\n";
        }
    }
}
