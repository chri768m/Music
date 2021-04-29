using Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static music_web_aplication.Manager.SongManager;

namespace music_web_aplication.Manager
{
    public class RecordsManagerStaticList : RecordsManager
    {
        private static int _nextId = 1;
        static List<Record> RecordsData = new List<Record>
        {
            new Record {Id = 0, Album = "Fisk", TotalSongs = 1 }
        };

        public Record AddRecords(Record record)
        {
            throw new NotImplementedException();
        }

        public Song AddSong(int recordId, Song Addsong)
        {
            Addsong.Id = _nextId++;
            SongData.Add(Addsong);
            return Addsong;
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
            return RecordsData;
        }

        public List<Song> GetSongs(int recordId, string user = null)
        {
            throw new NotImplementedException();
        }
    }
}
