public class TrainService
{
    public void Start(Train train)
    {
        train.Status = TrainStatus.Running;
    }
}