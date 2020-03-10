using Segfy.Domain.ValueObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Segfy.Service.Interface
{
    public interface IYoutubeApiService
    {
        Task<List<YoutubeObject>> PesquisarYoutube(string param, string type);
    }
}
