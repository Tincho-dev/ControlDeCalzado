using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlDeCalzado.Startup))]
namespace ControlDeCalzado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
