using L.Test.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace L.Test.Core
{
    [Serializable, XmlType(TypeName ="Playlists")]
    public class PlaylistsHelper
    {
        protected const string Filename = "Levitate_Playlists.xml";

        [XmlElement("Playlists")]
        public ObservableCollection<Playlist> Playlists { get; set; }

        public PlaylistsHelper()
        {
            Playlists = new ObservableCollection<Playlist>();
        }

        /// <summary>
        /// Save all playlists to xml type file
        /// </summary>
        /// <param name="_playlists"></param>
        /// <param name="rootPath"></param>
        public bool SavePlaylist()
        {
            try
            {
                var playlistsFile = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Filename));

                // If existed an old playlistsFile before => delete
                if (playlistsFile.Exists)
                    playlistsFile.Delete();

                // Create a new one
                using (var tempFile = new FileStream(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Filename), FileMode.Create, FileAccess.Write))
                {
                    // Write all playlists content to temporary file as xml type file
                    var serializer = new XmlSerializer(typeof(List<Playlist>));
                    serializer.Serialize(tempFile, Playlists.Where(x => !x.IsAppPlaylist).ToList());
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public static bool SavePlaylist(ObservableCollection<Playlist> playlists)
        {
            try
            {
                var playlistsFile = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Filename));

                // If existed an old playlistsFile before => delete
                if (playlistsFile.Exists)
                    playlistsFile.Delete();

                // Create a new one
                using (var tempFile = new FileStream(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Filename), FileMode.Create, FileAccess.Write))
                {
                    // Write all playlists content to temporary file as xml type file
                    var serializer = new XmlSerializer(typeof(List<Playlist>));
                    serializer.Serialize(tempFile, playlists.Where(x => !x.IsAppPlaylist).ToList());
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }

        }

        /// <summary>
        /// Load playlists
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public static ObservableCollection<Playlist> ReadPlaylists()
        {
            ObservableCollection<Playlist> playlists = new ObservableCollection<Playlist>();

            // create a file info
            var file = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Filename));

            // check that file info is exist or not, has content or empty
            if (!file.Exists || string.IsNullOrWhiteSpace(File.ReadAllText(file.FullName)))
            {
                return playlists;
            }
            // read that file info, deserialize it and return as PlaylistSettings
            using (FileStream fs = new FileStream(file.FullName, FileMode.Open))
            {
                var deserializer = new XmlSerializer(typeof(ObservableCollection<Playlist>));
                playlists = (ObservableCollection<Playlist>)deserializer.Deserialize(fs);
            }

            for (int i = 0; i < playlists.Count; i++)
            {
                playlists[i] = Playlist.LoadPlaylist(playlists[i]);
            }

            return playlists;
        }

        public static void DeletePlaylistsFile()
        {
            var playlistsFile = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Filename));

            // If existed an old playlistsFile before => delete
            if (playlistsFile.Exists)
                playlistsFile.Delete();
        }
    }
}
