using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brass.Startup))]
namespace Brass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
