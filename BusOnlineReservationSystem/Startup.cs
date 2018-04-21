using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusOnlineReservationSystem.Startup))]
namespace BusOnlineReservationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
