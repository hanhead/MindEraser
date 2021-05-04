using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MindEraser.Startup))]
namespace MindEraser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
