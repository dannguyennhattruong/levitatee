using L.Test.Core;
using L.Test.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace L.Test.ViewModels
{
    public enum MediaState
    {
        Stopped,
        Playing,
        Paused
    }
    public enum Loop
    {
        NoLoop,
        LoopAll,
        LoopOne
    }
    public enum Random
    {
        NoRamdom,
        Random
    }
    public partial class MainViewModel : PropertyChangedBase
    {
        private MusicContext musicContext = new MusicContext();
        private ObservableCollection<Playlist> playlists;
        public ObservableCollection<Playlist> Playlists
        {
            get { return playlists; }
            set { playlists = value; }
        }

        private Track currentTrack;
        private Track selectedTrack;
        private IList<Track> selectedTracks;
        private Playlist currentPlaylist;
        private Playlist selectedPlaylist;
        private MediaElement engine;
        private MediaState state;
        private Loop loopMode;
        private Random randomMode;




        public Track CurrentTrack
        {
            get { return currentTrack; }
            set
            {
                if (value != currentTrack)
                {
                    SetProperty(value, ref currentTrack);
                    OnPropertyChanged("CurrentTrack");
                }
            }
        }
        public Track SelectedTrack
        {
            get { return selectedTrack; }
            set
            {
                if (value != selectedTrack)
                {
                    SetProperty(value, ref selectedTrack);
                    OnPropertyChanged("SelectedTrack");
                }
            }
        }
        public IList<Track> SelectedTracks
        {
            get { return selectedTracks; }
            set
            {
                if (value != selectedTracks)
                {
                    SetProperty(value, ref selectedTracks);
                    OnPropertyChanged("SelectedTracks");
                }
            }
        }
        public Playlist CurrentPlaylist
        {
            get { return currentPlaylist; }
            set
            {
                if (value != currentPlaylist)
                {
                    SetProperty(value, ref currentPlaylist);
                    OnPropertyChanged("CurrentPlaylist");
                }
            }
        }
        public Playlist SelectedPlaylist
        {
            get { return selectedPlaylist; }
            set
            {
                if (value != selectedPlaylist)
                {
                    SetProperty(value, ref selectedPlaylist);
                    OnPropertyChanged("SelectedPlaylist");
                }
            }
        }


        public MediaElement Engine
        {
            get { return engine; }
            set
            {
                if (value != engine)
                {
                    SetProperty(value, ref engine);
                    OnPropertyChanged("Engine");
                }
            }
        }
        public MediaState State
        {
            get { return state; }
            set
            {
                if (value != state)
                {
                    SetProperty(value, ref state);
                    OnPropertyChanged("State");
                }
            }
        }
        public Loop LoopMode
        {
            get { return loopMode; }
            set
            {
                if (value != loopMode)
                {
                    SetProperty(value, ref loopMode);
                    OnPropertyChanged("LoopMode");
                }
            }
        }
        public Random RandomMode
        {
            get { return randomMode; }
            set
            {
                if (value != randomMode)
                {
                    SetProperty(value, ref randomMode);
                    OnPropertyChanged("RandomMode");
                }
            }
        }


        private ICollectionView _playlistViewSource;
        public ICollectionView PlaylistViewSource
        {
            get { return _playlistViewSource; }
            set
            {
                if (value != _playlistViewSource)
                {
                    SetProperty(value, ref _playlistViewSource);
                    OnPropertyChanged("PlaylistViewSource");
                }
            }
        }

        private ICollectionView _tracklistViewSource;
        public ICollectionView TracklistViewSource
        {
            get { return _tracklistViewSource; }
            set
            {
                if (value != _tracklistViewSource)
                {
                    SetProperty(value, ref _tracklistViewSource);
                    OnPropertyChanged("TracklistViewSource");
                }
            }
        }




        // Ctor
        public MainViewModel()
        {
            LoadPlaylist();

            CurrentPlaylist = Playlists.FirstOrDefault();
            CurrentTrack = CurrentPlaylist.TrackList.FirstOrDefault();
        }


        #region Methods
        /// <summary>
        /// Load all playlists
        /// </summary>
        private void LoadPlaylist()
        {
            Playlists = new ObservableCollection<Playlist>();

            var allItems = new Playlist
            {
                Id = "APP01",
                Name = "All items",
                IsAppPlaylist = true,
                TrackList = new ObservableCollection<Track>(musicContext.Tracks.ToList())
            };
            var lovedItems = new Playlist
            {
                Id = "APP02",
                Name = "Loved items",
                IsAppPlaylist = true,
                TrackList = new ObservableCollection<Track>(musicContext.Tracks.Where(x => x.IsLove == true).ToList())
            };

            var others = PlaylistsHelper.ReadPlaylists();

            Playlists.Add(allItems);
            Playlists.Add(lovedItems);

            foreach (var pl in others)
            {
                Playlists.Add(Playlist.LoadPlaylist(pl));
            }
        }

        private void Initial()
        {
            if (CurrentTrack != null && CurrentTrack.IsExist)
                Engine.Source = new Uri(CurrentTrack.Url);
        }
        private void PlayPause()
        {
            if (CurrentTrack != null && CurrentTrack.IsExist)
            {
                if (State == MediaState.Stopped || State == MediaState.Paused)
                {
                    State = MediaState.Playing;
                    Engine.Play();
                }
                else
                {
                    State = MediaState.Paused;
                    Engine.Pause();
                }
            }
            else
            {
                CurrentTrack = Playlist.NextTrack(CurrentPlaylist, CurrentTrack);
                PlayPause();
            }
        }
        private void Stop()
        {
            State = MediaState.Stopped;
            Engine.Stop();
        }


        public void PlaySelectedTrack()
        {
            Stop();

            if (SelectedTrack != null && SelectedTrack.IsExist)
            {
                // Change current playlist and track
                CurrentPlaylist = SelectedPlaylist;
                CurrentTrack = SelectedTrack;

                PlayPause();
            }
        }
        public void PlayNextTrack()
        {
            // Case loop playing one track
            if (LoopMode == Loop.LoopOne)
            {
                Engine.Stop();
                PlayPause();
            }

            // Case loop all tracks in current playlist
            if (LoopMode == Loop.LoopAll)
            {
                // Case current track is the last track of current playlist -> back to the first track
                if (CurrentPlaylist.TrackList.IndexOf(currentTrack) == CurrentPlaylist.TrackList.Count - 1)
                {
                    CurrentTrack = CurrentPlaylist.TrackList.FirstOrDefault();
                    PlayPause();
                }
                else // Case current track is not the last track
                {
                    CurrentTrack = Playlist.NextTrack(CurrentPlaylist, CurrentTrack);
                    PlayPause();
                }
            }

            // Last case: no loop, stop if current track is the last track
            if (CurrentPlaylist.TrackList.IndexOf(currentTrack) == CurrentPlaylist.TrackList.Count - 1)
            {
                Stop();
            }
            else // Case current track is not the last track
            {
                CurrentTrack = Playlist.NextTrack(CurrentPlaylist, CurrentTrack);
                PlayPause();
            }
        }
        public void PlayPreviousTrack()
        {
            // Case loop playing one track
            if (LoopMode == Loop.LoopOne)
            {
                Engine.Stop();
                PlayPause();
            }

            // Case loop all tracks in current playlist
            if (LoopMode == Loop.LoopAll)
            {
                // Case current track is the last track of current playlist -> back to the first track
                if (CurrentPlaylist.TrackList.IndexOf(currentTrack) == 0)
                {
                    CurrentTrack = CurrentPlaylist.TrackList.LastOrDefault();
                    PlayPause();
                }
                else // Case current track is not the last track
                {
                    CurrentTrack = Playlist.PreviousTrack(CurrentPlaylist, CurrentTrack);
                    PlayPause();
                }
            }

            // Last case: no loop, stop and replay current track
            if (CurrentPlaylist.TrackList.IndexOf(currentTrack) == 0)
            {
                Stop();
                PlayPause();
            }
            else // Case current track is not the last track
            {
                CurrentTrack = Playlist.PreviousTrack(CurrentPlaylist, CurrentTrack);
                PlayPause();
            }
        }
        #endregion
    }
}
