using System.Reflection;
using System.Runtime.InteropServices;

namespace AutomaticScript
{
    /// <summary>
    /// 免注册大漠
    /// </summary>
    public class DmReg
    {
        [DllImport("user32.dll", EntryPoint = "MessageBoxA")]
        static extern int MsgBox(int hWnd, string msg, string caption, int type);
        [DllImport("DmReg.dll", EntryPoint = "SetDllPathA")]
        static extern int SetDllPathA(string path, int mode);

        /// <summary>
        /// 调用大漠，无返回值
        /// </summary>
        /// <param name="name">方法名称</param>
        public void dd(string name)
        {
            int res = 0;
            res = SetDllPathA("dm.dll", 0);
            System.Type oType = System.Type.GetTypeFromProgID("dm.dmsoft");
            object o = System.Activator.CreateInstance(oType);

            object[] args = new object[0];
            oType.InvokeMember(name, BindingFlags.InvokeMethod, null, o, args);
        }

        /// <summary>
        /// 调用大漠，无返回值
        /// </summary>
        /// <param name="name">方法名称</param>
        /// <param name="args">方法参数</param>
        public void dd(string name, object[] args)
        {
            int res = 0;
            res = SetDllPathA("dm.dll", 0);
            System.Type oType = System.Type.GetTypeFromProgID("dm.dmsoft");
            object o = System.Activator.CreateInstance(oType);

            oType.InvokeMember(name, BindingFlags.InvokeMethod, null, o, args);
        }

        /// <summary>
        /// 调用大漠，有返回值
        /// </summary>
        /// <param name="name">方法名称</param>
        /// <returns>返回Object</returns>
        public object ddr(string name)
        {
            int res = 0;
            res = SetDllPathA("dm.dll", 0);
            System.Type oType = System.Type.GetTypeFromProgID("dm.dmsoft");
            object o = System.Activator.CreateInstance(oType);

            object[] args = new object[0];
            object ret = oType.InvokeMember(name, BindingFlags.InvokeMethod, null, o, args);

            return ret;
        }

        /// <summary>
        /// 调用大漠，有返回值
        /// </summary>
        /// <param name="name">方法名称</param>
        /// <param name="args">方法参数</param>
        /// <returns>返回Object</returns>
        public object ddr(string name, object[] args)
        {
            int res = 0;
            res = SetDllPathA("dm.dll", 0);
            System.Type oType = System.Type.GetTypeFromProgID("dm.dmsoft");
            object o = System.Activator.CreateInstance(oType);

            object ret = oType.InvokeMember(name, BindingFlags.InvokeMethod, null, o, args);

            return ret;
        }
    }
}
