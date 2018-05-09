using L.Test.Model;
using L.Test.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Test.ViewModels
{
    public partial class MainViewModel
    {
        private RelayCommand _play;
        public RelayCommand Play => _play ?? (_play = new RelayCommand(parameter =>
        {
            PlayPause();
        }));

        private RelayCommand _stop;
        public RelayCommand StopPlaying => _stop ?? (_stop = new RelayCommand(parameter =>
        {
            Stop();
        }));

        private RelayCommand _playNext;
        public RelayCommand PlayNext => _playNext ?? (_playNext = new RelayCommand(parameter =>
        {
            PlayNextTrack();
        }));

        private RelayCommand _playPrevious;
        public RelayCommand PlayPrevious => _playPrevious ?? (_playPrevious = new RelayCommand(parameter =>
        {
            PlayPreviousTrack();
        }));

        private RelayCommand _playSelectedTrack;

        public RelayCommand Play_SelectedTrack => _playSelectedTrack ?? (_playSelectedTrack = new RelayCommand(parameter =>
        {
            PlaySelectedTrack();
        }));



        #region CRUD

        #endregion
        // Thêm playlist
        // Drag-drop
        // Mai làm tiếp, đi ngủ =))) g9

        private RelayCommand _deletePlaylist;
        public RelayCommand DeletePlaylist => _deletePlaylist ?? (_deletePlaylist = new RelayCommand(parameter =>
        {
            var toBeRemovedPlaylist = (Playlist)parameter;

            // If to-be-deleted-playlist is app-playlist => no delete
            if (toBeRemovedPlaylist.IsAppPlaylist) return;

            // If to-be-deleted-playlist is current playlist (playing) =>
            // stop engine, redirect current playlist to app-playlist, delete playlist
            if (toBeRemovedPlaylist.Id == CurrentPlaylist.Id)
            {
                // Stop engine
                Stop();

                // Redirect current
                CurrentPlaylist = Playlists[0];
                CurrentTrack = CurrentPlaylist.TrackList.FirstOrDefault();

                // Remove playlist from list of playlists
                Playlists.Remove(toBeRemovedPlaylist);
            }
        }));

        private RelayCommand _deleteTracks;
        public RelayCommand DeleteTracks => _deleteTracks ?? (_deleteTracks = new RelayCommand(async parameter =>
        {
            // note that all to-be-deleted-tracks are inside the selected playlist

            var toBeRemovedTracks = SelectedTracks;

            // If there is no track to be remove => no thing happpend
            if (toBeRemovedTracks.Any()) return;

            if (SelectedPlaylist == CurrentPlaylist)
            {
                // Case 1: If Current Track (playing-track) is in to-be-deleted-tracks =>
                // 1.1 stop engine
                if (toBeRemovedTracks.Contains(CurrentTrack))
                {
                    Stop();
                }

                // 1.2 remove tracks in playlists not include current playlist

                // Case 1.2.1: Selected playlist is an app-playlist (All items) =>
                // Delete from seleted playlist and from the rest of non-app-playlists that contain to-be-deleted-tracks
                // Parallel proccessing
                if (SelectedPlaylist.IsAppPlaylist && SelectedPlaylist.Id == "APP01")
                {
                    Parallel.For(0, toBeRemovedTracks.Count, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, (int i) =>
                    {
                        foreach (var pl in Playlists)
                        {
                            pl.Remove(toBeRemovedTracks[i]);
                        }
                    });
                }

                // Case 1.2.2: Selected playlist is not app-playlist
                if (!selectedPlaylist.IsAppPlaylist)
                    RemoveTrackInPlaylist(toBeRemovedTracks, SelectedPlaylist);

                // 1.2.3 remove tracks in current playlist
                RemoveTrackInPlaylist(toBeRemovedTracks, CurrentPlaylist);

                // 1.3 redirect current track to the first item in current playlist
                CurrentTrack = CurrentPlaylist.TrackList.FirstOrDefault();
            }
            else
            {
                // Case 1: Selected playlist is an app-playlist (All items) =>
                // Delete from seleted playlist and from the rest of non-app-playlists that contain to-be-deleted-tracks
                // Parallel proccessing
                if (SelectedPlaylist.IsAppPlaylist && SelectedPlaylist.Id == "APP01")
                {
                    Parallel.For(0, toBeRemovedTracks.Count, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, (int i) =>
                    {
                        foreach (var pl in Playlists)
                        {
                            pl.Remove(toBeRemovedTracks[i]);
                        }
                    });
                }

                // Case 2: Selected playlist is not app-playlist
                if (!selectedPlaylist.IsAppPlaylist)
                    RemoveTrackInPlaylist(toBeRemovedTracks, SelectedPlaylist);
            }

            SelectedTracks.Clear();
        }));


        private void RemoveTrackInPlaylist(IList<Track> tracks, Playlist playlist)
        {
            // Only perform remove-action if track exists in playlist
            foreach (var t in tracks)
            {
                if (playlist.IsExist(t))
                    playlist.Remove(t);
            }
        }
    }
}
