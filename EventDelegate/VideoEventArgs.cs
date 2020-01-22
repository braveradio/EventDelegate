using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
