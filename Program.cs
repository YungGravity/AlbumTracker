using Album_Tracker;
using System.Runtime.CompilerServices;

int choice = 0;
List<Album> discog = new List<Album>();

while (choice != 3)
{
    Console.WriteLine("What do you wanna do?\nPress 1 to add an album\nPress 2 to see the full list of listend to albums\nPress 3 to exit");
    choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Album.AddAlbum(discog);
    }
    else if (choice == 2)
    {
       Album.ShowAlbumList(discog);
    } 

    Console.Clear() ;
}
