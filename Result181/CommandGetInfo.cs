using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result181
{
    internal class CommandGetInfo : CommandInfo
    {
        private readonly InfoFromUrl _infoFromUrl;

        public CommandGetInfo(InfoFromUrl infoFromUrl)
        {
            _infoFromUrl = infoFromUrl;
        }

        public override void StartGetInfo()
        {
            _infoFromUrl?.GetVideoInfo();
        }
    }
}