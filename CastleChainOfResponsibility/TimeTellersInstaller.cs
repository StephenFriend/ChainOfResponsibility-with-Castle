using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace CastleChainOfResponsibility
{
    public class TimeTellersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ITellTheTime>()
                                        .ImplementedBy<GmtTimeTeller>()
                                        .DependsOn(Dependency.OnComponent<ITellTheTime,CetTimeTeller>()),
                               Component.For<ITellTheTime>()
                                         .ImplementedBy<CetTimeTeller>()
                                         .DependsOn(Dependency.OnComponent<ITellTheTime, DetailedTimeTeller>()),
                               Component.For<ITellTheTime>()
                                          .ImplementedBy<DetailedTimeTeller>());
        }
    }
}
