using System.Collections.Generic;
using AutoMapper;
using DiscountAPI.Models.DTO;
using DiscountAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DiscountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockRepository stockRepository;
        private readonly IMapper mapper;

        public StockController(IStockRepository stockRepository, IMapper mapper)
        {
            this.stockRepository = stockRepository;
            this.mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAllStock()
        {
            var stock = stockRepository.GetAllStock();
            var stockDTO= new List<StockDTO>();
            foreach (var s in stock)
            {
                var stDTO = mapper.Map<StockDTO>(s);
                stDTO.nameStore = s.StoreStock.Name;
                stDTO.nameProduct = s.ProductStock.Name;

                stockDTO.Add(stDTO);
            }
            
            return Ok(stockDTO);
        }
    }
}