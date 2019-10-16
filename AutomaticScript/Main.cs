using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticScript
{
    public partial class AutomaticScript : Form
    {
        DmReg dd = new DmReg();

        public AutomaticScript()
        {
            InitializeComponent();
        }
        private void AutomaticScript_Load(object sender, EventArgs e)
        {
            textLog.ReadOnly = true;
        }
    }
}
