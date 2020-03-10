using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Segfy.Application.Interface;
using Segfy.Repository.Entity;

namespace Segfy.Api.Controllers
{
    [ApiController]
    [Route("api/Youtube")]
    public class YoutubeController : ControllerBase
    {
        private IServiceProvider provider;
        public YoutubeController(IServiceProvider provider)
        {
            this.provider = provider;
        }

        [HttpGet]
        public IActionResult PesquisarYoutube(string param = ".net Core 3", string type = "video")
        {
            var youtubeApplication = (IYoutubeApplication)provider.GetService(typeof(IYoutubeApplication));
            var result = youtubeApplication.PesquisarYoutube(param, type);
            return Ok(result);
        }
    }
}
