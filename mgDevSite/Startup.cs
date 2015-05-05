using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mgDevSite.Startup))]
namespace mgDevSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
