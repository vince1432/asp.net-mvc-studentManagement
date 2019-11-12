using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp.net_mvc_studentManagement.Startup))]
namespace asp.net_mvc_studentManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
