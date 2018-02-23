using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RuiDa1.Startup))]
namespace RuiDa1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
