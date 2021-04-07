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
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException();
                }
                title_ = value; 
            }
        }
        public String Artist
        {
            get => artist_;
            set
            {
                if (value.Length < 4) { throw new ArgumentException(); }
                artist_ = value; }
        }
        public int Duration
        {
            get => duration_;
            set
            { 
                if (value > 20) { throw new ArgumentOutOfRangeException(); }
                duration_ = value; }
        }
        public int YOP
        {
            get => YOP_;
            set
            {
                if (value < 1900 || value > 2021) { throw new ArgumentOutOfRangeException(); }
                YOP_ = value; }
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