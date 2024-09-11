
namespace WashingMachine.Model
{
    public enum MachineState
    {
        Off,
        Open,
        Locked,
        Running,
        Error
    }

    public enum MotorOperation
    {
        None,
        OpenValve,
        CloseValve,
        AddSoap,
        OpenDrain,
        CloseDrain,
        Rotate,
        Spin,
        Fault
    }
}
