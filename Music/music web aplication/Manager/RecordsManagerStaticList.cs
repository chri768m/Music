using Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace music_web_aplication.Manager
{
    public class RecordsManagerStaticList : RecordsManager
    {
        static List<Record> RecordsData = new List<Record>
        {
            new Song {Id = 0, Album = Fisk, TotalSongs = 1 }
        };

        public Record AddRecords(Record record)
        {
            throw new NotImplementedException();
        }

        public Song AddSong(int recordId, Song song)
        {
            throw new NotImplementedException();
        }

        public Record DeleteRecords(int recordId)
        {
            throw new NotImplementedException();
        }

        public Song DeleteSong(int recordId, int songtId)
        {
            throw new NotImplementedException();
        }

        public List<Record> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongs(int recordId, string user = null)
        {
            throw new NotImplementedException();
        }
    }
}
