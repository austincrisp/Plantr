using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plantr.Startup))]
namespace Plantr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
