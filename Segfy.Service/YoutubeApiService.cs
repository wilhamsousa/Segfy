using Newtonsoft.Json;
using Segfy.Domain.Entities;
using Segfy.Domain.ValueObject;
using Segfy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Segfy.Service
{
    public class YoutubeApiService : IYoutubeApiService
    {

        public async Task<List<YoutubeObject>> PesquisarVideo(string param)
        {
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);

            var key = "AIzaSyBmrMWqfxe0cYEmOvP7_2Z6IwvVlk4y1lQ";
            var q = Uri.EscapeUriString(param);
            var result = new List<YoutubeObject>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"https://www.googleapis.com/youtube/v3/search?key={key}&part=snippet&mine=true&q={q}&maxResults=16&type=video");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        searchListResponse searchListResponse = JsonConvert.DeserializeObject<searchListResponse>(json);
                        result = searchListResponse.items;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return result;
        }
    }
}
