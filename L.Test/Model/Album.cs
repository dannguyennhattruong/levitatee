using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace L.Test.Model
{
    public class Album : PropertyChangedBase
    {
        private int id;
        private string albumName;
        
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [Required, MaxLength(128)]
        public string AlbumName
        {
            get { return albumName; }
            set
            {
                if (value != albumName)
                {
                    SetProperty(value, ref albumName);
                    OnPropertyChanged("AlbumName");
                }
            }
        }

        public Album()
        {
            Id = 0;
            AlbumName = "Unknow";
        }


        public virtual IEnumerable<Track> Tracks { get; set; }
    }
}
