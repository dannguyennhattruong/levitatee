using System.Collections.ObjectModel;

namespace Levitate.Model
{
    public interface IPlaylist
    {
        ObservableCollection<Track> ListTrack { get; set; }

        string Name { get; set; }
        bool CanEdit { get; set; }

        void AddTrack(Track track);
        void RemoveTrack(Track track);
        void Clear();
    }
}
