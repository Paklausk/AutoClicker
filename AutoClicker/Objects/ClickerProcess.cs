using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker.Objects
{
    public class ClickerProcess
    {
        ManualResetEvent _sleeper = new ManualResetEvent(false);
        Thread _thread;
        MouseClicker _mouseClicker;
        KeyPresser _keyPresser;
        public bool IsRunning { get; private set; }
        public ClickerProcess(MouseClicker mouseClicker, KeyPresser keyPresser)
        {
            _mouseClicker = mouseClicker;
            _keyPresser = keyPresser;
        }
        public void Start(ClickerParametersModel clickerParameters)
        {
            if (IsRunning)
                return;
            IsRunning = true;
            _sleeper.Reset();
            _thread = new Thread(Loop) { Name = "ClickingThread" };
            _thread.Start(clickerParameters);
        }
        public void Stop()
        {
            if (!IsRunning)
                return;
            IsRunning = false;
            _sleeper.Set();
            _thread.Join();
        }
        void Loop(object @params)
        {
            var parameters = (ClickerParametersModel)@params;
            while (IsRunning)
            {
                if (parameters.LeftMouse || parameters.RightMouse)
                    _mouseClicker.Click(parameters.LeftMouse, parameters.RightMouse);
                if (parameters.Key != Keys.None)
                    _keyPresser.Press(parameters.Key);
                _sleeper.WaitOne(parameters.IntervalMs);
            }
        }
    }
}
