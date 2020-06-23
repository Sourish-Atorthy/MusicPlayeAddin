namespace ExcelMusicPlayer.Helper
    {
    public class SongDetails
        {
        public string SongName
            {
            get; set;
            }
        public string SongPath
            {
            get; set;
            }

        public SongDetails ()
            {
            }

        public SongDetails (string songName, string songPath)
            {
            SongName = songName;
            SongPath = songPath;
            }
        }
    }
