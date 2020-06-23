using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExcelMusicPlayer.Helper;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelMusicPlayer
    {
    public partial class MusicPlayer
        {
        private BasicControls bControls;
        private PlaylistControls pControls;

        private List<SongDetails> Playlist;

        private Tuple<bool, string, double> playingDetails;

        private void MusicPlayer_Load (object sender, RibbonUIEventArgs e)
            {
            bControls = new BasicControls();
            pControls = new PlaylistControls();

            Playlist = new List<SongDetails>();

            playingDetails = new Tuple<bool, string, double>(false, "", 0.0);
            }

        private void btnMusicPlayer_Click (object sender, RibbonControlEventArgs e)
            {
            tabMusicPlayer.Visible = !tabMusicPlayer.Visible;
            }

        private void btnPlay_Click (object sender, RibbonControlEventArgs e)
            {
            if ( !btnPlay.Enabled )
                {
                return;
                }

            if ( Playlist.Count == 0 )
                {
                MessageBox.Show("Playlist is empty! Please add songs!", "Empty Playlist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

            string song;
            double position = 0.0;

            if ( playingDetails.Item1 )
                {
                song = playingDetails.Item2;
                position = playingDetails.Item3;
                }
            else
                {
                var rnd = new Random();

                if ( Playlist.Count == 1 )
                    song = Playlist[0].SongPath;
                else
                    {
                    while ( true )
                        {
                        song = Playlist[rnd.Next(0, Playlist.Count)].SongPath;

                        if ( !string.IsNullOrEmpty(playingDetails.Item2) )
                            {
                            if ( playingDetails.Item2.Equals(song) )
                                continue;
                            else
                                break;
                            }
                        else
                            break;
                        }
                    }
                }

            bControls.PlayMusic(song, position);

            playingDetails = new Tuple<bool, string, double>(false, "", 0.0);

            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            }

        private void btnPause_Click (object sender, RibbonControlEventArgs e)
            {
            if ( !btnPause.Enabled )
                {
                return;
                }

            var returnValue = bControls.PauseMusic();

            playingDetails = new Tuple<bool, string, double>(true, returnValue.Item1, returnValue.Item2);

            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            }

        private void btnStop_Click (object sender, RibbonControlEventArgs e)
            {
            if ( !btnStop.Enabled )
                {
                return;
                }

            playingDetails = new Tuple<bool, string, double>(false, bControls.StopMusic(), 0.0);

            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            }

        private void btnAddSongsToPlaylist_Click (object sender, RibbonControlEventArgs e)
            {
            Playlist.AddRange(pControls.AddSongsToPlaylist());
            }
        }
    }