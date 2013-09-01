using System;

namespace CastleChainOfResponsibility
{
    class CetTimeTeller: TimeTellerBase
    {
        protected override void TellTheTime(DateTime time)
        {
            Console.WriteLine("The time in Central Europe is: {0}", time.ToUniversalTime().AddHours(1).ToShortTimeString());
        }
    }
}
