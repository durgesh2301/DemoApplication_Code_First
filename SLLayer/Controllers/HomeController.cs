using AutoMapper;
using DALLayer;
using DALLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace SLLayer.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : Controller
    {
        private Repository _repository;
        private IMapper _mapper;
        public HomeController(Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public JsonResult GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                categories = _repository.GetAllCategories();
            }
            catch (Exception ex)
            {
                categories = null;
            }
            return Json(categories);
        }
    }
}
