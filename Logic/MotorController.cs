using WashingMachine.Model;


namespace WashingMachine.Logic
{
    public sealed class MotorController
    {
        private static readonly MotorController instance = new MotorController();

        private MotorController() { }

        public static MotorController Instance { get { return instance; } }

        public void PerformOperation(MotorOperation operation)
        {
            // just for test purposes
            if (operation == MotorOperation.Fault)
            {
                throw new Exception("Engine malfunction!");
            }
        }
    }
}
