using System;

namespace CastleChainOfResponsibility
{
    public abstract class TimeTellerBase : ITellTheTime
    {
        public ITellTheTime NextItemInChain { get; set; }

        public void DisplayTheTime(DateTime time)
        {
            TellTheTime(time);
            if (NextItemInChain != null)
            {
                NextItemInChain.DisplayTheTime(time);
            }
        }

        protected abstract void TellTheTime(DateTime time);
    }
}
