using System;
using WMPLib;

namespace ExcelMusicPlayer.Helper
    {
    public class BasicControls
        {
        private readonly MediaPlayer.MediaPlayer mediaPlayer;

        private string currentSong;

        public BasicControls ()
            {
            this.mediaPlayer = mediaPlayer = new MediaPlayer.MediaPlayer();
            currentSong = "";
            }

        public void PlayMusic (string path, double position)
            {
            mediaPlayer.Open(path);

            if ( position != 0.0 )
                mediaPlayer.CurrentPosition = position;

            mediaPlayer.Play();

            currentSong = path;
            }

        public Tuple<string, double> PauseMusic ()
            {
            mediaPlayer.Pause();
            return new Tuple<string, double>(currentSong, mediaPlayer.CurrentPosition);
            }

        public string StopMusic ()
            {
            mediaPlayer.Stop();

            return currentSong;
            }
        }
    }
