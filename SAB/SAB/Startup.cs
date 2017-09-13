using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAB.Startup))]
namespace SAB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
