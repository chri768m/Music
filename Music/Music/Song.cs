using System;

namespace Music
{
    public class Song
    {
        
        private string title_;
        private string artist_;
        private int duration_;
        private int YOP_;



        public int Id { get; set; }
        public String Title
        {
            get => title_;
            set { title_ = value; }
        }
        public String Artist
        {
            get => artist_;
            set { artist_ = value; }
        }
        public int Duration
        {
            get => duration_;
            set { duration_ = value; }
        }
        public int YOP
        {
            get => YOP_;
            set { YOP_ = value; }
        }


        public Song(int Id, string Title, string Artist, int Duration, int YOP)
        {
            this.Id = Id;
            title_ = Title;
            artist_ = Artist;
            duration_ = Duration;
            YOP_ = YOP;
        }

        public Song()
        {
            
        }

        

    }
}