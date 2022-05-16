using DiscountAPI.Models;
using DiscountAPI.Repository;
using DiscountAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DiscountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsVoucherController : ControllerBase
    {
        private readonly IVoucherRepository voucherRepository;
        private readonly IItemVoucherRepository itemsVoucherRepository;
        public ItemsVoucherController(IItemVoucherRepository itemsVoucherRepository, IVoucherRepository voucherRepository)
        {
            this.itemsVoucherRepository = itemsVoucherRepository;
            this.voucherRepository = voucherRepository;
        }

        [HttpGet("voucher/{title}", Name = "GetItemsVoucher")]
        public IActionResult GetItemsVoucher(string title)
        {
            var items = itemsVoucherRepository.GetItemsVoucher(title);

            return Ok(items);
        }

        [HttpGet("{id}", Name ="GetItemVoucher")]
        public IActionResult GetItemVoucher(int id)
        {
            var item = itemsVoucherRepository.GetItemVoucher(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItemVoucher(int id)
        {
            if (!itemsVoucherRepository.ItemVoucherExists(id)) return NotFound();

            if (!itemsVoucherRepository.DeleteItemVoucher(id))
            {
                ModelState.AddModelError(string.Empty, $"Error to delete item voucher {id}");
                return StatusCode(500, ModelState);
            }

            return NoContent();

        }

        [HttpPost]
        public IActionResult CreateItemVoucher([FromBody] ItemsVoucher itemsVoucher)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!voucherRepository.VoucherExits(itemsVoucher.TitleVoucher))
            {
                ModelState.AddModelError(string.Empty, $"the Voucher {itemsVoucher.TitleVoucher} dosen't exists");
                return StatusCode(404, ModelState);
            }

            if (!itemsVoucherRepository.CreateItemVoucher(itemsVoucher))
            {
                ModelState.AddModelError(string.Empty, $"Error to create item {itemsVoucher.Item} of {itemsVoucher.TitleVoucher}");
                return StatusCode(500, ModelState);
            }

            return CreatedAtRoute("GetItemVoucher", new { id = itemsVoucher.Id }, itemsVoucher);

        }

    }
}