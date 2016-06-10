using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylRecordExchanger
{
    class Community : IEquatable<Community>
    {
        public int memberId;
        public string fullName;
        public string userName;
        public string password;
        public decimal rating;
        public decimal wallet;
        public List<Collection> collection;


        public Community(int memberId, string fullName, string userName, string password, decimal rating, decimal wallet, List<Collection> collection)
        {
            this.memberId = memberId;
            this.fullName = fullName;
            this.userName = userName;
            this.password = password;
            this.rating = rating;
            this.wallet = wallet;
            this.collection = collection;
        }

        public bool Equals(Community other)
        {
            if (other == null) return false;
            return (this.memberId.Equals(other.memberId));
        }
    }
}
