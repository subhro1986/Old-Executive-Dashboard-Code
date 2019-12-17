using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExecutiveDashboard.Startup))]
namespace ExecutiveDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
