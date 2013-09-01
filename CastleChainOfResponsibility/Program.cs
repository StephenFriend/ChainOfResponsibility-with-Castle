using System;
using Castle.Windsor;

namespace CastleChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BootstrapContainer();
            var gmtTimeTeller = container.Resolve<ITellTheTime>();

            gmtTimeTeller.DisplayTheTime(DateTime.Now);

            Console.ReadKey();
        }

        private static IWindsorContainer BootstrapContainer()
        {
            return new WindsorContainer().Install(new TimeTellersInstaller());
        }
    }
}
