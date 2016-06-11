using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylRecordExchanger
{
    class Collection : IEquatable<Collection>
    {
        public int recordId;
        public decimal salePrice;
        public decimal rentPrice;
        public string albumArtist;
        public string albumTitle;
        public string releaseDate;
        public string musicalGenre;
        public string recordFormat;
        public string sideASpeed;
        public string sideBSpeed;
        public List<Tracklist> tracklist;

        public Collection(int recordId, decimal salePrice, decimal rentPrice, string albumArtist, string albumTitle, string releaseDate, string musicalGenre, string recordFormat, string sideASpeed, string sideBSpeed, List<Tracklist> tracklist)
        {
            this.recordId = recordId;
            this.salePrice = salePrice;
            this.rentPrice = rentPrice;
            this.albumArtist = albumArtist;
            this.albumTitle = albumTitle;
            this.releaseDate = releaseDate;
            this.musicalGenre = musicalGenre;
            this.recordFormat = recordFormat;
            this.sideASpeed = sideASpeed;
            this.sideBSpeed = sideBSpeed;
            this.tracklist = tracklist;
        }

        public bool Equals(Collection other)
        {
            if (other == null) return false;
            return (this.recordId.Equals(other.recordId));
        }

        //public void addRecord(string record)
        //{
        //    // add a record to the collection
        //    this.collection.Add(record);
        //}

        //public void removeRecord(string record)
        //{
        //    // remove a record from the collection
        //}

        //public List<Collection> getCollection()
        //{
        //    return this.collection;
        //}
    }
}
