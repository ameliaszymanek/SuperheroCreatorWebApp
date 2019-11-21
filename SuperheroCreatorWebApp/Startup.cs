using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperheroCreatorWebApp.Startup))]
namespace SuperheroCreatorWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
