using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var mountVernon = from artist in Artists
                              where artist.Hometown == "Mount Vernon"
                              select new { artist.ArtistName, artist.RealName, artist.Age };
            foreach (var person in mountVernon)
            {
                Console.WriteLine($"{person.RealName} --AKA-- {person.ArtistName}");
            };

            //Who is the youngest artist in our collection of artists?
            var youngest = Artists.OrderBy(person => person.Age).Take(1);
            foreach (var person in youngest)
            {
                Console.WriteLine($"{person.RealName} --AKA-- {person.ArtistName}");
            };

            //Display all artists with 'William' somewhere in their real name
            var willies = Artists.Where(artist => artist.RealName.Contains("William"));
            Console.WriteLine("***************These are the Willies I know: ");
            foreach (var willie in willies)
            {
                Console.WriteLine($"{willie.RealName}");
            }
            Console.WriteLine("**************END OF WILLIES");

            //Display the 3 oldest artist from Atlanta
            var atlOldies = Artists.Where(artist => artist.Hometown == "Atlanta").OrderByDescending(oldie => oldie.Age).Take(3);
            Console.WriteLine("***** These are the oldest rappists in Atlanta:");
            foreach (var oldguy in atlOldies) {
                Console.WriteLine($"{oldguy.ArtistName}, Age: {oldguy.Age}");
            }
            Console.WriteLine("**************END OF OLDIES");

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'

            List<string> wutang = Groups.Where(group => group.GroupName == "Wu-Tang Clan").Join(Artists, group => group.Id, 
                artist => artist.GroupId,
                (group, artist) => {
                    return artist.ArtistName;
                }).ToList();

                Console.WriteLine("**************Wu-Tang Clan Ain't Nothin' to Fuck With");

                foreach (var man in wutang) {
                    Console.WriteLine(man);
                }
        }  
    }
}
