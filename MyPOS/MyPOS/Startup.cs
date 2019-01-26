using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPOS.Startup))]
namespace MyPOS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
