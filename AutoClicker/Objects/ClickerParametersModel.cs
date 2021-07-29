using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker.Objects
{
    public class ClickerParametersModel
    {
        public Keys Key { get; set; }
        public int IntervalMs { get; set; }
        public bool LeftMouse { get; set; }
        public bool RightMouse { get; set; }
    }
}
