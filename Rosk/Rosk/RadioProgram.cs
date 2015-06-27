using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosk
{
    class RadioProgram
    {
        private string title;
        private DateTime startDateTime;
        private uint length;
        private string information;

        public RadioProgram(string title, DateTime startDateTime, uint length, string information)
        {
            this.title = title;
            this.startDateTime = startDateTime;
            this.length = length;
            this.information = information;
        }
    }
}
