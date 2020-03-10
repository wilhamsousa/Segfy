using Segfy.Domain.Entities;
using Segfy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Service.Interface
{
    public interface IYoutubeService
    {
        List<Youtube> YoutubeObjectToEntity(List<YoutubeObject> list);
        void Salvar(List<Youtube> list);
    }
}
