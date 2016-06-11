using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylRecordExchanger
{
    class Member
    {
        public int memberId;
        public string firstName;
        public string lastName;
        public string fullName;
        public string userName;
        public string password;
        public decimal rating;
        public Wallet wallet;
        public List<Collection> collection;

        public Member()
        {
            
        }

        //public Member(int memberId, string fullName, string userName, string password, decimal rating, decimal wallet, List<Collection> collection)
        //{
        //    this.memberId = memberId;
        //    this.fullName = fullName;
        //    this.userName = userName;
        //    this.password = password;
        //    this.rating = rating;
        //    this.wallet = new Wallet(wallet);
        //    this.collection = collection;
        //}

        public void setFullName()
        {
            Console.WriteLine("Please enter your first name: ");
            this.firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            this.lastName = Console.ReadLine();
            this.fullName = string.Format("{0} {1}", firstName, lastName);
        }

        public void setUserName()
        {
            Console.WriteLine("Please enter your username: ");
            this.userName = Console.ReadLine();
        }

        public void setPassword()
        {
            Console.WriteLine("Please enter your password: ");
            this.password = Console.ReadLine();
        }

        //public string getFirstName()
        //{
        //    return this.firstName;
        //}

        //public string getLastName()
        //{
        //    return this.lastName;
        //}

        //public string getUserName()
        //{
        //    return this.userName;
        //}

        //public string getPassword()
        //{
        //    return this.password;
        //}
    }
}
