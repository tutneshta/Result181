using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Result181
{
    internal class DownloadFromUrl
    {
        private readonly string _url;

        public DownloadFromUrl(string url)
        {
            _url = url;
        }

        public async Task GetDownLoadLink()
        {
            var client = new YoutubeClient();

            var streamManifest = await client.Videos.Streams.GetManifestAsync(_url);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
    }
}