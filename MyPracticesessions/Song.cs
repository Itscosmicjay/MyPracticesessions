﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyPracticesessions
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;
        public Song(string aTitle,string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
    }
}
