using System;
using Xunit;

public class TrainSystemTest
{
    [Fact]
    public void Start_Should_Initialize_Train_System()
    {
        var system = new TrainSystem();
        Assert.Equal(2, system.Trains.Count);
        Assert.Equal(4, system.Signals.Count);
    }

    [Fact]
    public void Start_Should_Change_Train_Status_To_Running()
    {
        var system = new TrainSystem();
        system.Start();
        Assert.Equal(TrainStatus.Running, system.Trains[0].Status);
    }
    
    [Fact]
    public void Start_Should_Change_Status_Of_First_Signal_To_Red()
    {
        var system = new TrainSystem();
        system.TrainCrossesSignalOne();
        Assert.Equal(SignalStatus.Red, system.Signals[0].Status);
    }

}
