using System;
using Xunit;

public class TrainServiceTest
{
    [Fact]
    public void Start_Should_Start_Train()
    {
        var service = new TrainService();
        var train = new Train(1);
        service.Start(train);

        train.Status.Equals(TrainStatus.Running);
    }
}
