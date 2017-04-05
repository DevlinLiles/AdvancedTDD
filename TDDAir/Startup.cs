using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDDAir.Startup))]
namespace TDDAir
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
