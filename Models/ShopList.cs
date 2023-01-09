using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Dragut_Hanc_Mobil.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }


        [MaxLength(250),Unique]
        public string Description { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey(typeof(Shop))]
        public int ShopID { get; set; }
        public string ShopName { get; set; }

    }
}
