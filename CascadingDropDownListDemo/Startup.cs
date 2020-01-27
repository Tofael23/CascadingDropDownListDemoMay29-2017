using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CascadingDropDownListDemo.Startup))]
namespace CascadingDropDownListDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
