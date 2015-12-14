using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fabstox_Website.Startup))]
namespace Fabstox_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
