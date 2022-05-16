using DiscountAPI.Context;
using DiscountAPI.Models;
using DiscountAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DiscountAPI.Repository
{
    public class VoucherRepository : IVoucherRepository
    {
        private readonly ApplicationDbContext context;
        public VoucherRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool DeleteVoucher(string title)
        {
            throw new NotImplementedException();
        }

        public Voucher GetVoucher(string title)
        {
            var items = context.Voucher
                .Include(i => i.ItemsVoucher)
                .FirstOrDefault(v => v.Title.Equals(title));

            return items;
        }

        public Voucher UpdateVoucher(Voucher voucher)
        {
            throw new NotImplementedException();
        }

        public bool VoucherExits(string title)
        {
            return context.Voucher.Any(v => v.Title.Equals(title));
        }
    }
}
