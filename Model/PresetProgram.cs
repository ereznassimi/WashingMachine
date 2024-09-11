
namespace WashingMachine.Model
{
    public class PresetProgram
    {
        public string Name;
        private List<PresetPhase> phases;
        
        public PresetProgram()
        {
            this.phases = new List<PresetPhase>();
        }

        public void AddPhase(MotorOperation op, string title, int duration = 0, int speed = 0)
        {
            this.phases.Add(new PresetPhase()
            {
                Operation = op,
                Title = title,
                Duration = duration,
                Speed = speed });
        }

        //public IEnumerable<PresetPhase> NextPhase()
        //{
        //    foreach (PresetPhase phase in this.phases)
        //    {
        //        yield return phase;
        //    }
        //}

        public int PhasesCount() => this.phases.Count;

        public PresetPhase this[int index] => this.phases[index];


        public int TotalProgramDuration()
        {
            return this.phases.Sum(phase => phase.Duration);
        }
    }
}
