using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylRecordExchanger
{
    class Collection
    {
        List<string> collection;

        //public Collection()
        //{
        //    collection.Add("Empty collection");
        //}

        public void addRecord(string record)
        {
            // add a record to the collection
            this.collection.Add(record);
        }

        public void removeRecord(string record)
        {
            // remove a record from the collection
        }

        public List<string> getCollection()
        {
            return this.collection;
        }
    }
}
