using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using L.Test.Core;

namespace L.Test.Model
{
    [Serializable, XmlType(TypeName = "Playlist")] //đánh dấu đưa đối tượng về dạng xml
    public class Playlist : PropertyChangedBase
    {
        private string name;
        private ObservableCollection<Track> trackList;
        private ObservableCollection<Track> randomList;
        private bool isAppPlaylist;

        [XmlElement("Id")]
        public string Id { get; set; }
        [XmlElement("Name")]
        public string Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    SetProperty(value, ref name);
                    OnPropertyChanged("Name");
                }
            }
        }
        [XmlElement("TrackList")]
        public ObservableCollection<Track> TrackList
        {
            get { return trackList; }
            set
            {
                if (value != trackList)
                {
                    SetProperty(value, ref trackList);
                    OnPropertyChanged("TrackList");
                }
            }
        }
        [XmlIgnore] //bỏ qua
        public ObservableCollection<Track> RandomList => TrackList.Shuffle();
        [XmlElement("IsAppPlaylist")]
        public bool IsAppPlaylist
        {
            get { return isAppPlaylist; }
            set
            {
                if (value != isAppPlaylist)
                {
                    SetProperty(value, ref isAppPlaylist);
                    OnPropertyChanged("IsAppPlaylist");
                }
            }
        }


        public Playlist()
        {
            Id = Guid.NewGuid().ToString("D");
            Name = "New playlist";
            TrackList = new ObservableCollection<Track>();
            IsAppPlaylist = false;
        }

        public void Add(Track track)
        {
            TrackList.Add(track);
        }
        public void Remove(Track track)
        {
            TrackList.Remove(track);
        }
        public bool IsExist(Track track)
        {
            return TrackList.Any(track);
        }

        /// <summary>
        /// Return the track follows current track in playlist
        /// </summary>
        /// <param name="playlist"></param>
        /// <param name="currentTrack"></param>
        /// <returns></returns>
        public static Track NextTrack(Playlist playlist, Track currentTrack) //
        {
            if (playlist.TrackList.Count == 0) return null;

            var currentIndex = playlist.TrackList.IndexOf(currentTrack);

            if (currentIndex < playlist.TrackList.Count - 1)
            {
                return playlist.TrackList[currentIndex + 1];
            }
            else
            {
                return playlist.TrackList.First();
            }
        }
        public static Track NextTrack(ObservableCollection<Track> playlist, Track currentTrack) //
        {
            if (playlist.Count == 0) return null;

            var currentIndex = playlist.IndexOf(currentTrack);

            if (currentIndex < playlist.Count - 1)
            {
                return playlist[currentIndex + 1];
            }
            else
            {
                return playlist.First();
            }
        }
        /// <summary>
        /// Return the track stands before current track in playlist
        /// </summary>
        /// <param name="playlist"></param>
        /// <param name="currentTrack"></param>
        /// <returns></returns>
        public static Track PreviousTrack(Playlist playlist, Track currentTrack)
        {
            if (playlist.TrackList.Count == 0) return null;

            var currentIndex = playlist.TrackList.IndexOf(currentTrack);

            if (currentIndex > 0)
            {
                return playlist.TrackList[currentIndex - 1];
            }
            else
            {
                return playlist.TrackList.Last();
            }
        }
        public static Track PreviousTrack(ObservableCollection<Track> playlist, Track currentTrack)
        {
            if (playlist.Count == 0) return null;

            var currentIndex = playlist.IndexOf(currentTrack);

            if (currentIndex > 0)
            {
                return playlist[currentIndex - 1];
            }
            else
            {
                return playlist.Last();
            }
        }
        public static Playlist LoadPlaylist(Playlist p)
        {
            var dbcontext = new MusicContext();
            var playlist = new Playlist()
            {
                Name = p.Name,
                TrackList = new ObservableCollection<Track>(),
                IsAppPlaylist = false
            };
            foreach (var item in p.TrackList)
            {
                try
                {
                    playlist.TrackList.Add(dbcontext.Tracks.Where(t => t.Id == item.Id).FirstOrDefault());
                }
                catch (Exception)
                {
                    //
                }
            }
            return playlist;
        }
    }
}
