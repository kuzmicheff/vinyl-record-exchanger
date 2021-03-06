﻿using System;
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
            //show title and intro
            try
            {
                string filePath = "files/title.txt";
                StreamReader textFile = new StreamReader(filePath);
                string textLine = textFile.ReadLine();
                while (textLine != null)
                {
                    Console.WriteLine(textLine);
                    textLine = textFile.ReadLine();
                }
                textFile.Close();
            }
            catch (Exception readError)
            {
                DateTime timeStamp = DateTime.Now;
                timeStamp.ToString();
                StreamWriter errorFile = File.AppendText("files/errors.txt");
                errorFile.WriteLine("{0}: {1}", timeStamp, readError.Message);
                Console.WriteLine(readError.Message);
                errorFile.Close();
            }

            //ask if user is running the app for the first time
            Console.WriteLine("Is it your first time using this application?");
            Console.WriteLine("Please enter yes or no to continue:");

            //user enters selection
            string userSelection = Console.ReadLine();
            string userMode;
            while (true)
            {
                if (userSelection == "yes")
                {
                    userMode = "new member";
                    break;
                }
                else if (userSelection == "no")
                {
                    userMode = "existing member";
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter yes or no to continue:");
                    userSelection = Console.ReadLine();
                }
            }

            //read file into a string and deserialize JSON to a type
            Console.WriteLine("Reading app data\n");
            string dataImport = File.ReadAllText("files/community.json");
            List<Community> members = JsonConvert.DeserializeObject<List<Community>>(dataImport);

            if (members == null)
            {
                members = new List<Community>();
            }

            List<string> currentMembers = new List<string>();

            foreach (Community member in members)
            {
                currentMembers.Add(member.userName);
            }

            List<string> currentPasswords = new List<string>();

            foreach (Community member in members)
            {
                currentPasswords.Add(member.password);
            }

            string currentMember;
            int currentIndex;

            //register a new member
            if (userMode == "new member")
            {
                Member newMember = new Member();

                newMember.memberId = members.Count + 1;
                newMember.setFullName();
                newMember.setUserName();
                newMember.setPassword();
                newMember.rating = 0;
                newMember.wallet = new Wallet(10);
                newMember.collection = new List<Collection>();

                Community member = new Community(newMember.memberId, newMember.fullName, newMember.userName, newMember.password, newMember.rating, newMember.wallet.balance, newMember.collection);
                members.Add(member);
                currentMember = newMember.userName;
                currentMembers.Add(currentMember);
                currentIndex = currentMembers.IndexOf(currentMember);
            }
            //authenticate an existing member
            else
            {
                Member existingMember = new Member();

                //check username

                existingMember.setUserName();

                while (true)
                {
                    if (currentMembers.Contains(existingMember.userName))
                    {
                        currentMember = existingMember.userName;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The username is invalid!");
                        existingMember.setUserName();
                    }
                }

                currentIndex = currentMembers.IndexOf(currentMember);

                //check password

                existingMember.setPassword();

                while (true)
                {
                    if (existingMember.password == currentPasswords[currentIndex])
                    {
                        Console.WriteLine("You have logged in successfully!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The password is invalid!");
                        existingMember.setPassword();
                    }
                }
            }

            Member activeMember = new Member();
            activeMember.memberId = members[currentIndex].memberId;
            activeMember.fullName = members[currentIndex].fullName;
            activeMember.userName = members[currentIndex].userName;
            activeMember.password = members[currentIndex].password;
            activeMember.rating = members[currentIndex].rating;
            activeMember.wallet = new Wallet(members[currentIndex].wallet);
            activeMember.collection = members[currentIndex].collection;

            Console.WriteLine("Member profile");
            Console.WriteLine("Full name: " + activeMember.fullName);
            Console.WriteLine("Username: " + activeMember.userName);
            Console.WriteLine("Rating: " + activeMember.rating);
            Console.WriteLine("Wallet: $" + activeMember.wallet.balance);
            Console.WriteLine("Record collection\n");
            foreach (Collection record in activeMember.collection)
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

            //list the entire community with collections
            //Console.WriteLine("Community members\n");
            //foreach (Community member in members)
            //{
            //    Console.WriteLine("Member ID: " + member.memberId);
            //    Console.WriteLine("Full name: " + member.fullName);
            //    Console.WriteLine("Username: " + member.userName);
            //    Console.WriteLine("Password: " + member.password);
            //    Console.WriteLine("Rating: " + member.rating);
            //    Console.WriteLine("Wallet: $" + member.wallet + "\n");
            //    Console.WriteLine("Record collection\n");
            //    foreach (Collection record in member.collection)
            //    {
            //        Console.WriteLine("Record ID: " + record.recordId);
            //        Console.WriteLine("Sale price: $" + record.salePrice);
            //        Console.WriteLine("Rent price: $" + record.rentPrice);
            //        Console.WriteLine("Album artist: " + record.albumArtist);
            //        Console.WriteLine("Album title: " + record.albumTitle);
            //        Console.WriteLine("Release date: " + record.releaseDate);
            //        Console.WriteLine("Musical genre: " + record.musicalGenre);
            //        Console.WriteLine("Record format: " + record.recordFormat);
            //        Console.WriteLine("Side A speed: " + record.sideASpeed);
            //        Console.WriteLine("Side B speed: " + record.sideBSpeed + "\n");
            //        Console.WriteLine("Record tracklist\n");
            //        foreach (Tracklist track in record.tracklist)
            //        {
            //            Console.WriteLine("Track ID: " + track.trackId);
            //            Console.WriteLine("Track number: " + track.trackSide + Convert.ToString(track.trackNumber));
            //            Console.WriteLine("Track title: " + track.trackTitle);
            //            Console.WriteLine("Track length: " + track.trackLength + "\n");
            //        }
            //    }
            //}

            Console.WriteLine("Updating app data\n");
            string dataExport = JsonConvert.SerializeObject(members);
            File.WriteAllText("files/community.json", dataExport);

            //Temporary line for testing output of other values to the screen.
            Console.WriteLine("Press any key to close the app:");
            Console.ReadKey();
        }
    }
}
