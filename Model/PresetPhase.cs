
namespace WashingMachine.Model
{
    public class PresetPhase
    {
        public MotorOperation Operation { get; set; }
        public string? Title { get; set; }
        public int Duration { get; set; }
        public int Speed { get; set; }
    }
}
