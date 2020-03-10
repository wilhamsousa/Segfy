using Microsoft.EntityFrameworkCore;
using Segfy.Domain.Entities;
using Segfy.Repository.Entity;
using Segfy.Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Repository.Repository
{
    public class YoutubeRepository : IYoutubeRepository
    {
        private Context context;
        public YoutubeRepository(Context context)
        {
            this.context = context;
            this.context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public void Salvar(List<Youtube> list)
        {
            list.ForEach(x =>
            {
                Manter(x);
            });
        }

        private void Manter(Youtube youtube)
        {
            var result = context.Youtube.Find(youtube.Id);
            if (result == null)
            {
                context.Youtube.Add(youtube);
            }
            else
            {
                context.Youtube.Update(youtube);
            }
            context.SaveChanges();
        }
    }
}
