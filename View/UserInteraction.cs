using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using WashingMachine.Model;
using WashingMachine.Logic;


namespace WashingMachine.View
{
    public sealed class UserInteraction
    {
        private static readonly UserInteraction instance = new UserInteraction();

        private UserInteraction() { }

        public static UserInteraction Instance { get { return instance; } }





        public delegate void DisplayMessageHandler(string message);
        public event DisplayMessageHandler? DisplayMessageCallback;

        public void DisplayMessage(string message)
        {
            this.DisplayMessageCallback?.Invoke(message);
        }


        public delegate void StartStopWatchHandler(int duration);
        public event StartStopWatchHandler? StartStopWatchCallback;

        public void StartStopWatch(int totalProgramuration)
        {
            this.StartStopWatchCallback?.Invoke(totalProgramuration);
        }
    }
}
