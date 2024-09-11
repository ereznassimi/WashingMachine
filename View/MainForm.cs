using WashingMachine.Logic;
using WashingMachine.Model;
using WashingMachine.Properties;


namespace WashingMachine.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Manager.Instance.UpdateStateCallback += this.UpdateState;

            UserInteraction.Instance.DisplayMessageCallback += this.DisplayMessage;
            UserInteraction.Instance.StartStopWatchCallback += this.StartStopWatch;

            Manager.Instance.Init();
        }


        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            Manager.Instance.SwitchClicked();
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            Manager.Instance.LockClicked();
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            RadioButton? checkedRadioButton =
                this.groupBoxPrograms.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked);

            int selectedProgramIndex = checkedRadioButton?.TabIndex ?? 0;
            Manager.Instance.StartClicked(selectedProgramIndex);
        }


        public void UpdateState(MachineState state)
        {
            UpdateVisibilty(state);
            this.DisplayMessage(state.ToString());
        }

        public void UpdateVisibilty(MachineState state)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(UpdateVisibilty, state);
                return;
            }

            switch (state)
            {
                case MachineState.Off:
                    this.buttonOnOff.BackColor = Color.LightPink;
                    this.buttonOnOff.Enabled = true;
                    this.buttonOnOff.Text = "Turn On";
                    this.groupBoxPrograms.Enabled = false;
                    this.buttonLock.Enabled = false;
                    this.buttonLock.Image = Resources.lock_open_icon;
                    this.buttonLock.Text = "Lock";
                    break;

                case MachineState.Open:
                    this.buttonOnOff.BackColor = Color.LightGreen;
                    this.buttonOnOff.Enabled = true;
                    this.buttonOnOff.Text = "Turn Off";
                    this.groupBoxPrograms.Enabled = true;
                    this.buttonLock.Enabled = true;
                    this.buttonLock.Text = "Lock";
                    this.buttonStart.Enabled = false;
                    break;

                case MachineState.Locked:
                    this.buttonLock.Image = Resources.lock_close_icon;
                    this.buttonLock.Text = "Open";
                    this.buttonStart.Enabled = true;
                    break;

                case MachineState.Running:
                    this.buttonOnOff.Enabled = false;
                    this.groupBoxPrograms.Enabled = false;
                    this.buttonLock.Enabled = false;
                    this.buttonStart.Enabled = false;
                    break;

                case MachineState.Error:
                    this.buttonOnOff.Enabled = true;
                    this.groupBoxPrograms.Enabled = true;
                    this.buttonLock.Enabled = true;
                    this.buttonStart.Enabled = false;
                    break;

                default:
                    break;
            }
        }

        public string TimeString()
        {
            return DateTime.Now.ToString("HH:mm:ss\t");
        }

        public void DisplayMessage(string message)
        {
            if (this.textBoxMessages.InvokeRequired)
            {
                this.textBoxMessages.Invoke(DisplayMessage, message);
                return;
            }
         
            this.textBoxMessages.Text += TimeString() + message + Environment.NewLine;
            this.textBoxMessages.SelectionStart = this.textBoxMessages.Text.Length;
            this.textBoxMessages.ScrollToCaret();
        }


        private int remainingDuration = 1;

        private void SetStopWatchLabelText()
        {
            this.labelStopWatch.Text = $"{(remainingDuration / 60):D2}:{(remainingDuration % 60):D2}";
        }

        public void StartStopWatch(int totalProgramuration)
        {
            this.remainingDuration = totalProgramuration;
            this.SetStopWatchLabelText();
            this.timerStopWatch.Start();
        }

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            this.remainingDuration--;
            this.SetStopWatchLabelText();
            if (this.remainingDuration == 0)
            {
                this.timerStopWatch.Stop();
            }
        }
    }
}
