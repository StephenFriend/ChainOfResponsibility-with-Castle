using System;

namespace CastleChainOfResponsibility
{
    public class GmtTimeTeller : TimeTellerBase
    {
        protected override void TellTheTime(DateTime time)
        {
            Console.WriteLine("The GMT time is: {0}", time.ToUniversalTime().ToShortTimeString());
        }
    }
}
