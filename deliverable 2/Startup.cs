﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(deliverable_2.Startup))]
namespace deliverable_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
