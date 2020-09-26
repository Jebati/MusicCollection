using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MusicCollection
{
    public static class Storage
    {
        public static async Task<bool> SetGroups(List<Group> groups)
        {
            try
            {
                using (var file = new FileStream("collection.json", FileMode.OpenOrCreate))
                {
                   await JsonSerializer.SerializeAsync(file, groups);
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public static List<Group> GetGroups(string path)
        {
            List<Group> groups = new List<Group>();
            try
            {
                using (var file = new FileStream(path, FileMode.OpenOrCreate))
                {
                    groups = JsonSerializer.DeserializeAsync<List<Group>>(file).Result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return groups;
        }
    }
}
