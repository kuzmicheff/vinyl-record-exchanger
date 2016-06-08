using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VinylRecordExchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            string textLine;
            try
            {
                filePath = "files/title.txt";
                StreamReader textFile = new StreamReader(filePath);
                textLine = textFile.ReadLine();
                while (textLine != null)
                {
                    Console.WriteLine(textLine);
                    textLine = textFile.ReadLine();
                }
                textFile.Close();
            }
            catch(Exception readError)
            {
                DateTime timeStamp = DateTime.Now;
                timeStamp.ToString();
                StreamWriter errorFile = File.AppendText("files/errors.txt");
                errorFile.WriteLine("{0}: {1}", timeStamp, readError.Message);
                Console.WriteLine(readError.Message);
                errorFile.Close();
            }

            //Alternative way to read text from a file.
            //string title = File.ReadAllText("files/title.txt");
            //Console.WriteLine(title);

            ConsoleKeyInfo userSelection = Console.ReadKey(true);
            string userMode;
            while (true)
            {
                if (userSelection.KeyChar == 'y')
                {
                    userMode = "new user";
                    break;
                }
                else if (userSelection.KeyChar == 'n')
                {
                    userMode = "existing user";
                    break;
                }
                else
                {
                    userSelection = Console.ReadKey(true);
                }
            }

            Member member = new Member("firstName", "lastName", "userName", "password");

            if (userMode == "new user")
            {
                member.setFirstName();
                member.setLastName();
                member.setUserName();
                member.setPassword();
            }
            else
            {
                member.setFirstName();
                member.setLastName();
                member.setUserName();
                member.setPassword();
            }

            Console.WriteLine(member.getFirstName());
            Console.WriteLine(member.getLastName());
            Console.WriteLine(member.getUserName());
            Console.WriteLine(member.getPassword());


            Community community = new Community();

            community.addMember(member.getFirstName(), member.getLastName(), member.getUserName(), member.getPassword());
            
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
