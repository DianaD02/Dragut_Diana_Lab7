using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Dragut_Hanc_Mobil.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(ShopList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }

    }
}