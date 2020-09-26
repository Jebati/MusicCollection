using System;
using System.Collections.Generic;
using System.Text;

namespace MusicCollection
{
    class Writter
    {
        public static void PrintGroups(List<Group> groups)
        {
            int count = 1;
            foreach(Group group in groups)
            {
                Console.WriteLine($"[Группа #{count}]");
                Console.WriteLine($" Название группы: {group.name}");

                PrintAlbums(group.albums);

                count++;
            }
        }
        public static void PrintAlbums(List<Album> albums)
        {
            int count = 1;
            foreach (Album album in albums)
            {
                Console.WriteLine($"\t[Альбом #{count}]");
                Console.WriteLine($"\t Название альбома: {album.name}");

                PrintSongs(album.songs);

                count++;
            }
        }

        public static void PrintSongs(List<Song> songs)
        {
            int count = 1;
            foreach (Song song in songs)
            {
                Console.WriteLine($"\t\t[Песня #{count}]");
                Console.WriteLine($"\t\t Название песни: {song.name}");

                count++;
            }
        }
    }
}
