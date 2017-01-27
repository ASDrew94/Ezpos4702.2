using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ezpos.Startup))]
namespace Ezpos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
