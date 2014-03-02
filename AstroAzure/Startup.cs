using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AstroAzure.Startup))]
namespace AstroAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
