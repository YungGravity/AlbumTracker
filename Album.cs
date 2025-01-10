using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album_Tracker
{
    public class Album
    {
        public string AlbumName { get; set; }
        public string BandName { get; set; }
        public int Rating { get; set; }

        public Album(string albumname, string bandname, int rating)
        {
            this.AlbumName = albumname;
            this.BandName = bandname;
            this.Rating = rating;
        }

        public static void AddAlbum(List<Album> discog)
        {
            Console.Clear();
            Console.WriteLine("----------Adding Album----------");
            Console.WriteLine("Album name :");
            string albumName = Console.ReadLine();
            Console.WriteLine("Band name :");
            string bandName = Console.ReadLine();
            Console.WriteLine("Rating out of 10 :");
            int rating = int.Parse(Console.ReadLine());

            discog.Add(new Album(albumName, bandName, rating));

            Console.Clear();
            Console.WriteLine("Album added(Press enter to continue)");
            Console.ReadLine();
        }

        public static void ShowAlbumList(List<Album> discog)
        {
            Console.Clear();
            foreach (var album in discog)
            {
                Console.WriteLine($"{album.AlbumName} by {album.BandName}. Score : {album.Rating}");
            }

            Console.WriteLine("\n\n\nPress enter to go back");
            Console.ReadLine();
        }
    }
}
