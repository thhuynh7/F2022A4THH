using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S2022A4THH.Startup))]
namespace S2022A4THH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
