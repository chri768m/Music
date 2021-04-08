using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Music;

namespace music_web_aplication.Manager
{
    public class SongManager
    {
        private static int _nextId = 1;

        private static readonly List<Song> SongData = new List<Song>
        {
            new Song {Id = _nextId++, Title = "Øller1", Artist = "1212", Duration = 5, YOP = 1995},
            new Song {Id = _nextId++, Title = "Øller2", Artist = "1312", Duration = 6, YOP = 1996},
            new Song {Id = _nextId++, Title = "Øller3", Artist = "1412", Duration = 7, YOP = 1997}
        };



        public List<Song> getAll()
        {
            return SongData;
        }

        public Song GetById(int id)
        {
            return SongData.Find(song => song.Id == id);
        }
      
        public Song Add(Song newSong)
        {
            newSong.Id = _nextId++;
            SongData.Add(newSong);
            return newSong;
        }

        public Song Delete(int id)
        {
            var song = SongData.Find(song1 => song1.Id == id);
            if (song == null) return null;
            SongData.Remove(song);
            return song;
        }

        public Song Update(int id, Song updates)
        {
            var Song = SongData.Find(Song1 => Song1.Id == id);
            if (Song == null) return null;
            Song.Title = updates.Title;
            Song.Artist = updates.Artist;
            Song.Duration = updates.Duration;
            Song.YOP = updates.YOP;
            return Song;
        }




    }
}
