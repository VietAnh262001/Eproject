using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EProjectASP.Startup))]
namespace EProjectASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
