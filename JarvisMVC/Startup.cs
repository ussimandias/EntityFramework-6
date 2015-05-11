using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JarvisMVC.Startup))]
namespace JarvisMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
