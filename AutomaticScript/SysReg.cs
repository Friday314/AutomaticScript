using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticScript
{
    public class SysReg : DmReg
    {
        /// <summary>
        /// 获得插件版本
        /// </summary>
        /// <returns>版本号</returns>
        public string Ver()
        {
            string ver = Convert.ToString(ddr("Ver"));
            return ver;
        }

        /// <summary>
        /// 基础信息初始
        /// </summary>
        /// <returns>返回注册信息</returns>
        public string Sysreg()
        {
            //int Reg = dd.DM.Reg("Friday314516f00df89fdf1b29d9b99310251d3ec", "2ew8uHU7");
            int Reg = Convert.ToInt32(ddr("Reg", new object[] { "Friday314516f00df89fdf1b29d9b99310251d3ec", "2ew8uHU7" }));
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

        /// <summary>
        /// 初始化临界
        /// </summary>
        /// <param name="dd"></param>
        /// <returns></returns>
        public string InitCri()
        {
            int i = Convert.ToInt32(ddr("InitCri"));
            if (i == 1)
            {
                return "初始化临界区";
            }
            return "初始化临界区失败";
        }

        /// <summary>
        /// 全局静态变量
        /// 窗口句柄
        /// </summary>
        public static int _HWND;

        ///// <summary>
        ///// 获取鼠标所在位置窗口句柄
        ///// </summary>
        ///// <returns>窗口句柄</returns>
        public int Hwnd()
        {
            _HWND = Convert.ToInt32(ddr("GetMousePointWindow"));
            return _HWND;
        }

        /// <summary>
        /// 获得窗体标题
        /// </summary>
        /// <returns>窗体标题</returns>
        public string getWindTitle()
        {
            Hwnd();
            String Title = Convert.ToString(ddr("GetWindowTitle", new object[] { _HWND }));
            if (Title == "TheRender")
            {
                return "雷电模拟器";
            }
            return "请确认鼠标位置！";
        }

        /// <summary>
        /// 窗口绑定
        /// </summary>
        /// <param name="dd"></param>
        /// <returns></returns>
        public string bindWindowEx()
        {
            //int i = dd.BindWindowEx(Hwnd._HWND, "gdi", "windows", "windows", "", 0);
            //int i = dd.BindWindowEx(Hwnd._HWND, "dx.graphic.opengl", "dx.mouse.position.lock.api|dx.mouse.input.lock.api|dx.mouse.raw.input", "dx.keypad.input.lock.api|dx.keypad.state.api|dx.keypad.api", "", 0);
            // 窗口前台绑定测试
            //int i = dd.DM.BindWindowEx(SysReg._HWND, "normal", "normal", "normal", "", 0);

            int i = Convert.ToInt32(ddr("BindWindowEx", new object[] { SysReg._HWND, "normal", "normal", "normal", "", 0 }));
            System.Threading.Thread.Sleep(1000);
            if (i != 1)
            {
                return "窗口绑定失败";
            }
            return "窗口绑定成功";
        }
    }
}
