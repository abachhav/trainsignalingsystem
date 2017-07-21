public enum SignalStatus
{
    Red = 1,
    Green,
    Orange
}

public class Signal
{
    public int Id {get; set;}
    public SignalStatus Status {get; set;} 

    public Signal(int id)
    {
        this.Id = id;
        this.Status = SignalStatus.Green;
    }
}