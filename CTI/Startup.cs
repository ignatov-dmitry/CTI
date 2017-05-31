using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CTI.Startup))]
namespace CTI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
