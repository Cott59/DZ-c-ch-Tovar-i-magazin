using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_Tovar_i_magazin
{
    public interface IStoreItem
    {
        int ItemId { get;}
        int Price { get; }

        void SetNewPrice(int price);
        
    }
}
