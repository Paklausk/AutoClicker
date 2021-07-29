using AutoClicker.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MainWindow : Form
    {
        class StateMachine
        {
            public enum Command
            {
                Start,
                Stop
            }
            enum State
            {
                Started,
                Stopped
            }
            MainWindow _window;
            State _state;
            public StateMachine(MainWindow window)
            {
                _window = window;
            }
            public void CallCommand(Command command)
            {
                switch (command)
                {
                    case Command.Start:
                        if (_state != State.Started)
                            InitiateState(State.Started);
                        break;
                    case Command.Stop:
                        if (_state != State.Stopped)
                            InitiateState(State.Stopped);
                        break;
                    default:
                        break;
                }
            }
            void InitiateState(State newState)
            {
                switch (newState)
                {
                    case State.Started:
                        StartedState();
                        break;
                    case State.Stopped:
                        StoppedState();
                        break;
                    default:
                        break;
                }
                _state = newState;
            }
            void StartedState()
            {
                _window.Start();
                _window.SetUiStyleStarted();
            }
            void StoppedState()
            {
                _window.Stop();
                _window.SetUiStyleStopped();
            }
        }
        StateMachine _stateMachine;
        AudioPlayer _audioPlayer = new AudioPlayer();
        GlobalKeyCatcher _keyCatcher = new GlobalKeyCatcher();
        ClickerProcess _clickerProcess = new ClickerProcess(new MouseClicker(), new KeyPresser());
        public MainWindow()
        {
            InitializeComponent();
            _stateMachine = new StateMachine(this);
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            _stateMachine.CallCommand(StateMachine.Command.Stop);
            _keyCatcher.KeyboardPressed += GlobalKeyboardPressed;
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _stateMachine.CallCommand(StateMachine.Command.Stop);
            _keyCatcher.Dispose();
        }
        private void GlobalKeyboardPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            try
            {
                switch (e.KeyboardData.VirtualKeyPressed)
                {
                    case Keys.F11:
                        _stateMachine.CallCommand(StateMachine.Command.Start);
                        break;
                    case Keys.F12:
                        _stateMachine.CallCommand(StateMachine.Command.Stop);
                        break;
                }
            }
            catch (Exception ex) { UiHelper.ShowError(ex.Message); }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                _stateMachine.CallCommand(StateMachine.Command.Start);
            }
            catch (Exception ex) { UiHelper.ShowError(ex.Message); }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                _stateMachine.CallCommand(StateMachine.Command.Stop);
            }
            catch (Exception ex) { UiHelper.ShowError(ex.Message); }
        }
        void Start()
        {
            var parameters = ExtractParameters();
            _clickerProcess.Start(parameters);
            if (audioCheckBox.Checked)
                _audioPlayer.Play();
        }
        void Stop()
        {
            _clickerProcess.Stop();
            if (_audioPlayer.IsPlaying)
                _audioPlayer.Stop();
        }
        void SetUiStyleStarted()
        {
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            KeyTextBox.Enabled = false;
            IntervalTextBox.Enabled = false;
            leftMouseCheckBox.Enabled = false;
            rightMouseCheckBox.Enabled = false;
            audioCheckBox.Enabled = false;
            StatusLabel.Text = "Started";
            StatusLabel.ForeColor = Color.DarkGreen;
        }
        void SetUiStyleStopped()
        {
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            KeyTextBox.Enabled = true;
            IntervalTextBox.Enabled = true;
            leftMouseCheckBox.Enabled = true;
            rightMouseCheckBox.Enabled = true;
            audioCheckBox.Enabled = true;
            StatusLabel.Text = "Stopped";
            StatusLabel.ForeColor = Color.DarkRed;
        }
        ClickerParametersModel ExtractParameters()
        {
            ClickerParametersModel parameters = new ClickerParametersModel();
            int interval;
            if (int.TryParse(IntervalTextBox.Text, out interval) && interval > 0)
                parameters.IntervalMs = interval;
            else throw new Exception("Invalid interval value. Must be integer higher than 0.");
            try
            {
                parameters.Key = string.IsNullOrEmpty(KeyTextBox.Text) ? Keys.None : (Keys)Enum.Parse(typeof(Keys), KeyTextBox.Text, true);
            }
            catch { throw new Exception("Failed to convert text to key, invalid key value."); } 
            parameters.LeftMouse = leftMouseCheckBox.Checked;
            parameters.RightMouse = rightMouseCheckBox.Checked;
            return parameters;
        }
    }
}
