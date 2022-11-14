using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result181
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string videoUrl = "https://www.youtube.com/watch?v=a8z1m2_XUDQ";

            var client = new Client(videoUrl);

            client.ShowInfoVideo(videoUrl);
            client.DownLoadVideo(videoUrl);

            Console.ReadKey();
        }
    }
}