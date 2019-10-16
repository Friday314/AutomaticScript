using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticScript
{
    public class SysReg
    {
        /// <summary>
        /// 网络注册大漠
        /// </summary>
        /// <returns>返回注册信息</returns>
        public string Sysreg(DmSoft ds)
        {
            int Reg = ds.DM.Reg("Friday314516f00df89fdf1b29d9b99310251d3ec", "2ew8uHU7");
            if (Reg == -1)
            {
                return "无法连接网络";
            }
            else if (Reg == -2)
            {
                return "进程没有以管理员方式运行";
            }
            else if (Reg == 1)
            {
                return "系统注册成功";
            }
            else if (Reg == 2)
            {
                return "系统余额不足";
            }
            return "未知错误";
        }
    }
}
