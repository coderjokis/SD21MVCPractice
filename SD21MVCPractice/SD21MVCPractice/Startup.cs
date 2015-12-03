using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SD21MVCPractice.Startup))]
namespace SD21MVCPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
