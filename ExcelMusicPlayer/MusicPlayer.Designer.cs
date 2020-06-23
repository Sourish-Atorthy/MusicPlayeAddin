namespace ExcelMusicPlayer
    {
    partial class MusicPlayer : Microsoft.Office.Tools.Ribbon.RibbonBase
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MusicPlayer ()
            : base(Globals.Factory.GetRibbonFactory())
            {
            InitializeComponent();
            }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
            {
            if ( disposing && (components != null) )
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.tabMusicPlayer = this.Factory.CreateRibbonTab();
            this.grpBasicControls = this.Factory.CreateRibbonGroup();
            this.grpPlaylistControls = this.Factory.CreateRibbonGroup();
            this.btnPlay = this.Factory.CreateRibbonButton();
            this.btnPause = this.Factory.CreateRibbonButton();
            this.btnStop = this.Factory.CreateRibbonButton();
            this.btnAddSongsToPlaylist = this.Factory.CreateRibbonButton();
            this.btnMusicPlayer = this.Factory.CreateRibbonButton();
            this.tabMusicPlayer.SuspendLayout();
            this.grpBasicControls.SuspendLayout();
            this.grpPlaylistControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMusicPlayer
            // 
            this.tabMusicPlayer.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabMusicPlayer.Groups.Add(this.grpBasicControls);
            this.tabMusicPlayer.Groups.Add(this.grpPlaylistControls);
            this.tabMusicPlayer.Label = "Music Player";
            this.tabMusicPlayer.Name = "tabMusicPlayer";
            // 
            // grpBasicControls
            // 
            this.grpBasicControls.Items.Add(this.btnPlay);
            this.grpBasicControls.Items.Add(this.btnPause);
            this.grpBasicControls.Items.Add(this.btnStop);
            this.grpBasicControls.Label = "Basic Controls";
            this.grpBasicControls.Name = "grpBasicControls";
            // 
            // grpPlaylistControls
            // 
            this.grpPlaylistControls.Items.Add(this.btnAddSongsToPlaylist);
            this.grpPlaylistControls.Label = "Playlist Contols";
            this.grpPlaylistControls.Name = "grpPlaylistControls";
            // 
            // btnPlay
            // 
            this.btnPlay.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Label = "Play";
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShowImage = true;
            this.btnPlay.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnPause.Enabled = false;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Label = "Pause";
            this.btnPause.Name = "btnPause";
            this.btnPause.ShowImage = true;
            this.btnPause.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Label = "Stop";
            this.btnStop.Name = "btnStop";
            this.btnStop.ShowImage = true;
            this.btnStop.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnStop_Click);
            // 
            // btnAddSongsToPlaylist
            // 
            this.btnAddSongsToPlaylist.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAddSongsToPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSongsToPlaylist.Image")));
            this.btnAddSongsToPlaylist.Label = "Add Songs To Playlist";
            this.btnAddSongsToPlaylist.Name = "btnAddSongsToPlaylist";
            this.btnAddSongsToPlaylist.ShowImage = true;
            this.btnAddSongsToPlaylist.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddSongsToPlaylist_Click);
            // 
            // btnMusicPlayer
            // 
            this.btnMusicPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnMusicPlayer.Image")));
            this.btnMusicPlayer.Label = "Music Player";
            this.btnMusicPlayer.Name = "btnMusicPlayer";
            this.btnMusicPlayer.ShowImage = true;
            this.btnMusicPlayer.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMusicPlayer_Click);
            // 
            // MusicPlayer
            // 
            this.Name = "MusicPlayer";
            // 
            // MusicPlayer.OfficeMenu
            // 
            this.OfficeMenu.Items.Add(this.btnMusicPlayer);
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabMusicPlayer);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MusicPlayer_Load);
            this.tabMusicPlayer.ResumeLayout(false);
            this.tabMusicPlayer.PerformLayout();
            this.grpBasicControls.ResumeLayout(false);
            this.grpBasicControls.PerformLayout();
            this.grpPlaylistControls.ResumeLayout(false);
            this.grpPlaylistControls.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabMusicPlayer;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpBasicControls;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPlay;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPause;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnStop;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpPlaylistControls;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddSongsToPlaylist;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMusicPlayer;
        }

    partial class ThisRibbonCollection
        {
        internal MusicPlayer MusicPlayer
            {
            get
                {
                return this.GetRibbon<MusicPlayer>();
                }
            }
        }
    }
