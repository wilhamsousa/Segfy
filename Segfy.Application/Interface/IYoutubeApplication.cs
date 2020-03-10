using Segfy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Application.Interface
{
    public interface IYoutubeApplication
    {
        List<Youtube> PesquisarYoutube(string param, string type);
    }
}
