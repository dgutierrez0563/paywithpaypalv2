using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(paywithpaypalv2.Startup))]
namespace paywithpaypalv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app) => ConfigureAuth(app);
    }
}
