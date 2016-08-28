using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Iniciando.Startup))]
namespace Iniciando
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
