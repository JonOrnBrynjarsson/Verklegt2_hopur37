using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mooshak20.Startup))]
namespace Mooshak20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
