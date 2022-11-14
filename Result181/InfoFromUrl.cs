using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Result181
{
    internal class InfoFromUrl
    {
        private string _url;

        public InfoFromUrl(string url)
        {
            _url = url;
        }

        public async Task GetVideoInfo()
        {
            var client = new YoutubeClient();
            var video = await client.Videos.GetAsync(_url);

            Console.WriteLine($"Название: {video.Title.ToString()}");
            Console.WriteLine($"Продолжительность: {video.Duration}");
            Console.WriteLine($"Автор: {video.Author}");
        }
    }
}