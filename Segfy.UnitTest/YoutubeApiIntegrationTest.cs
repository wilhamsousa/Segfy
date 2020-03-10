using Microsoft.VisualStudio.TestTools.UnitTesting;
using Segfy.Repository.Entity;
using Segfy.Domain.Entities;
using Segfy.Service.Interface;
using System;

namespace Segfy.UnitTest
{
    [TestClass]
    [TestCategory("YoutubeApi")]
    public class YoutubeApiTest
    {
        private static IServiceProvider service;
        private static Context context;
        private static IYoutubeApiService youtubeApiService;
        private static IYoutubeService youtubeService;
        private static string youtubeApiKey = "AIzaSyBmrMWqfxe0cYEmOvP7_2Z6IwvVlk4y1lQ";

        [ClassInitialize()]
        public static void Start(TestContext testContext)
        {
            using (var ctxF = new ServicesStart())
                ctxF.Create(ref service);

            youtubeApiService = (IYoutubeApiService)service.GetService(typeof(IYoutubeApiService));
            youtubeService = (IYoutubeService)service.GetService(typeof(IYoutubeService));
        }        

        [TestMethod]
        public void PesquisarYoutubeVideo()
        {
            var response = youtubeApiService.PesquisarYoutube(".net core 3.1", "video");
            response.Wait();
            var result = response.Result;
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void PesquisarYoutubePlaylist()
        {
            var response = youtubeApiService.PesquisarYoutube(".net core 3.1", "playlist");
            response.Wait();
            var result = response.Result;
            Assert.IsTrue(result.Count > 0);
        }

        
    }
}
//https://www.googleapis.com/youtube/v3/search?key=AIzaSyBmrMWqfxe0cYEmOvP7_2Z6IwvVlk4y1lQ&part=snippet&mine=true&q=.net%20core%203.1&maxResults=16&type=playlist
//https://www.googleapis.com/youtube/v3/search?key=AIzaSyBmrMWqfxe0cYEmOvP7_2Z6IwvVlk4y1lQ&part=snippet&mine=true&q=.net%20core%203.1&maxResults=16&type=video