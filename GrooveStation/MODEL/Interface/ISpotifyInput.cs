using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrooveStation.MODEL.Interface
{
    internal interface ISpotifyInput
    {
        List<Track> LoadSpotifySongs();
    }
}
