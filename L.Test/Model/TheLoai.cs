using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace L.Test.Model
{
    [Table("TheLoai")]
    public class TheLoai : PropertyChangedBase
    {
        #region Declaration
        private int id;
        private string tenTheLoai;
        
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
        public string TenTheLoai
        {
            get { return tenTheLoai; }
            set
            {
                if (value != tenTheLoai)
                {
                    SetProperty(value, ref tenTheLoai);
                    OnPropertyChanged("TenTheLoai");
                }
            }
        }
        #endregion

        
        public TheLoai()
        {
            Id = 0;
            TenTheLoai = "Unknow";
        }


        public virtual IEnumerable<Track> Tracks { get; set; }
    }
}
