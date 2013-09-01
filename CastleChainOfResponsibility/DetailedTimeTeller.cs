using System;

namespace CastleChainOfResponsibility
{
    public class DetailedTimeTeller: TimeTellerBase
    {
        protected override void TellTheTime(DateTime time)
        {
            Console.WriteLine("The detailed time is: {0}", time.ToLongTimeString());
        }
    }
}
