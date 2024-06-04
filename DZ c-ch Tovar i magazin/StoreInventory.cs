using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_Tovar_i_magazin
{
    public class StoreInventory
    {
        public List<StoreItem> storeItems = new List<StoreItem>();

        public void AddStoreItem(StoreItem item)
        {
            bool check = false;
            try
            {
                foreach (var i in storeItems)
                {
                    if (i.ItemId == item.ItemId)
                    {
                        check = true;   
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Такой товар уже есть");
            }
            if (check == false)
                storeItems.Add(item);
            else
                return;


        }
        public void RemoveStoreItem(StoreItem item)
        {
            storeItems.Remove(item);
        }

        public IEnumerable<StoreItem> GetStoreItem(int id)
        {

            return storeItems.Where(e=>e.ItemId == id);

        }

        public IEnumerable<StoreItem> RangeListToPrice(int min, int max)
        {
            return storeItems.Where(a=>a.Price > min && a.Price < max);
        }

        public IEnumerable<StoreItem> SortByPrice()
        {
            return storeItems.OrderByDescending(a => a.Price);

        }

    }
}
