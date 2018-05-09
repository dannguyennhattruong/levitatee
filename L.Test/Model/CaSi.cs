using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace L.Test.Model
{
    [Table("CaSi")]
    public class CaSi : PropertyChangedBase
    {
        private int id;
        private string tenCaSi;
        
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
        public string TenCaSi
        {
            get { return tenCaSi; }
            set
            {
                if (value != tenCaSi)
                {
                    SetProperty(value, ref tenCaSi);
                    OnPropertyChanged("TenCaSi");
                }
            }
        }

        public CaSi()
        {
            Id = 0;
            TenCaSi = "Unknow";
        }


        public virtual IEnumerable<Track> Tracks { get; set; }
    }
}
