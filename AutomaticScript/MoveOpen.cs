﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticScript
{
    /// <summary>
    /// 鼠标移动打开
    /// </summary>
    class MoveOpen:DmReg
    {
        /// <summary>
        /// 打开道具
        /// </summary>
        public void OpenPackage_道具()
        {
            //鼠标移动到背包图标
            dd("MoveToEx", new object[] { 1113, 670, 1148, 701 });
            dd("LeftClick");
            //延时
            System.Threading.Thread.Sleep(500);
            //鼠标移动到道具
            dd("MoveToEx", new object[] { 592, 118, 717, 155 });
            dd("LeftClick");
            //延时
            System.Threading.Thread.Sleep(500);
        }

        /// <summary>
        /// 打开行囊
        /// </summary>
        public void OpenPackage_行囊()
        {
            OpenPackage_道具();
            //鼠标移动到行囊
            dd("MoveToEx", new object[] { 1143, 17, 1183, 66 });
            dd("LeftClick");
            //延时
            System.Threading.Thread.Sleep(500);
        }

        /// <summary>
        /// 打开人物属性
        /// </summary>
        public void Open人物属性()
        {
            //鼠标移动到人物头像
            dd("MoveToEx", new object[] { 1133, 18, 1185, 68 });
            dd("LeftClick");
            //延时
            System.Threading.Thread.Sleep(500);
        }
    }
}
