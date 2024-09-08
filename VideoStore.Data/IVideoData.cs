using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStore.Core;

namespace VideoStore.Data
{
    internal interface IVideoData
    {
        IEnumerable<Video> ListVideos();
    }
}
