using System.Collections.Generic;

public class TrainSystem
{
    public IList<Signal> Signals { get ;set;}
    public IList<Train> Trains {get; set;}

    public TrainSystem()
    {
        this.Signals = new List<Signal>
            {
                new Signal(1),
                new Signal(2),
                new Signal(3),
                new Signal(4)
            };
        
        this.Trains = new List<Train>
        {
            new Train(1),
            new Train(2)
        };
    }

    public void Start()
    {
        var trainService = new TrainService();        
        trainService.Start(this.Trains[0]);
    }

    public void TrainCrossesSignalOne()
    {
        var signalService = new SignalService();
        signalService.SetStatus(this.Signals[0], SignalStatus.Red);
    }

}
