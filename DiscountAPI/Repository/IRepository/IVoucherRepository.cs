using DiscountAPI.Models;

namespace DiscountAPI.Repository.IRepository
{
    public interface IVoucherRepository
    {
        Voucher GetVoucher(string title);
        Voucher UpdateVoucher(Voucher voucher);
        bool DeleteVoucher(string title);
        bool VoucherExits(string title);
    }
}
