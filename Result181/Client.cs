using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result181
{
    internal class Client
    {
        private string _url;

        public Client(string url)
        {
            this._url = url;
        }

        public Task ShowInfoVideo(string url)
        {
            var sendCommandGetInfo = new SendCommandGetInfo();
            var infoFromUrl = new InfoFromUrl(url);

            var commandGetInfo = new CommandGetInfo(infoFromUrl);
            sendCommandGetInfo.SetCommand(commandGetInfo);

            sendCommandGetInfo.RunGetInfo();
            return Task.CompletedTask;
        }

        public Task DownLoadVideo(string url)
        {
            var sendCommandDownload = new SendCommandDownloadFile();
            var downloadFromUrl = new DownloadFromUrl(url);

            var commandDownload = new CommandDownloadFile(downloadFromUrl);
            sendCommandDownload.SetCommand(commandDownload);

            sendCommandDownload.RunDownloadFile();
            return Task.CompletedTask;
        }
    }
}