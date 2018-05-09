using L.Test.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L.Test.Core
{
    public static class Helper
    {
        private static MusicContext dbcontext = new MusicContext();
        private const string UNKNOW = "Unknow";
        public static Track ReadTrack(string _location)
        {
            if (string.IsNullOrWhiteSpace(_location) || !System.IO.File.Exists(_location))
                return null;

            try
            {
                Track _track = new Track();
                Album _album = new Album();
                CaSi _casi = new CaSi();
                TheLoai _theloai = new TheLoai();
                
                using (var f = TagLib.File.Create(_location))
                {
                    _track.Tua = string.IsNullOrWhiteSpace(f.Tag.Title) ? Path.GetFileNameWithoutExtension(_track.Url) : f.Tag.Title.Replace("\0", "");
                    _casi.TenCaSi = string.IsNullOrWhiteSpace(f.Tag.FirstPerformer) ? UNKNOW : f.Tag.FirstPerformer.Replace("\0", "");
                    _album.AlbumName = string.IsNullOrWhiteSpace(f.Tag.Album) ? UNKNOW : f.Tag.Album.Replace("\0", "");
                    _theloai.TenTheLoai = string.IsNullOrWhiteSpace(f.Tag.FirstGenre) ? UNKNOW : f.Tag.FirstGenre.Replace("\0", "");
                    _track.ThoiLuong = f.Properties.Duration;
                    _track.IsLove = false;
                    _track.NgayThemVao = DateTime.Now;
                    _track.Url = _location;
                }

                if (!dbcontext.Albums.Any(x => x.AlbumName == _album.AlbumName))
                {
                    dbcontext.Albums.Add(_album);
                }
                if (!dbcontext.CaSis.Any(x => x.TenCaSi == _casi.TenCaSi))
                {
                    dbcontext.CaSis.Add(_casi);
                }
                if (!dbcontext.TheLoais.Any(x => x.TenTheLoai == _theloai.TenTheLoai))
                {
                    dbcontext.TheLoais.Add(_theloai);
                }
                dbcontext.SaveChanges();

                _track.AlbumId = dbcontext.Albums.Where(x => x.AlbumName == _album.AlbumName).FirstOrDefault().Id;
                _track.CaSiId = dbcontext.CaSis.Where(x => x.TenCaSi == _casi.TenCaSi).FirstOrDefault().Id;
                _track.TheLoaiId = dbcontext.TheLoais.Where(x => x.TenTheLoai == _theloai.TenTheLoai).FirstOrDefault().Id;

                dbcontext.Tracks.Add(_track);

                dbcontext.SaveChanges();

                return _track;
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        // Get file info from DB

            // Để đây mai rảnh làm tiếp
            // g9

        public static byte[] GetCoverArt(Track _track)
        {
            using (var f = TagLib.File.Create(_track.Url))
            {
                byte[] _image = null;

                _image = f.Tag.Pictures[0].Data.Data;

                return _image;
            }
        }

        public static void TrackProcess(string[] filespaths)
        {
            for (int i = 0; i < filespaths.Length; i++)
            {
                string ext = System.IO.Path.GetExtension(filespaths[i]).ToUpperInvariant();
                if (ext == ".M4A" || ext == ".MP3")
                {
                    ReadTrack(filespaths[i]);
                }
            }
        }

        public static void ReseedIdentity()
        {
            dbcontext.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Albums', RESEED, 0)");
            dbcontext.Database.ExecuteSqlCommand("DBCC CHECKIDENT('CaSi', RESEED, 0)");
            dbcontext.Database.ExecuteSqlCommand("DBCC CHECKIDENT('TheLoai', RESEED, 0)");
            dbcontext.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Track', RESEED, 0)");
        }

        public static List<string> ScanFolder(string path)
        {
            List<string> _files = new List<string>();

            // Collect files from a path
            _files.AddRange(Directory.GetFiles(path));

            // Get subDirectories
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            // Recurse to get files/subDirectories
            foreach (string subdirectory in subdirectoryEntries)
                _files.AddRange(ScanFolder(subdirectory));

            return _files;
        }
    }

    static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom => Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId)));
    }
    public static class MyExtension
    {
        public static ObservableCollection<T> Shuffle<T>(this ObservableCollection<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }
    }
}
