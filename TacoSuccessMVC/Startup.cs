using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TacoSuccessMVC.Startup))]
namespace TacoSuccessMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
