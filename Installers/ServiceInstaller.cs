﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using System.Reflection;

namespace mi_kan_project_backend.Installers
{
    public class ServiceInstaller : IInstallers
    {
        public void InstallServices(WebApplicationBuilder builder)
        {
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(containerBuilder =>
            {
                containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                //- จะค้นหาชื่อไฟล์ที่ลงท้ายด้วย Service แล้วจะ DI โดยอัตโนมัติ
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();
            }));
        }
    }
}
