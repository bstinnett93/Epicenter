using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Epicenter.Startup))]
namespace Epicenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
