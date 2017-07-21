using System;
using Xunit;

namespace tss.test
{
    public class TrainServiceTest
    {
        [Fact]
        public void SetStatus_Should_Set_Status_Of_Given_Signal()
        {
            var service = new SignalService();
            var signal = new Signal(1);
            service.SetStatus(signal, SignalStatus.Red);

            signal.Status.Equals(SignalStatus.Red);
        }
    }
}
