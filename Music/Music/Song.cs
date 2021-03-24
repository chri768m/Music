using System;

namespace Music
{
    public class Song
    {
        private string title_;
        private string artist_;
        private int duration_;
        private int yearofpublication_;




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
        public int YearOfPublication
        {
            get => yearofpublication_;
            set { yearofpublication_ = value; }
        }


        public Song()
        {

        }

    }
}