using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticScript
{
    class CaptureImage:DmReg
    {
        public void Capture(object[] args)
        {
            dd("Capture", args);
            System.Threading.Thread.Sleep(300);
        }
    }
}
