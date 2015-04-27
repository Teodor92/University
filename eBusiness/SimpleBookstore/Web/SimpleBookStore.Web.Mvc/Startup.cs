using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleBookStore.Web.Mvc.Startup))]
namespace SimpleBookStore.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
