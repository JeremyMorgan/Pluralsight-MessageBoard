using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Messageboard.Startup))]
namespace Messageboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
