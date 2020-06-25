using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeTAnhDieu_1711061517.Startup))]
namespace LeTAnhDieu_1711061517
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
