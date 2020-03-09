using Microsoft.VisualStudio.TestTools.UnitTesting;
using Segfy.Service.Interface;
using System;

namespace Segfy.UnitTest
{
    [TestClass]
    [TestCategory("YoutubeApi")]
    public class YoutubeApiTest
    {
        private static IServiceProvider service;
        private static IYoutubeApiService youtubeApiService;
        private static string youtubeApiKey = "AIzaSyBmrMWqfxe0cYEmOvP7_2Z6IwvVlk4y1lQ";

        [ClassInitialize()]
        public static void Start(TestContext context)
        {
            using (var ctxF = new ServicesStart())
                ctxF.Create(ref service);

            youtubeApiService = (IYoutubeApiService)service.GetService(typeof(IYoutubeApiService));
        }

        [TestMethod]
        public void PesquisarVideo()
        {
            var response = youtubeApiService.PesquisarVideo(".net core 3.1");
            response.Wait();
            var result = response.Result;
            Assert.IsTrue(result.Count > 0);
        }
    }
}
//https://www.googleapis.com/youtube/v3/search?key=AIzaSyBmrMWqfxe0cYEmOvP7_2Z6IwvVlk4y1lQ&part=snippet&mine=true&q=.net%20core%203.1&maxResults=16&type=playlist
//https://www.googleapis.com/youtube/v3/search?key=AIzaSyBmrMWqfxe0cYEmOvP7_2Z6IwvVlk4y1lQ&part=snippet&mine=true&q=.net%20core%203.1&maxResults=16&type=video