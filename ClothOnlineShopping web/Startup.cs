using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothOnlineShopping_web.Startup))]
namespace ClothOnlineShopping_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
