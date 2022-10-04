using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proekt.Startup))]
namespace Proekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
