using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apresentacao.Startup))]
namespace Apresentacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
