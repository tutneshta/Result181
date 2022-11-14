using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result181
{
    internal class SendCommandGetInfo
    {
        private CommandInfo _info;

        public void SetCommand(CommandInfo info)
        {
            _info = info;
        }

        public void RunGetInfo()
        {
            _info.StartGetInfo();
        }
    }
}