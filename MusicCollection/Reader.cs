using System;
using System.Collections.Generic;
using System.Text;

namespace MusicCollection
{
    public static class Reader
    {
        public static List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();

            for (int count = 1; ; count++)
            {
                Group group = new Group();
                Console.WriteLine($"[Группа #{count}]");
                Console.WriteLine(" Введите 0 для выхода.");
                Console.Write(" Введите название группы: ");
                string input = Console.ReadLine();

                if (input == "0") break;

                group.name = input;
                group.albums = Reader.GetAlbums();

                groups.Add(group);
            }

            return groups;
        }
        public static List<Album> GetAlbums()
        {
            List<Album> albums = new List<Album>();
            for (int count = 1; ; count++)
            {
                Album album = new Album();
                Console.WriteLine($"\t[Альбом #{count}]");
                Console.WriteLine("\t Введите 0 для выхода.");
                Console.Write("\t Введите название альбома: ");
                string input = Console.ReadLine();

                if (input == "0") break;

                album.name = input;

                album.songs = Reader.GetSongs();

                albums.Add(album);
            }
            
            return albums;
        }

        public static List<Song> GetSongs()
        {
            List<Song> songs = new List<Song>();

            for (int count = 1; ; count++)
            {
                Song song = new Song();
                Console.WriteLine($"\t\t[Песня #{count}]");
                Console.WriteLine("\t\t Введите 0 для выхода.");
                Console.Write("\t\t Введите название песни: ");
                string input = Console.ReadLine();

                if (input == "0") break;

                song.name = input;

                songs.Add(song);
            }

            return songs;
        }
    }
}
