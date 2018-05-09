using System;
using System.Collections.ObjectModel;
using L.Test.Core;
using L.Test.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L.UnitTest
{
    [TestClass]
    public class TestPlaylistHelper
    {
        [TestMethod]
        public void TestWritingPlaylist()
        {
            var playlists = new ObservableCollection<Playlist>()
            {
                new Playlist()
                {
                    Name = "p01",
                    IsAppPlaylist = false,
                    TrackList = new ObservableCollection<Track>()
                    {
                        new Track()
                        {
                            Id = 1,
                            Tua = "Levitate",
                            AlbumId = 1,
                            CaSiId = 1,
                            TheLoaiId = 1,
                            IsLove = true,
                            MediaKind = MediaKind.Song,
                            NgayThemVao = DateTime.Today,
                            Url = @"C:\Windows\System32\123.mp3"
                        },
                        new Track()
                        {
                            Id = 2,
                            Tua = "Glory",
                            AlbumId = 1,
                            CaSiId = 1,
                            TheLoaiId = 1,
                            IsLove = true,
                            MediaKind = MediaKind.Song,
                            NgayThemVao = DateTime.Today,
                            Url = @"C:\Windows\System32\1234.mp3"
                        },
                        new Track()
                        {
                            Id = 3,
                            Tua = "Qing hua ci",
                            AlbumId = 1,
                            CaSiId = 1,
                            TheLoaiId = 1,
                            IsLove = true,
                            MediaKind = MediaKind.Song,
                            NgayThemVao = DateTime.Today,
                            Url = @"C:\Windows\System32\1235.mp3"
                        },
                    }
                },
                new Playlist()
                {
                    Name = "p02",
                    IsAppPlaylist = false,
                    TrackList = new ObservableCollection<Track>()
                    {
                        new Track()
                        {
                            Id = 4,
                            Tua = "Ke ai nu ren",
                            AlbumId = 1,
                            CaSiId = 1,
                            TheLoaiId = 1,
                            IsLove = true,
                            MediaKind = MediaKind.Song,
                            NgayThemVao = DateTime.Today,
                            Url = @"C:\Windows\System32\1231.mp3"
                        },
                        new Track()
                        {
                            Id = 5,
                            Tua = "Way beyond",
                            AlbumId = 1,
                            CaSiId = 1,
                            TheLoaiId = 1,
                            IsLove = true,
                            MediaKind = MediaKind.Song,
                            NgayThemVao = DateTime.Today,
                            Url = @"C:\Windows\System32\12342.mp3"
                        },
                        new Track()
                        {
                            Id = 6,
                            Tua = "I do",
                            AlbumId = 1,
                            CaSiId = 1,
                            TheLoaiId = 1,
                            IsLove = true,
                            MediaKind = MediaKind.Song,
                            NgayThemVao = DateTime.Today,
                            Url = @"C:\Windows\System32\12353.mp3"
                        },
                    }
                }
            };

            var result = PlaylistsHelper.SavePlaylist(playlists);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestReadingPlaylist()
        {
            var playlist = PlaylistsHelper.ReadPlaylists();
            Assert.IsNotNull(playlist[0].TrackList[0].Id);
        }

        [TestMethod]
        public void TestReadingFullPlaylist()
        {
            var playlist = PlaylistsHelper.ReadPlaylists();
            Assert.IsNotNull(playlist[0].TrackList[0].CaSi);
        }
    }
}
