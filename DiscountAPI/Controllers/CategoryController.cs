using AutoMapper;
using DiscountAPI.Models.DTO;
using DiscountAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DiscountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = categoryRepository.GetAllCategory();
            return Ok(mapper.Map<List<CategoryDTO>>(categories));
        }

        [HttpGet("{id}",  Name="GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var category = categoryRepository.GetCategory(id);
            if (category == null) return NotFound();
            return Ok(mapper.Map<CategoryDTO>(category));

        }
    }
}