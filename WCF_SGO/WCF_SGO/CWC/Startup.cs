using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CWC.Startup))]
namespace CWC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
