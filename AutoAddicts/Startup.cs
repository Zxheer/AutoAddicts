using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoAddicts.Startup))]
namespace AutoAddicts
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);

        }
    }
}
