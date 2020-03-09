using Segfy.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Segfy.Service.Interface
{
    public interface IYoutubeApiService
    {
        Task<List<YoutubeObject>> PesquisarVideo(string param);
    }
}
