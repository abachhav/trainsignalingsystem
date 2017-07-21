public enum TrainStatus
{
    Idle = 1,
    Running
}
public class Train
{
    public int Id {get; set;}
    public TrainStatus Status {get; set;}

    public Train(int id)
    {
        Id = id;
        Status = TrainStatus.Idle;
    }
}