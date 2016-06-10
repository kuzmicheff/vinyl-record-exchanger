using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylRecordExchanger
{
    class Tracklist
    {
        public int trackId;
        public string trackSide;
        public int trackNumber;
        public string trackTitle;
        public string trackLength;


        public Tracklist(int trackId, string trackSide, int trackNumber, string trackTitle, string trackLength)
        {
            this.trackId = trackId;
            this.trackSide = trackSide;
            this.trackNumber = trackNumber;
            this.trackTitle = trackTitle;
            this.trackLength = trackLength;
        }

        public bool Equals(Tracklist other)
        {
            if (other == null) return false;
            return (this.trackId.Equals(other.trackId));
        }
    }
}
