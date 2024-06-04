using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_Tovar_i_magazin
{
    public class StoreItem : IStoreItem
    {
       public int ItemId { get; set; }
       public int Price { get; set; }

        public StoreItem(int itemId, int price) 
        {
            ItemId = itemId;
            Price = price;
        }

        public void SetNewPrice(int price)
        {
            Price = price;
        }

    }
}
