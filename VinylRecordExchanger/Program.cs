using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace VinylRecordExchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string filePath = "files/title.txt";
            //    StreamReader textFile = new StreamReader(filePath);
            //    string textLine = textFile.ReadLine();
            //    while (textLine != null)
            //    {
            //        Console.WriteLine(textLine);
            //        textLine = textFile.ReadLine();
            //    }
            //    textFile.Close();
            //}
            //catch (Exception readError)
            //{
            //    DateTime timeStamp = DateTime.Now;
            //    timeStamp.ToString();
            //    StreamWriter errorFile = File.AppendText("files/errors.txt");
            //    errorFile.WriteLine("{0}: {1}", timeStamp, readError.Message);
            //    Console.WriteLine(readError.Message);
            //    errorFile.Close();
            //}

            //ConsoleKeyInfo userSelection = Console.ReadKey(true);
            //string userMode;
            //while (true)
            //{
            //    if (userSelection.KeyChar == 'y')
            //    {
            //        userMode = "new user";
            //        break;
            //    }
            //    else if (userSelection.KeyChar == 'n')
            //    {
            //        userMode = "existing user";
            //        break;
            //    }
            //    else
            //    {
            //        userSelection = Console.ReadKey(true);
            //    }
            //}

            //read file into a string and deserialize JSON to a type
            Console.WriteLine("Reading app data\n");
            string comString = File.ReadAllText("files/community.json");
            List<Community> community = JsonConvert.DeserializeObject<List<Community>>(comString);

            if (community == null)
            {
                community = new List<Community>();
            }

            Console.WriteLine("Community members\n");
            foreach (Community member in community)
            {
                Console.WriteLine("Member ID: " + member.memberId);
                Console.WriteLine("Full name: " + member.fullName);
                Console.WriteLine("Username: " + member.userName);
                Console.WriteLine("Password: " + member.password);
                Console.WriteLine("Rating: " + member.rating);
                Console.WriteLine("Wallet: $" + member.wallet + "\n");
                Console.WriteLine("Record collection\n");
                foreach (Collection record in member.collection)
                {
                    Console.WriteLine("Record ID: " + record.recordId);
                    Console.WriteLine("Sale price: $" + record.salePrice);
                    Console.WriteLine("Rent price: $" + record.rentPrice);
                    Console.WriteLine("Album artist: " + record.albumArtist);
                    Console.WriteLine("Album title: " + record.albumTitle);
                    Console.WriteLine("Release date: " + record.releaseDate);
                    Console.WriteLine("Musical genre: " + record.musicalGenre);
                    Console.WriteLine("Record format: " + record.recordFormat);
                    Console.WriteLine("Side A speed: " + record.sideASpeed);
                    Console.WriteLine("Side B speed: " + record.sideBSpeed + "\n");
                    Console.WriteLine("Record tracklist\n");
                    foreach (Tracklist track in record.tracklist)
                    {
                        Console.WriteLine("Track ID: " + track.trackId);
                        Console.WriteLine("Track number: " + track.trackSide + Convert.ToString(track.trackNumber));
                        Console.WriteLine("Track title: " + track.trackTitle);
                        Console.WriteLine("Track length: " + track.trackLength + "\n");
                    }
                }
            }

            //Member member = new Member("firstName", "lastName", "userName", "password");

            //if (userMode == "new user")
            //{
            //    member.setFirstName();
            //    member.setLastName();
            //    member.setUserName();
            //    member.setPassword();
            //}
            //else
            //{
            //    member.setFirstName();
            //    member.setLastName();
            //    member.setUserName();
            //    member.setPassword();
            //}

            //Console.WriteLine(member.getFirstName());
            //Console.WriteLine(member.getLastName());
            //Console.WriteLine(member.getUserName());
            //Console.WriteLine(member.getPassword());


            //Community community = new Community();

            //community.addMember(member.getFirstName(), member.getLastName(), member.getUserName(), member.getPassword());

            //Console.WriteLine(community.getCommunity()); 
            //Console.WriteLine(member.getFirstName());
            //Console.WriteLine(member.getLastName());
            //Console.WriteLine(member.wallet.getBalance());
            //member.wallet.depositCredits(10);
            //Console.WriteLine(member.wallet.getBalance());
            //member.wallet.withdrawCredits(20);
            //Console.WriteLine(member.wallet.getBalance());

            //Temporary line for testing output of other values to the screen.
            Console.ReadKey();
        }
    }
}
