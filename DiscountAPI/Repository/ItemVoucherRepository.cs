using DiscountAPI.Context;
using DiscountAPI.Models;
using DiscountAPI.Repository.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace DiscountAPI.Repository
{
    public class ItemVoucherRepository : IItemVoucherRepository
    {
        private readonly ApplicationDbContext context;
        public ItemVoucherRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool DeleteItemVoucher(int itemId)
        {
            var itemVoucher = context.ItemsVoucher.FirstOrDefault(iv => iv.Id.Equals(itemId));

            this.context.ItemsVoucher.Remove(itemVoucher);

            return Save();
        }

        public IEnumerable<ItemsVoucher> GetItemsVoucher(string title)
        {
            var items = context.ItemsVoucher.Where(v => v.TitleVoucher == title).ToList();

            return items;
        }

        public ItemsVoucher GetItemVoucher(int id)
        {
            return context.ItemsVoucher.FirstOrDefault(i => i.Id.Equals(id));
        }


        public ItemsVoucher UpdateItemsVoucher(ItemsVoucher itemsVoucher)
        {
            throw new System.NotImplementedException();
        }

        public bool ItemVoucherExists(int id)
        {
            return context.ItemsVoucher.Any(x => x.Id.Equals(id));
        }

        public bool Save()
        {
            return context.SaveChanges() > 0 ? true : false;
        }

        public bool CreateItemVoucher(ItemsVoucher itemsVoucher)
        {
            context.ItemsVoucher.Add(itemsVoucher);
            return Save();
        }
    }
}
