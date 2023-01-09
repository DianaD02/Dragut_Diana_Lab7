using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Dragut_Hanc_Mobil.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement] 
        public int ID { get; set; }
        public string Description { get; set; }
        [OneToMany]
        public List<ListProduct> ListProducts { get; set; }
        
        

    }

    
}
