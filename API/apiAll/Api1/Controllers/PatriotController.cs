using api_model;
using api_service;
using Microsoft.AspNetCore.Mvc;
namespace Api1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatriotController : Controller
    {
        public PatriotController(patriotService p)
        {
            patriots = p;
        }
        readonly patriotService patriots;
        [HttpGet]
        public IEnumerable<Loction> Get()
        {
            return patriots.Getdata();
        }
        [HttpGet]
        [Route("GetByLocation")]
        public IEnumerable<Loction> GetByLocation(string city)
        {
            return patriots.Getdata().Where(l => l.City == city).ToList();
        }
        [HttpPost]
        public bool post(Loction location)
        {
            return patriots.add(location);
        }
        [HttpGet]
        [Route("GetLocation")]
        public IEnumerable<string> GetLocation()
        {
            return patriots.Getdata().Select(x=>x.City).ToList();
        }
    }
}
