using System;
using System.Collections.Generic;
using System.Text;

namespace MusicCollection
{
    public class Album
    {
        public string name { get; set; }

        public Group group { get; set; }
        public List<Song> songs { get; set; }
    }
}
