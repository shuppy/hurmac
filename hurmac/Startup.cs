using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hurmac.Startup))]
namespace hurmac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
