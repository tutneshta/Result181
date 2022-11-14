using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result181
{
    internal class SendCommandDownloadFile
    {
        private CommandDownload _download;

        public void SetCommand(CommandDownload download)
        {
            _download = download;
        }

        public void RunDownloadFile()
        {
            _download.StartDownloadFile();
        }
    }
}