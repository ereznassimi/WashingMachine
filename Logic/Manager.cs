using WashingMachine.Model;
using WashingMachine.View;


namespace WashingMachine.Logic
{
    public sealed class Manager
    {
        private static readonly Manager instance = new Manager();

        private Manager()
        {
            this.InitPrograms();
        }

        public static Manager Instance { get { return instance; } }

        private MachineState state = MachineState.Off;

        public void Init()
        {
            this.UpdateState(this.state);
        }


        public void SwitchClicked()
        {
            this.UpdateState(this.state == MachineState.Off ? MachineState.Open : MachineState.Off);
        }

        public void LockClicked()
        {
            if (this.state == MachineState.Locked || this.state == MachineState.Error)
            {
                this.UpdateState(MachineState.Open);
            }
            else
            {
                this.UpdateState(MachineState.Locked);
            }
        }

        public void StartClicked(int programIndex)
        {
            this.UpdateState(MachineState.Running);

            PresetProgram selectedProgram = this.programs[programIndex];

            int totalPragramDuration = selectedProgram.TotalProgramDuration();
            UserInteraction.Instance.StartStopWatch(totalPragramDuration);

            Workflow.Instance.ExecuteProgram(selectedProgram);
        }


        public delegate void UpdateStateHandler(MachineState state);
        public event UpdateStateHandler? UpdateStateCallback;

        public void UpdateState(MachineState state)
        {
            this.state = state;
            this.UpdateStateCallback?.Invoke(this.state);
        }


        private List<PresetProgram> programs = new List<PresetProgram>();

        private void InitPrograms()
        {
            this.AddNormalProgram();
            this.AddDelicateProgram();
            this.AddQuickProgram();
            this.AddHeavyProgram();
            this.AddRinseProgram();
            this.AddTestProgram();
        }

        private void AddNormalProgram()
        {
            PresetProgram normalProgram = new PresetProgram() { Name = "Normal Wash" };
            normalProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            normalProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            normalProgram.AddPhase(MotorOperation.AddSoap, "Adding Soap", 1);
            normalProgram.AddPhase(MotorOperation.Rotate, "Washing with Soap", 5, 1);
            normalProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            normalProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            normalProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            normalProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            normalProgram.AddPhase(MotorOperation.Rotate, "Washing just with Water", 5, 1);
            normalProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            normalProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            normalProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            normalProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            normalProgram.AddPhase(MotorOperation.Rotate, "Washing just with Water", 5, 1);
            normalProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            normalProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            normalProgram.AddPhase(MotorOperation.Spin, "Rinsing Water", 2);

            this.programs.Add(normalProgram);
        }

        private void AddDelicateProgram()
        {
            PresetProgram delicateProgram = new PresetProgram() { Name = "Delicate Wash" };
            delicateProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            delicateProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            delicateProgram.AddPhase(MotorOperation.AddSoap, "Adding Soap", 1);
            delicateProgram.AddPhase(MotorOperation.Rotate, "Washing with Soap", 5, 1);
            delicateProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            delicateProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            delicateProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            delicateProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            delicateProgram.AddPhase(MotorOperation.Rotate, "Washing just with Water", 5, 1);
            delicateProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            delicateProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            delicateProgram.AddPhase(MotorOperation.Spin, "Rinsing Water", 2);

            this.programs.Add(delicateProgram);
        }

        private void AddQuickProgram()
        {
            PresetProgram quickProgram = new PresetProgram() { Name = "Quick Wash" };
            quickProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            quickProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            quickProgram.AddPhase(MotorOperation.AddSoap, "Adding Soap", 1);
            quickProgram.AddPhase(MotorOperation.Rotate, "Washing with Soap", 5, 1);
            quickProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            quickProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            quickProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            quickProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            quickProgram.AddPhase(MotorOperation.Rotate, "Washing just with Water", 5, 1);
            quickProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            quickProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            quickProgram.AddPhase(MotorOperation.Spin, "Rinsing Water", 2);

            this.programs.Add(quickProgram);
        }

        private void AddHeavyProgram()
        {
            PresetProgram heavyProgram = new PresetProgram() { Name = "Heavy Wash" };
            heavyProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            heavyProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            heavyProgram.AddPhase(MotorOperation.AddSoap, "Adding Soap", 1);
            heavyProgram.AddPhase(MotorOperation.Rotate, "Washing with Soap", 10, 1);
            heavyProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            heavyProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            heavyProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            heavyProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            heavyProgram.AddPhase(MotorOperation.Rotate, "Washing just with Water", 5, 1);
            heavyProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            heavyProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            heavyProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            heavyProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            heavyProgram.AddPhase(MotorOperation.Rotate, "Washing just with Water", 5, 1);
            heavyProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            heavyProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            heavyProgram.AddPhase(MotorOperation.OpenValve, "Filling Water", 1);
            heavyProgram.AddPhase(MotorOperation.CloseValve, "Water Full", 1);
            heavyProgram.AddPhase(MotorOperation.Rotate, "Washing just with Water", 5, 1);
            heavyProgram.AddPhase(MotorOperation.OpenDrain, "Emptying water", 1);
            heavyProgram.AddPhase(MotorOperation.CloseDrain, "Closing Drain", 1);

            heavyProgram.AddPhase(MotorOperation.Spin, "Rinsing Water", 2);

            this.programs.Add(heavyProgram);
        }
        
        private void AddRinseProgram()
        {
            PresetProgram hrinseProgram = new PresetProgram() { Name = "Rinse & Spin" };
            hrinseProgram.AddPhase(MotorOperation.Spin, "Rinsing Water", 10);

            this.programs.Add(hrinseProgram);
        }

        private void AddTestProgram()
        {
            PresetProgram testProgram = new PresetProgram() { Name = "Error Test" };
            testProgram.AddPhase(MotorOperation.Fault, "Error Test", 20);

            this.programs.Add(testProgram);
        }
    }
}
