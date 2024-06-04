namespace DZ_c_ch_Tovar_i_magazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoreInventory storeInventory = new StoreInventory();
            Random rnd = new Random();
            for (int i = 1; i < 100; i++) 
            {
                int value = rnd.Next(100, 5000);
                storeInventory.AddStoreItem(new StoreItem(i, value));

            }

            var LowPrice = storeInventory.RangeListToPrice(100, 1000);
            LowPrice = LowPrice.OrderByDescending(x => x.Price);
            foreach (StoreItem item in LowPrice)
            {
                Console.WriteLine($"Id: {item.ItemId},  Price: {item.Price}");
            }
            Console.WriteLine();
            var MidPrice = storeInventory.RangeListToPrice(1001, 3500);
            MidPrice = MidPrice.OrderByDescending(x => x.Price);
            foreach (StoreItem item in MidPrice)
            {
                Console.WriteLine($"Id: {item.ItemId},  Price: {item.Price}");
            }
            Console.WriteLine();
            var HighPrice = storeInventory.RangeListToPrice(3501, 5000);
            HighPrice = HighPrice.OrderByDescending(x => x.Price);
            foreach (StoreItem item in HighPrice)
            {
                Console.WriteLine($"Id: {item.ItemId},  Price: {item.Price}");
            }

            var setnewprice = storeInventory.GetStoreItem(45);
            setnewprice.FirstOrDefault().SetNewPrice(4777);

            Console.WriteLine();
            HighPrice = storeInventory.RangeListToPrice(3501, 5000);
            HighPrice = HighPrice.OrderByDescending(x => x.Price);
            foreach (StoreItem item in HighPrice)
            {
                Console.WriteLine($"Id: {item.ItemId},  Price: {item.Price}");
            }

            storeInventory.AddStoreItem(new StoreItem(47, 3500));


        }


    }



}
