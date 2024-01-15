using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Classes_StephanieLopez
{
    internal class Music
    {
        //Fields!
        private string _songname;
        private string _madeby;
        private string _genre;
        private string _language;
        private int _lengthofsonginminutes;

        //Properties!
        public string SongName { get => _songname; set => _songname = value; }
        public string MadeBy { get => _madeby; set => _madeby = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public string Language { get => _language; set => _language = value; }
        public int LengthOfSongInMinutes { get => _lengthofsonginminutes; set => _lengthofsonginminutes = value; }
    }
}
