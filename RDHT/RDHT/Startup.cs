using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RDHT.Startup))]
namespace RDHT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
