using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoOne.Startup))]
namespace ProyectoOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
