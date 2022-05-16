using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscountAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiscountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherRepository voucherRepository;
        public VoucherController(IVoucherRepository voucherRepository)
        {
            this.voucherRepository = voucherRepository;            
        }

        [HttpGet("{title}", Name = "GetVoucher")]
        public IActionResult GetVoucher(string title)
        {
            var voucher = voucherRepository.GetVoucher(title);

            return Ok(voucher);
        }
    }
}