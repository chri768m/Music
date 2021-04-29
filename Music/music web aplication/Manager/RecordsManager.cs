using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Music;

namespace music_web_aplication.Manager
{
    public interface RecordsManager
    {
        List<Record> GetAllRecords();
        List<Song> GetSongs(int recordId, string user = null);
        Record AddRecords(Record record);
        Song AddSong(int recordId, Song song);
        Record DeleteRecords(int recordId);
        Song DeleteSong(int recordId, int songtId);
    }
}
