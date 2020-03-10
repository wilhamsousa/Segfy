using Segfy.Application.Interface;
using Segfy.Domain.Entities;
using Segfy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Application
{
    public class YoutubeApplication : IYoutubeApplication
    {
        private IYoutubeService youtubeService;
        private IYoutubeApiService youtubeApiService;
        public YoutubeApplication(IYoutubeService youtubeService, IYoutubeApiService youtubeApiService)
        {
            this.youtubeService = youtubeService;
            this.youtubeApiService = youtubeApiService;
        }
        public List<Youtube> PesquisarYoutube(string param, string type)
        {
            var youtubeApiResponse = youtubeApiService.PesquisarYoutube(param, type);
            youtubeApiResponse.Wait();
            var youtubeObject = youtubeApiResponse.Result;

            var entities = youtubeService.YoutubeObjectToEntity(youtubeObject);
            youtubeService.Salvar(entities);

            var result = entities;
            return result;
        }
    }
}
