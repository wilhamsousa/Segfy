using Microsoft.Extensions.DependencyInjection;
using Segfy.Repository.Entity;
using Segfy.Service;
using Segfy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.UnitTest
{
    public class ServicesStart : IDisposable
    {
        public void Create(ref IServiceProvider service)
        {
            var services = new ServiceCollection();

            services.AddTransient<IYoutubeApiService, YoutubeApiService>();
            service = services.BuildServiceProvider();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
