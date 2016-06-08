using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VinylRecordExchanger
{
    class Community
    {
        string community;

        public void addMember(string firstName, string lastName, string userName, string password)
        {
            // add a member to the community
            string fName = firstName;
            string lName = lastName;
            string uName = userName;
            string pWord = password;
            string line = string.Format("{0},{1},{2},{3}", fName, lName, uName, pWord);
            StreamWriter community = File.AppendText("files/community.txt");
            community.WriteLine(line);
            Console.WriteLine(community);
            community.Close();
        }

        public void removeMember(string member)
        {
            // remove a member from the community
        }

        public string getCommunity()
        {
            return this.community;
        }
    }
}
