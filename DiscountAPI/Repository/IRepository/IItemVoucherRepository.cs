using DiscountAPI.Models;
using System.Collections.Generic;

namespace DiscountAPI.Repository.IRepository
{
    public interface IItemVoucherRepository
    {
        IEnumerable<ItemsVoucher> GetItemsVoucher(string title);
        ItemsVoucher UpdateItemsVoucher(ItemsVoucher itemsVoucher);
        bool CreateItemVoucher(ItemsVoucher itemsVoucher);
        bool DeleteItemVoucher( int itemId);
        bool ItemVoucherExists(int id);
        ItemsVoucher GetItemVoucher(int id);
        bool Save();

    }
}
