using System.Collections.Generic;
using System.Windows.Forms;

namespace ExcelMusicPlayer.Helper
    {
    public class PlaylistControls
        {
        public List<SongDetails> AddSongsToPlaylist ()
            {
            List<SongDetails> playlist = new List<SongDetails>();

            OpenFileDialog dialog = new OpenFileDialog
                {
                Multiselect = true,
                Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma"
                };

            if ( dialog.ShowDialog() == DialogResult.OK )
                {
                for ( int i = 0; i < dialog.SafeFileNames.Length; i++ )
                    {
                    playlist.Add(new SongDetails(songName: dialog.SafeFileNames[i], songPath: dialog.FileNames[i]));
                    }
                }

            return playlist;
            }
        }
    }
