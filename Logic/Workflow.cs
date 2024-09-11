using System.Timers;
using WashingMachine.Model;
using WashingMachine.View;


namespace WashingMachine.Logic
{
    public sealed class Workflow
    {
        private static readonly Workflow instance = new Workflow();

        private Workflow() { }

        public static Workflow Instance { get { return instance; } }


        private void DisplayPhase(PresetPhase phase)
        {
            UserInteraction.Instance.DisplayMessage($"{phase.Title}, for {phase.Duration} " +
                ((phase.Duration == 1) ? "second" : "seconds"));
        }


        private PresetProgram program;
        private int totalPhases;
        private int currentPhaseNo;
        private System.Timers.Timer executionTimer = new System.Timers.Timer();

        public void ExecuteProgram(PresetProgram selectedProgram)
        {
            UserInteraction.Instance.DisplayMessage($"Executing program: {selectedProgram.Name}");
            this.program = selectedProgram;
            this.totalPhases = program.PhasesCount();
            this.currentPhaseNo = -1;
            this.executionTimer.Elapsed += this.OnTimedEvent;
            this.ExecuteNextPhase();
        }

        public void ExecuteNextPhase()
        {
            try
            {
                if (++this.currentPhaseNo < this.totalPhases)
                {
                    PresetPhase currentPhase = this.program[this.currentPhaseNo];
                    DisplayPhase(currentPhase);
                    this.executionTimer.Interval = currentPhase.Duration * 1000;
                    this.executionTimer.Enabled = true;
                    this.executionTimer.Start();
                    MotorController.Instance.PerformOperation(currentPhase.Operation);
                }
                else
                {
                    this.executionTimer.Stop();
                    this.executionTimer.Elapsed -= this.OnTimedEvent;
                    Manager.Instance.UpdateState(MachineState.Open);
                }
            }
            catch (Exception ex)
            {
                this.executionTimer.Stop();
                this.executionTimer.Elapsed -= this.OnTimedEvent;
                UserInteraction.Instance.DisplayMessage($"Error: {ex.Message}");
                UserInteraction.Instance.DisplayMessage($"Please make sure there is no water in the tub and open!");
                Manager.Instance.UpdateState(MachineState.Error);
                UserInteraction.Instance.StartStopWatch(1);
            }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.executionTimer.Stop();
            this.executionTimer.Enabled = false;
            this.ExecuteNextPhase();
        }
    }
}
