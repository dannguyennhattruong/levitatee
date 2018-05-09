using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace L.Test.Model
{
    public enum MediaKind
    {
        Song,
        Video
    }

    [Serializable, XmlType(TypeName = "Track")]
    [Table("Track")]
    public class Track : PropertyChangedBase
    {
        #region Declaration
        private int id;
        private string tua;
        private string url;
        private TimeSpan thoiLuong;
        private int? albumId;
        private int? caSiId;
        private int? theLoaiId;
        private bool? isLove;
        private DateTime ngayThemVao;
        private MediaKind mediaKind;
        
        [XmlElement("Id")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return id; }
            set
            {
                if (value != id)
                {
                    SetProperty(value, ref id);
                    OnPropertyChanged("Id");
                }
            }
        }
        [XmlIgnore]
        [Required, MaxLength(128)]
        public string Tua
        {
            get { return tua; }
            set
            {
                if (value != tua)
                {
                    SetProperty(value, ref tua);
                    OnPropertyChanged("Tua");
                }
            }
        }
        [XmlIgnore]
        [Required]
        public string Url
        {
            get { return url; }
            set
            {
                if (value != url)
                {
                    SetProperty(value, ref url);
                    OnPropertyChanged("Url");
                }
            }
        }
        [XmlIgnore]
        [Required]
        public TimeSpan ThoiLuong
        {
            get { return thoiLuong; }
            set
            {
                if (value != thoiLuong)
                {
                    SetProperty(value, ref thoiLuong);
                    OnPropertyChanged("ThoiLuong");
                }
            }
        }
        [XmlIgnore]
        [Required]
        public int? AlbumId
        {
            get { return albumId; }
            set
            {
                if (value != albumId)
                {
                    SetProperty(value, ref albumId);
                    OnPropertyChanged("AlbumId");
                }
            }
        }
        [XmlIgnore]
        [Required]
        public int? CaSiId
        {
            get { return caSiId; }
            set
            {
                if (value != caSiId)
                {
                    SetProperty(value, ref caSiId);
                    OnPropertyChanged("CaSiId");
                }
            }
        }
        [XmlIgnore]
        [Required]
        public int? TheLoaiId
        {
            get { return theLoaiId; }
            set
            {
                if (value != theLoaiId)
                {
                    SetProperty(value, ref theLoaiId);
                    OnPropertyChanged("TheLoaiId");
                }
            }
        }
        [XmlIgnore]
        public bool? IsLove
        {
            get { return isLove; }
            set
            {
                if (value != isLove)
                {
                    SetProperty(value, ref isLove);
                    OnPropertyChanged("IsLove");
                }
            }
        }
        [XmlIgnore]
        public DateTime NgayThemVao
        {
            get { return ngayThemVao; }
            set
            {
                if (value != ngayThemVao)
                {
                    SetProperty(value, ref ngayThemVao);
                    OnPropertyChanged("NgayThemVao");
                }
            }
        }
        [XmlIgnore]
        public MediaKind MediaKind
        {
            get { return mediaKind; }
            set { mediaKind = value; }
        }

        [XmlIgnore]
        [NotMapped]
        public string TrueDuration => ThoiLuong.ToString(ThoiLuong.Hours == 0 ? @"mm\:ss" : @"hh\:mm\:ss");
        [XmlIgnore]
        [NotMapped]
        public bool IsExist => File.Exists(this.Url);
        [XmlIgnore]
        [NotMapped]
        public string Lyrics { get; set; }
        [XmlIgnore]
        [NotMapped]
        public byte[] CoverArt { get; set; }
        #endregion
        
        //Ctor
        public Track()
        {
            //
        }



        [XmlIgnore]
        [ForeignKey("AlbumId")]
        public virtual Album Album { get; set; }
        [XmlIgnore]
        [ForeignKey("CaSiId")]
        public virtual CaSi CaSi { get; set; }
        [XmlIgnore]
        [ForeignKey("TheLoaiId")]
        public virtual TheLoai TheLoai { get; set; }
        


        public void OpenTrackLocation()
        {
            if (this.IsExist)
                Process.Start("explorer.exe", "/select, \"" + Url + "\"");
        }

        public bool Equals(Track other)
        {
            if (other == null) return false;
            if (!other.IsExist || !this.IsExist) return false;
            if (GetType() != other.GetType()) return false;
            if (other.Url == this.Url) return true;
            return false;
        }

        public override string ToString()
        {
            var s = Tua + " " + CaSi + " " + Album + " " + TheLoai;
            return s.ToUpper();
        }
    }
}
