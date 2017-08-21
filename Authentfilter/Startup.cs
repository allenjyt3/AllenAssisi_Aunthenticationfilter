using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authentfilter.Startup))]
namespace Authentfilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
