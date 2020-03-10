using Microsoft.VisualStudio.TestTools.UnitTesting;
using Segfy.Service;

namespace Segfy.IntegrationTest
{
    [TestClass]
    public class YoutubeApiIntegrationTest
    {
        private static IServiceProvider service;
        private static Context context;
        private static IYoutubeApiService youtubeApiService;
        private static IYoutubeService youtubeService;
        private static string youtubeApiKey = "AIzaSyBmrMWqfxe0cYEmOvP7_2Z6IwvVlk4y1lQ";

        [TestMethod]
        public void PesquisarYoutubeVideo()
        {
            var response = YoutubeApiService.PesquisarYoutube(".net core 3.1", "video");
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
