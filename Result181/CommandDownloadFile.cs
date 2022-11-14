using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result181
{
    internal class CommandDownloadFile : CommandDownload
    {
        private readonly DownloadFromUrl _downFromUrl;

        public CommandDownloadFile(DownloadFromUrl downFromUrl)
        {
            _downFromUrl = downFromUrl;
        }

        public override void StartDownloadFile()
        {
            _downFromUrl?.GetDownLoadLink();
        }
    }
}