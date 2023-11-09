using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoG2.Startup))]
namespace ProyectoG2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
