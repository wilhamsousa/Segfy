using Segfy.Domain.Entities;
using Segfy.Domain.ValueObject;
using Segfy.Repository.Entity;
using Segfy.Repository.Repository.Interface;
using Segfy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Service
{
    public class YoutubeService : IYoutubeService
    {
        private IYoutubeRepository youtubeRepository;

        public YoutubeService(IYoutubeRepository youtubeRepository)
        {
            this.youtubeRepository = youtubeRepository;
        }

        public List<Youtube> YoutubeObjectToEntity(List<YoutubeObject> list)
        {
            var result = new List<Youtube>();
            list.ForEach(x =>
            {
                //Aqui deveria ser usado MAPPER

                result.Add(new Youtube()
                {
                    Id = x.id.playlistId == "" ? x.id.playlistId : x.id.videoId,
                    //public Kind Kind { get; set; }
                    PublishedAt = x.snippet.publishedAt,
                    ChannelId = x.snippet.channelId,
                    Title = x.snippet.title,
                    Description = x.snippet.description,

                    DefaultUrl = x.snippet.thumbnails.DefaultValue.url,
                    DefaultWidth = x.snippet.thumbnails.DefaultValue.width,
                    DefaultHeight = x.snippet.thumbnails.DefaultValue.height,

                    MediumUrl = x.snippet.thumbnails.medium.url,
                    MediumWidth = x.snippet.thumbnails.medium.width,
                    MediumHeight = x.snippet.thumbnails.medium.height,

                    HighUrl = x.snippet.thumbnails.high.url,
                    HighWidth = x.snippet.thumbnails.high.width,
                    HighHeight = x.snippet.thumbnails.high.height,

                    ChannelTitle = x.snippet.channelTitle,
                    LiveBroadcastContent = x.snippet.liveBroadcastContent,
                });
            });

            return result;
        }

        public void Salvar(List<Youtube> list)
        {
            youtubeRepository.Salvar(list);
        }

    }
}
