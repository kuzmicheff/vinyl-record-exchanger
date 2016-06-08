using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylRecordExchanger
{
    class Community
    {
        List<string> community;

        public void addMember(string member)
        {
            // add a member to the community
            community.Add(member);
        }

        public void removeMember(string member)
        {
            // remove a member from the community
        }

        public List<string> getCommunity()
        {
            return this.community;
        }
    }
}
