using Segfy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Repository.Repository.Interface
{
    public interface IYoutubeRepository
    {
        void Salvar(List<Youtube> list);
    }
}
